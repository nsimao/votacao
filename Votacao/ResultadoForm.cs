using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Votacao.Model;

namespace Votacao
{
    public partial class ResultadoForm : Form
    {
        private List<Voto> lstVotos = null;
        private int TotalVotos { get; set; }
        private int TotalVotosValidos { get; set; }
        private int TotalVotosBrancos { get; set; }
        private int TotalVotosNulos { get; set; }

        private ApplicationCore applicationCore = null;

        public ResultadoForm()
        {
            InitializeComponent();
            applicationCore = new ApplicationCore();
        }

        private void btnGerarResultados_Click(object sender, EventArgs e)
        {
            CarregarVotos();

            if (TotalVotos == 0)
            {
                MessageBox.Show("Não existem votos!", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grdGeral.DataSource = null;

            GetResultadoGeral();

            GetResultadoSexo();

            GetResultadoSala();
        }

        private double GetPercentual(double total, double quantidade)
        {
            if (total == 0)
                return 0;

            return Math.Round((double)(quantidade * 100.0) / total, 2);
        }

        private void CarregarVotos()
        {
            lblStatus.Visible = true;
            this.Update();
            lstVotos = applicationCore.LoadVotos();

            TotalVotos = lstVotos.Count;
            TotalVotosNulos = lstVotos.Count(v => v.Candidato.Partido == UrnaConstantes.VOTO_NULO);
            TotalVotosBrancos = lstVotos.Count(v => v.Candidato.Partido == UrnaConstantes.VOTO_BRANCO);
            TotalVotosValidos = TotalVotos - (TotalVotosBrancos + TotalVotosNulos);

            lblTotal.Text = TotalVotos.ToString();
            lblValidos.Text = TotalVotosValidos + " - " + GetPercentual(TotalVotos, TotalVotosValidos) + " %";
            lblBrancos.Text = TotalVotosBrancos + " - " + GetPercentual(TotalVotos, TotalVotosBrancos) + " %";
            lblNulos.Text = TotalVotosNulos + " - " + GetPercentual(TotalVotos, TotalVotosNulos) + " %";

            grdGeral.DataSource = null;

            grdSexoTotalizador.DataSource = null;
            grdSexoDetalhe.DataSource = null;

            grdSalaTotalizador.DataSource = null;
            grdSalaDetalhe.DataSource = null;

            lblStatus.Visible = false;
            this.Update();
        }

        private void GetResultadoGeral()
        {
            var lstGeral = lstVotos.Where(v => v.Candidato.Partido != UrnaConstantes.VOTO_NULO && v.Candidato.Partido != UrnaConstantes.VOTO_BRANCO)
                                   .GroupBy(l => l.Candidato.Partido)
                                   .Select(lg =>
                                        new
                                        {
                                            Partido = lg.Key,
                                            Candidato = lg.First().Candidato.Nome,
                                            Vice = lg.First().Candidato.Vice,
                                            Votos = lg.Count(),
                                            Percentual = GetPercentual(TotalVotosValidos, lg.Count()) + " %"
                                        })
                                        .OrderByDescending(o => o.Votos);

            grdGeral.DataSource = lstGeral.ToList();
            if (grdGeral.RowCount > 0)
                grdGeral.Rows[0].Selected = true;
        }

        private void GetResultadoSexo()
        {
            // Totalizador
            var lstPorSexoTotalizador = lstVotos.GroupBy(row => row.Sexo)
                                                .Select(lg =>
                                                        new Totalizador()
                                                        {
                                                            Descricao = lg.Key,
                                                            TotalVotos = lg.Count(),
                                                            VotosValidos = lg.Count(v => v.Candidato.Partido != UrnaConstantes.VOTO_BRANCO &&
                                                                                         v.Candidato.Partido != UrnaConstantes.VOTO_NULO),
                                                            VotosBrancos = lg.Count(v => v.Candidato.Partido == UrnaConstantes.VOTO_BRANCO),
                                                            VotosNulos = lg.Count(v => v.Candidato.Partido == UrnaConstantes.VOTO_NULO)
                                                        })
                                                .OrderBy(o => o.Descricao)
                                                .ToList();

            foreach (Totalizador item in lstPorSexoTotalizador)
            {
                item.VotosValidosPercentual = GetPercentual(Convert.ToDouble(item.TotalVotos), Convert.ToDouble(item.VotosValidos)) + " %";
                item.VotosBrancosPercentual = GetPercentual(Convert.ToDouble(item.TotalVotos), Convert.ToDouble(item.VotosBrancos)) + " %";
                item.VotosNulosPercentual = GetPercentual(Convert.ToDouble(item.TotalVotos), Convert.ToDouble(item.VotosNulos)) + " %";
            }

            grdSexoTotalizador.DataSource = lstPorSexoTotalizador;
            if (grdSexoTotalizador.RowCount > 0)
                grdSexoTotalizador.Rows[0].Selected = true;


            // Detalhe
            var lstPorSexoDetalhe = lstVotos.GroupBy(row => new { row.Sexo, row.Candidato.Partido })
                                   .Select(lg =>
                                        new
                                        {
                                            Sexo = lg.Key.Sexo,
                                            Partido = lg.Key.Partido,
                                            Candidato = lg.First().Candidato.Nome,
                                            Vice = lg.First().Candidato.Vice,
                                            Votos = lg.Count(),
                                            PercentualVotosValidos = (lg.Key.Partido == UrnaConstantes.VOTO_BRANCO ||
                                                                      lg.Key.Partido == UrnaConstantes.VOTO_NULO) ? "0 %"
                                                                      : GetPercentual(lstPorSexoTotalizador.FirstOrDefault(t => t.Descricao == lg.Key.Sexo).VotosValidos
                                                                      , lg.Count()) + " %"
                                        })
                                    .OrderBy(o => o.Sexo)
                                    .ThenByDescending(o => o.Votos)
                                    .ThenBy(o => o.Partido);

            grdSexoDetalhe.DataSource = lstPorSexoDetalhe.ToList();
            if (grdSexoDetalhe.RowCount > 0)
                grdSexoDetalhe.Rows[0].Selected = true;
        }

        private void GetResultadoSala()
        {
            // Totalizador
            var lstPorSalaTotalizador = lstVotos.GroupBy(row => row.Sala)
                                                .Select(lg =>
                                                        new Totalizador()
                                                        {
                                                            Descricao = lg.Key,
                                                            TotalVotos = lg.Count(),
                                                            VotosValidos = lg.Count(v => v.Candidato.Partido != UrnaConstantes.VOTO_BRANCO &&
                                                                                         v.Candidato.Partido != UrnaConstantes.VOTO_NULO),
                                                            VotosBrancos = lg.Count(v => v.Candidato.Partido == UrnaConstantes.VOTO_BRANCO),
                                                            VotosNulos = lg.Count(v => v.Candidato.Partido == UrnaConstantes.VOTO_NULO)
                                                        })
                                                .OrderBy(o => o.Descricao)
                                                .ToList();

            foreach (Totalizador item in lstPorSalaTotalizador)
            {
                item.VotosValidosPercentual = GetPercentual(Convert.ToDouble(item.TotalVotos), Convert.ToDouble(item.VotosValidos)) + " %";
                item.VotosBrancosPercentual = GetPercentual(Convert.ToDouble(item.TotalVotos), Convert.ToDouble(item.VotosBrancos)) + " %";
                item.VotosNulosPercentual = GetPercentual(Convert.ToDouble(item.TotalVotos), Convert.ToDouble(item.VotosNulos)) + " %";
            }

            grdSalaTotalizador.DataSource = lstPorSalaTotalizador;
            if (grdSalaTotalizador.RowCount > 0)
                grdSalaTotalizador.Rows[0].Selected = true;


            // Detalhes
            var lstPorSala = lstVotos.GroupBy(row => new { row.Sala, row.Candidato.Partido })
                                   .Select(lg =>
                                        new
                                        {
                                            Sala = lg.Key.Sala,
                                            Partido = lg.Key.Partido,
                                            Candidato = lg.First().Candidato.Nome,
                                            Vice = lg.First().Candidato.Vice,
                                            Votos = lg.Count(),
                                            PercentualVotosValidos = (lg.Key.Partido == UrnaConstantes.VOTO_BRANCO ||
                                                                      lg.Key.Partido == UrnaConstantes.VOTO_NULO) ? "0 %"
                                                                      : GetPercentual(lstPorSalaTotalizador.FirstOrDefault(t => t.Descricao == lg.Key.Sala).VotosValidos
                                                                      , lg.Count()) + " %"
                                        })
                                    .OrderBy(o => o.Sala)
                                    .ThenByDescending(o => o.Votos)
                                    .ThenBy(o => o.Partido);

            grdSalaDetalhe.DataSource = lstPorSala.ToList();
            if (grdSalaDetalhe.RowCount > 0)
                grdSalaDetalhe.Rows[0].Selected = true;
        }
    }

    public class Totalizador
    {
        public string Descricao { get; set; }
        public double TotalVotos { get; set; }
        public double VotosValidos { get; set; }
        public string VotosValidosPercentual { get; set; }
        public double VotosBrancos { get; set; }
        public string VotosBrancosPercentual { get; set; }
        public double VotosNulos { get; set; }
        public string VotosNulosPercentual { get; set; }
    }
}

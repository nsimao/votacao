using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Votacao.Model;

namespace Votacao
{
    public class ApplicationCore
    {
        private string ApplicationCurrentPath = string.Empty;

        public List<Candidato> Candidatos { get; private set; }

        public ApplicationCore()
        {
            ApplicationCurrentPath = AppDomain.CurrentDomain.BaseDirectory;
            LoadCandidatos();
        }

        private void LoadCandidatos()
        {
            string fileCandidatosPath = Path.Combine(ApplicationCurrentPath, @"Dados\Candidatos.txt");
            var lines = File.ReadAllLines(fileCandidatosPath);

            Candidatos = new List<Candidato>();

            foreach (var line in lines)
            {
                string[] dadosCandidato = line.Split(';');
                Candidatos.Add(new Candidato()
                {
                    Partido = dadosCandidato[0],
                    Nome = dadosCandidato[1],
                    Vice = dadosCandidato[2],
                    PathImagem = Path.Combine(ApplicationCurrentPath, dadosCandidato[3])
                });
            }

            Candidatos.Add(new Candidato()
            {
                Partido = UrnaConstantes.VOTO_BRANCO,
                Nome = UrnaConstantes.VOTO_BRANCO,
                Vice = UrnaConstantes.VOTO_BRANCO,
                PathImagem = string.Empty
            });

            Candidatos.Add(new Candidato()
            {
                Partido = UrnaConstantes.VOTO_NULO,
                Nome = UrnaConstantes.VOTO_NULO,
                Vice = UrnaConstantes.VOTO_NULO,
                PathImagem = string.Empty
            });
        }

        private string GetPathVotos()
        {
            return Path.Combine(ApplicationCurrentPath, @"Dados\Votos.txt");
        }

        public int GetQtdCandidatos()
        {
            return Candidatos.Count;
        }

        public List<Voto> LoadVotos()
        {
            string fileVotosPath = GetPathVotos();
            var lines = File.ReadAllLines(fileVotosPath);

            List<Voto> votos = new List<Voto>();

            foreach (var line in lines)
            {
                string[] dadosVoto = line.Split(';');
                votos.Add(new Voto()
                {
                    DataHora = Convert.ToDateTime(dadosVoto[0]),
                    Sala = dadosVoto[1],
                    Sexo = dadosVoto[2],
                    Candidato = GetCandidato(dadosVoto[3])
                });
            }

            return votos;
        }

        public Candidato GetCandidato(string partido)
        {
            return Candidatos.FirstOrDefault(c => c.Partido == partido);
        }

        public void ExcluirVotos()
        {
            string fileVotosPath = GetPathVotos();

            if (File.Exists(fileVotosPath))
                File.Delete(fileVotosPath);
        }

        public bool ComputarVoto(string sala, string sexoVotante, string partido)
        {
            try
            {
                string fileVotosPath = GetPathVotos();

                using (StreamWriter vwriter = new StreamWriter(fileVotosPath, true))
                {
                    StringBuilder sbVoto = new StringBuilder();

                    sbVoto.Append(DateTime.Now.ToString());
                    sbVoto.Append(";");
                    sbVoto.Append(sala);
                    sbVoto.Append(";");
                    sbVoto.Append(sexoVotante);
                    sbVoto.Append(";");
                    sbVoto.Append(partido);
                    vwriter.WriteLine(sbVoto);
                    vwriter.Flush();
                }

                return true;
            }
            catch (Exception ex)
            {
                StringBuilder sbErro = new StringBuilder();

                if (ex != null)
                {
                    sbErro.Append(" Exception -> " + ex.Message);

                    if (ex.InnerException != null)
                    {
                        sbErro.Append(Environment.NewLine);
                        sbErro.Append(" InnerException -> " + ex.InnerException.ToString());
                    }

                    if (!string.IsNullOrEmpty(ex.StackTrace))
                    {
                        sbErro.Append(Environment.NewLine);
                        sbErro.Append(" StackTrace -> " + ex.StackTrace);
                    }

                    MessageBox.Show("Erro ao processar voto: " + sbErro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
        }
    }
}

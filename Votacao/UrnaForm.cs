using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Votacao.Model;

namespace Votacao
{
    public partial class UrnaForm : Form
    {
        private string Sala;
        private ApplicationCore applicationCore;
        private EstadoTela EstadoAtualTela = EstadoTela.Inicial;

        public UrnaForm(string sala)
        {
            InitializeComponent();
            applicationCore = new ApplicationCore();
            Sala = sala;
            lblVoto.Text = string.Format("Sala {0} - Entre com seu voto:", sala);
            SetTela(EstadoTela.Inicial);
        }

        private void SetTela(EstadoTela estadotela)
        {
            GroupBox gbParaPosicionar = null;

            gbInicio.Visible = estadotela == EstadoTela.Inicial;
            gbVoto.Visible = estadotela == EstadoTela.Votando;
            gbFim.Visible = estadotela == EstadoTela.Finalizado;

            switch (estadotela)
            {
                case EstadoTela.Inicial:
                    gbParaPosicionar = gbInicio;
                    cmbSexo.Focus();
                    break;
                case EstadoTela.Votando:
                    gbParaPosicionar = gbVoto;
                    txtNumero.Focus();
                    break;
                case EstadoTela.Finalizado:
                    gbParaPosicionar = gbFim;
                    break;
                default:
                    gbParaPosicionar = gbInicio;
                    break;
            }

            gbParaPosicionar.Location = new Point(12, 8);

            EstadoAtualTela = estadotela;

            this.Update();
        }

        private bool ComputarVoto()
        {
            return applicationCore.ComputarVoto(Sala, cmbSexo.Text.Substring(0, 1), lblPartido.Text);
        }

        private string GetPartidoSelecionado()
        {
            return txtNumero.Text.Trim();
        }

        private void LimparTela()
        {
            cmbSexo.Text = string.Empty;
            txtNumero.Text = string.Empty;
            lblNomeCandidato.Text = string.Empty;
            lblVice.Text = string.Empty;
            lblPartido.Text = string.Empty;
            pictureBoxCandidato.Image = null;
        }

        private void btnIniciarVotacao_Click(object sender, System.EventArgs e)
        {
            if ((cmbSexo.Text.ToUpper() != "FEMININO") &&
                (cmbSexo.Text.ToUpper() != "MASCULINO"))
            {
                MessageBox.Show("Selecione o sexo do votante!", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetTela(EstadoTela.Votando);
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(lblPartido.Text))
            {
                MessageBox.Show("Voto inválido!", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ComputarVoto())
            {
                SetTela(EstadoTela.Finalizado);
                LimparTela();
                Thread.Sleep(1000);
                SetTela(EstadoTela.Inicial);
            }
        }

        private void btnCorrige_Click(object sender, System.EventArgs e)
        {
            string partidoSelecionado = GetPartidoSelecionado();

            if (!string.IsNullOrEmpty(partidoSelecionado))
            {
                txtNumero.Text = partidoSelecionado.Substring(0, partidoSelecionado.Length - 1);
            }
        }

        private void btnBranco_Click(object sender, System.EventArgs e)
        {
            txtNumero.Text = string.Empty;
            pictureBoxCandidato.Image = null;
            lblNomeCandidato.Text = UrnaConstantes.VOTO_BRANCO;
            lblVice.Text = UrnaConstantes.VOTO_BRANCO;
            lblPartido.Text = UrnaConstantes.VOTO_BRANCO;
        }

        private void txtNumero_TextChanged(object sender, System.EventArgs e)
        {
            string partidoSelecionado = GetPartidoSelecionado();

            if (string.IsNullOrEmpty(partidoSelecionado))
            {
                lblNomeCandidato.Text = string.Empty;
                lblVice.Text = string.Empty;
                lblPartido.Text = string.Empty;
            }
            else
            {
                Candidato candidato = applicationCore.GetCandidato(txtNumero.Text);

                if (candidato == null)
                {
                    lblNomeCandidato.Text = UrnaConstantes.VOTO_NULO;
                    lblVice.Text = UrnaConstantes.VOTO_NULO;
                    lblPartido.Text = UrnaConstantes.VOTO_NULO;
                    pictureBoxCandidato.Image = null;
                }
                else
                {
                    lblNomeCandidato.Text = candidato.Nome;
                    lblVice.Text = candidato.Vice;
                    lblPartido.Text = candidato.Partido;
                    pictureBoxCandidato.Image = Image.FromFile(candidato.PathImagem);
                }
            }
        }
    }

    public enum EstadoTela
    {
        Inicial,
        Votando,
        Finalizado
    };
}

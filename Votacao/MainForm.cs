using System.Windows.Forms;

namespace Votacao
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool Login()
        {
            LoginForm loginForm = new LoginForm();
            return loginForm.ShowDialog() == DialogResult.OK;
        }

        private void btnIniciarUrna_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumSala.Text))
            {
                MessageBox.Show("Preencha o número da sala!");
                txtNumSala.Focus();
                return;
            }

            if (!Login())
                return;

            UrnaForm urna = new UrnaForm(txtNumSala.Text);
            urna.ShowDialog();
        }

        private void btnResultados_Click(object sender, System.EventArgs e)
        {
            if (!Login())
                return;

            ResultadoForm resultadoForm = new ResultadoForm();

            resultadoForm.Show();
        }
    }
}

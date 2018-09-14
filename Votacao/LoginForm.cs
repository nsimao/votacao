using System;
using System.Windows.Forms;

namespace Votacao
{
    public partial class LoginForm : Form
    {
        public bool LoginValido { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginValido = txtSenha.Text == "investidura";

            if (!LoginValido)
                MessageBox.Show("Login Inválido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnOK_Click(sender, e);
            }
        }
    }
}

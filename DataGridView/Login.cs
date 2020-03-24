using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();

        string login = "Joao";
        string senha = "123";

        
        public Login()
        {
            InitializeComponent();
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        public void autenticar()
        {
            usuario.Login = login;
            usuario.Senha = senha;

            if ((txtBoxLogin.Text == login) && (txtBoxSenha.Text == senha))
            {

                Boolean loginOK = true;
                Form1 frmcad = new Form1();
                frmcad.Show();
                this.Visible = false;


            }
            else
            {
                MessageBox.Show("Login ou Senha Inválido");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            autenticar();
        }
    }
}


using Azure.Messaging;
using Microsoft.VisualBasic;
using SistemaDeGerenc.BLL;
using SistemaDeGerenc.MODEL;

namespace SistemaDeGerenc.APPv1
{
    public partial class Form_Login_e_Senha : Form
    {
        public Form_Login_e_Senha()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btoLogar(object sender, EventArgs e)
        {
            string usuario = textEmail.Text;
            string senha = textSenha.Text;
            Usuario us = new Usuario();
            us.Email = usuario;
            us.Senha = senha;

            if (!UsuarioBll.AutenticarUsuario(usuario, senha)) 
            {
                var msg1 = MessageBox.Show("Usuario não identificado. Deseja cadastrar ?", "Usuario não encontrado", MessageBoxButtons.YesNo);
                if (msg1 == DialogResult.Yes)
                {
                    //UsuarioBll.CadastrarUsuario(us);
                    MessageBox.Show("cadastrado");
                }
                //
                MessageBox.Show("Muito obrigado por escolher a nossa empresa." );
            } 
            else
            {
               UsuarioBll.GetByEmail(us.Email);
               MessageBox.Show("Seja bem-vindo : " + us.Email);
            }
        }

        private void textBoxEmail(object sender, EventArgs e)
        {

        }

        private void labelLogin(object sender, EventArgs e)
        {

        }

        private void labelTitulo(object sender, EventArgs e)
        {

        }

        private void textBoxSenha(object sender, EventArgs e)
        {

        }

        private void labelSenha(object sender, EventArgs e)
        {

        }


    }
}
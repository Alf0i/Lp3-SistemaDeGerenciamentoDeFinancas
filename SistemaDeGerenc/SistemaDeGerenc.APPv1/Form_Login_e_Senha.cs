
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

            if (!UsuarioBll.AutenticarUsuario(usuario, senha)) {
                UsuarioBll.CadastrarUsuario(us);
                MessageBox.Show("Seja bem-vindo : " + us.Nome);
            } 
            else
            {
                UsuarioBll.GetByEmail(usuario);
                MessageBox.Show("Seja bem-vindo : " + us.Nome);
            }
        }

        private void textBoxUsuario(object sender, EventArgs e)
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
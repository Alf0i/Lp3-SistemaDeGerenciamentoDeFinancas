using SistemaDeGerenc.BLL;
using SistemaDeGerenc.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDeGerenc.APPv1
{
    public partial class FormMenu : Form
    {
        private string email;

        public FormMenu(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void labelMenu(object sender, EventArgs e)
        {

        }

        private void btoRealizaFiltros(object sender, EventArgs e)
        {
            //Form form = new Form(email);
            //Form.ShowDialog();
        }

        private void labelTitulo(object sender, EventArgs e)
        {

        }

        private void btoCadastraDespesa(object sender, EventArgs e)
        {
            Form_cadastra_despesa desp = new Form_cadastra_despesa(email);
            this.Close();
            desp.ShowDialog();
        }

        private void btoCadastraReceita(object sender, EventArgs e)
        {
            Form_cadastra_receita rec = new Form_cadastra_receita(email);
            this.Close();
            rec.ShowDialog();
        }

        private void btoCalculaSaldo(object sender, EventArgs e)
        {
            Form_Login_e_Senha log = new Form_Login_e_Senha();
            double? saldo = UsuarioBll.CalcularSaldo(email);
            MessageBox.Show(saldo.ToString(), "Janela de saldo");
        }

        
    }
}

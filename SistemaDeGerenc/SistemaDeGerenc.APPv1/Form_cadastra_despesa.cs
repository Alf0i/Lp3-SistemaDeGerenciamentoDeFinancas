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

namespace SistemaDeGerenc.APPv1
{
    public partial class Form_cadastra_despesa : Form
    {
        private string email;
        public Form_cadastra_despesa(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void labelValor(object sender, EventArgs e)
        {

        }

        private void labelTitulo(object sender, EventArgs e)
        {

        }

        private void labelCadastraReceita(object sender, EventArgs e)
        {

        }

        private void textBoxValor(object sender, EventArgs e)
        {

        }

        private void labelCategoria(object sender, EventArgs e)
        {

        }

        private void textBoxCategoria(object sender, EventArgs e)
        {

        }

        private void labelDesc(object sender, EventArgs e)
        {

        }

        private void textBoxDesc(object sender, EventArgs e)
        {

        }

        private void btoCadastrar(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textValor.Text);
            string cat = textCateg.Text;
            string desc = textDesc.Text;
            Despesa desp = new Despesa();
            Usuario us = UsuarioBll.GetByEmail(email);
            desp.Valor = val;
            desp.Categoria = cat;
            desp.Descricao = desc;
            DespesaBll.Add(desp);
            this.Close();
        }
    }
}

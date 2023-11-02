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
    public partial class Form_cadastra_receita : Form
    {
        private string? email;
        public Form_cadastra_receita(string? email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void labelCadastre_Receita(object sender, EventArgs e)
        {

        }

        private void labelTitulo(object sender, EventArgs e)
        {

        }

        private void labelData(object sender, EventArgs e)
        {

        }

        private void textBoxData(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textValor.Text);
            string cat = textCateg.Text;
            string desc = textDesc.Text;
            Receitum rec = new Receitum();
            Usuario us = UsuarioBll.GetByEmail(email);
            rec.IdReceita = us.IdReceita!.Value + 1;
            rec.Valor = val;
            rec.Categoria = cat;
            rec.Descricao = desc;
            ReceitaBll.Add(rec);
            this.Close();
        }
    }
}

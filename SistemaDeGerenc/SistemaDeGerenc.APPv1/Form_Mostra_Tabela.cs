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
    public partial class Form_Mostra_Tabela : Form
    {
        private string? email;
        private Form_cadastra_despesa? desp;
        private Form_cadastra_receita? rec;
        public Form_Mostra_Tabela( string? email, Form_cadastra_despesa desp)
        {
            InitializeComponent();
            this.email = email;
            this.desp = desp;
            comboBox1.Items.Add("Categoria");
        }
        public Form_Mostra_Tabela(string? email, Form_cadastra_receita rec)
        {
            InitializeComponent();
            this.email = email;
            this.rec = rec;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Despesa_Label(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (desp != null)
            {
                if(comboBox1.Text == "Categoria")
                {
                    List<Despesa> list = DespesaBll.GetByCategoria().ToList();
                    dataGridView1.DataSource = list;
                }
            }
            else
            {
                if (comboBox1.Text == "Categoria")
                {
                    List<Receitum> list = ReceitaBll.GetByCategoria().ToList();
                    dataGridView1.DataSource = list;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

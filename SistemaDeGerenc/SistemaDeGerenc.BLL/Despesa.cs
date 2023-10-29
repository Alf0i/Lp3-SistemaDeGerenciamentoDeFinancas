using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeGerenc.BLL
{
    public class Despesa:IDespesa
    {
        private int id_Despesa;
        private float data;
        private float valor;
        private string? categoria;
        private string? descricao;

        public Despesa(int id_Despesa, float data, float valor, string? categoria, string? descricao)
        {
            this.id_Despesa = id_Despesa;
            this.data = data;
            this.valor = valor;
            this.categoria = categoria;
            this.descricao = descricao;
        }

        public int Id_Despesa { get => id_Despesa; set => id_Despesa = value; }
        public float Data { get => data; set => data = value; }
        public float Valor { get => valor; set => valor = value; }
        public string? Categoria { get => categoria; set => categoria = value; }
        public string? Descricao { get => descricao; set => descricao = value; }
    }
}

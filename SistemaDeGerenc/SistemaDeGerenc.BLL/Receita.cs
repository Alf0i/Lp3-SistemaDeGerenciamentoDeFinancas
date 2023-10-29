using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    public class Receita:IReceita
    {
        private int id_Receita;
        private float data;
        private float valor;
        private string? categoria;
        private string? descricao;

        public Receita(int id_Receita, float data, float valor, string? categoria, string? descricao)
        {
            this.id_Receita = id_Receita;
            this.data = data;
            this.valor = valor;
            this.categoria = categoria;
            this.descricao = descricao;
        }

        public int Id_Receita { get => id_Receita; set => id_Receita = value; }
        public float Data { get => data; set => data = value; }
        public float Valor { get => valor; set => valor = value; }
        public string? Categoria { get => categoria; set => categoria = value; }
        public string? Descricao { get => descricao; set => descricao = value; }


    }
}

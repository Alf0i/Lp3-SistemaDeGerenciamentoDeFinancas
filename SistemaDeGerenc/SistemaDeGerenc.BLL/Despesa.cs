using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal class Despesa
    {
        public int id_Despesa;
        public float data;
        public float valor;
        public string? categoria;
        public string? descricao;

        public Despesa(int id_Despesa, float data, float valor, string? categoria, string? descricao)
        {
            this.id_Despesa = id_Despesa;
            this.data = data;
            this.valor = valor;
            this.categoria = categoria;
            this.descricao = descricao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal class Receita:IReceita
    {
        public int id_Receita;
        public float data;
        public float valor;
        public string? categoria;
        public string? descricao;

        public Receita(int id_Receita, float data, float valor, string? categoria, string? descricao)
        {
            this.id_Receita = id_Receita;
            this.data = data;
            this.valor = valor;
            this.categoria = categoria;
            this.descricao = descricao;
        }

        public void CalcularReceita()
        {
            throw new NotImplementedException();
        }
    }
}

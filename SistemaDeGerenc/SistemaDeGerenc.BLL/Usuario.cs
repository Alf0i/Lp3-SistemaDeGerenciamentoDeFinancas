using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal class Usuario:IUsuario
    {
        public int id_Usuario;
        public string? nome;
        public string? email;
        public string? senha;
        public double saldo;

        public List<Despesa> _desp;
        public List<Receita> _rec;

        public Usuario(int id_Usuario, string nome, string email, string senha, double saldo)
        {
            this.id_Usuario = id_Usuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.saldo = saldo;
            _desp = new List<Despesa>();
            _rec = new List<Receita>();
            
        }

        public string? Login { get => email; set => email = value; }
        public string? Nome { get => nome; set => nome = value; }
        public string? Senha { get => senha; set => senha = value; }

        public void CadastrarUsuario()
        {
            throw new NotImplementedException();
        }

        public void RemoverUsuario()
        {
            throw new NotImplementedException();
        }

        public void TrocarSenha()
        {
            throw new NotImplementedException();
        }

        public void CalcularSaldo()
        {
            float SomaDespesa = 0;
            float SomaReceita = 0;
            foreach (var despesa in _desp)
            {
                SomaDespesa += despesa.Valor;
            }
            foreach (var receita in _rec)
            {
                SomaReceita += receita.Valor;
            }

            saldo = SomaReceita - SomaDespesa;
        }

        public bool CadastrarDespesa(Despesa desp)
        {
            if (desp == null) return true;
            _desp!.Add(desp);
            return false;
        }

        public bool CadastrarReceita(Receita rec)
        {
            if (rec == null) return true;
            _rec!.Add(rec);
            return false;
        }
    }
}

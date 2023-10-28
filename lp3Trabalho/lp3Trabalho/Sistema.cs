using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp3Trabalho
{
    internal class Sistema
    {

        public List<Usuario>? _us;
        public List<Despesa>? _desp;
        public List<Receita>? _rec;

        public Sistema(List<Usuario>? us, List<Despesa>? desp, List<Receita>? rec)
        {
            _us = us;
            _desp = desp;
            _rec = rec;
        }

        public bool Autenticar(Usuario us)
        {
            if(us == null)return false;
            else if(_us!.Contains(us))return true;
            else return false;
        }

        public bool CadastrarDespesa(Despesa desp)
        {
            if (desp == null)return true;
            _desp!.Add(desp);
            return false;
        }

        public bool CadastrarReceita(Receita rec)
        {
            if (rec == null)return true;
            _rec!.Add(rec);
            return false;
        }

        public Saldo CalcularSaldo(Saldo saldo)
        {
            return saldo;
        }

        public List<Despesa>? FiltrarDesp(Despesa descricao)
        {
            if (_desp!.Contains(descricao))
            {
                return _desp;
            }
            else return null;
        }
    }
}

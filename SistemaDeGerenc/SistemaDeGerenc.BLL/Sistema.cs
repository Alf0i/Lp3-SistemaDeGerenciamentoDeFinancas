using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal class Sistema
    {
        public List<Usuario> _us;
        public IUsuario usuario;

        public Sistema(List<Usuario> us, Usuario usu)
        {
            this.usuario = (IUsuario)usu;
            this._us = us;
            
        }


        public bool Autenticar(Usuario us)
        {
            if (us == null) return false;
            else if (_us.Contains(us)) return true;
            else return false;
        }

        

        

        /*public bool FiltrarDesp(Despesa descricao)
        {
            if (_desp!.Contains(descricao))
            {
                return _desp;
            }
            else return null;
        }*/
    }
}

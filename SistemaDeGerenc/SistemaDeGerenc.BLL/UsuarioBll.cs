using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeGerenc.DAL.DBContext;
using SistemaDeGerenc.MODEL;


namespace SistemaDeGerenc.BLL
{
    public static class UsuarioBll
    {
       

        public static void CadastrarUsuario(Usuario us)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                dbContext.Add(us);
                dbContext.SaveChanges();
            }
        }

        public static bool AutenticarUsuario(string email, string senha)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                var usuario = dbContext.Usuarios.Single(p => p.Email == email);
                var usuario2 = dbContext.Usuarios.Single(p => p.Senha == senha);
                if(email != null && senha != null && usuario == usuario2)  return true; 
                return false;
            }
        }
        public static Usuario GetById(int id)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                var usuario = dbContext.Usuarios.Single(p => p.IdUsuario == id);
                return usuario;
            }
        }
        public static void TrocarSenha(string? senha)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {

            }
        }


        

        /*public void CalcularSaldo()
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
        }*/
    }
}

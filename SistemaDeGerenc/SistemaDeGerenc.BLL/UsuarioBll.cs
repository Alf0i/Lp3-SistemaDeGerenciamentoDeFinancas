using SistemaDeGerenc.MODEL;
using SistemaDeGerenc.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    public static class UsuarioBll
    {


        public static void CadastrarUsuario(Usuario us)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(us);
                dbContext.SaveChanges();
            }
        }

        public static bool AutenticarUsuario(string email, string senha)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Email == email);
                var usuario2 = dbContext.Usuarios.Single(p => p.Senha == senha);
                if (email != null && senha != null && usuario == usuario2) return true;
                return false;
            }
        }
        public static Usuario GetById(int id)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.IdUsuario == id);
                return usuario;
            }
        }
        public static Usuario GetByName(string? nome)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Nome == nome);
                return usuario;
            }
        }


        public static double? CalcularSaldo(string? nome)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                Usuario us = GetByName(nome);
                double? despesa = DespesaBll.CalcularDespesa();
                double? receita = ReceitaBll.CalcularReceita();
                us.Saldo += receita - despesa;
                return us.Saldo;
            }


           
        }

        
    }
}

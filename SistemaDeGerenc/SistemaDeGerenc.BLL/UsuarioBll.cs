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
                var usuario1 = dbContext.Usuarios.Single(p => p.Email == email);
                var usuario2 = dbContext.Usuarios.Single(p => p.Senha == senha);
                if (usuario1 == null || usuario2 == null) return false;
                else if(usuario1 == usuario2) return true;
                else return false;
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
        public static Usuario GetByEmail(string? email)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Email == email);
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


        public static double? CalcularSaldo(string? email)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                Usuario us = GetByEmail(email);
                var despesas = dbContext.Despesas.Sum(p => us.IdDespesa!.Value);
                var receitas = dbContext.Receita.Sum(p => us.IdReceita!.Value);
                us.Saldo = receitas - despesas;
                return us.Saldo;
            }


           
        }

        public static List<Usuario> FiltrarDespesas(string nome)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                Usuario us = GetByName(nome);
                var despesas = dbContext.Usuarios.OrderBy(p=> us.IdDespesaNavigation!.Categoria).ToList();
                return despesas;
            }
        }
        public static List<Usuario> FiltrarReceitas(string? nome)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                Usuario us = GetByName(nome);
                var receitas = dbContext.Usuarios.OrderBy(p => us.IdReceitaNavigation!.Categoria).ToList();
                return receitas;
            }
        }
    }
}

using SistemaDeGerenc.DAL.DBContext;
using SistemaDeGerenc.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeGerenc.BLL
{
    public static class DespesaBll
    {
        public static void Add(Despesa desp)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                dbContext.Add(desp);
                dbContext.SaveChanges();
            }
        }

        public static Despesa GetByCategoria(string? cat)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                var despesa = dbContext.Despesas.Single(p => p.Categoria == cat);
                return despesa;
            }
        }

    }
}

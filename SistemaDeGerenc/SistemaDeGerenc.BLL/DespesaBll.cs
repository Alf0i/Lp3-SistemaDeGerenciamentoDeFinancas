using SistemaDeGerenc.MODEL;
using SistemaDeGerenc.DAL.DBContext;
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
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(desp);
                dbContext.SaveChanges();
            }
        }

        public static Despesa GetByCategoria(string? cat)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                var despesa = dbContext.Despesas.Single(p => p.Categoria == cat);
                return despesa;
            }
        }

        
    }
}

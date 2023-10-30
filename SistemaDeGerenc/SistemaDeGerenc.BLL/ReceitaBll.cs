using SistemaDeGerenc.MODEL;
using SistemaDeGerenc.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    public static class ReceitaBll
    {
        public static void Add(Receitum rec)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(rec);
                dbContext.SaveChanges();
            }
        }

        public static Receitum GetByCategoria(string? cat)
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                var receita = dbContext.Receita.Single(p => p.Categoria == cat);
                return receita;
            }
        }

    }
}
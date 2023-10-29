
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeGerenc.DAL.DBContext;
using SistemaDeGerenc.MODEL;

namespace SistemaDeGerenc.BLL
{
    public static class ReceitaBll
    {
        public static void Add(Receitum rec)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                dbContext.Add(rec);
                dbContext.SaveChanges();
            }
        }

        public static Receitum GetByCategoria(string? cat)
        {
            using (var dbContext = new CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext)
            {
                var receita = dbContext.Receita.Single(p => p.Categoria == cat);
                return receita;
            }
        }

    }
}

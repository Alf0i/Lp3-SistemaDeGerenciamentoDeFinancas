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

        public static List<Receitum> GetByCategoria()
        {
            using (var dbContext = new CUsersMarceDocumentsGithubLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDatabaseDatabaseMdfContext())
            {
                //var despesa = dbContext.Despesas.;
                return (List<Receitum>)(from Receitum in dbContext.Receita orderby Receitum.Categoria select Receitum!);
            }
        }


    }
}
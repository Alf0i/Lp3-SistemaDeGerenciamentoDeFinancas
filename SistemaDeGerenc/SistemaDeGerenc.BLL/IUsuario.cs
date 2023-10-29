using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal interface IUsuario
    {

        string? Login { get; set; }
        string? Nome { get; set; }
        string? Senha { get; set; }

        void CadastrarUsuario();
        void RemoverUsuario();
        void TrocarSenha();
    }
}

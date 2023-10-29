using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGerenc.BLL
{
    internal class Usuario:IUsuario
    {
        public int id_Usuario;
        public string? nome;
        public string? email;
        public string? senha;

        public Usuario(int id_Usuario, string nome, string email, string senha)
        {
            this.id_Usuario = id_Usuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public string? Login { get => nome; set => nome = value; }
        public string? Nome { get => email; set => email = value; }
        public string? Senha { get => senha; set => senha = value; }

        public void CadastrarUsuario()
        {
            throw new NotImplementedException();
        }

        public void RemoverUsuario()
        {
            throw new NotImplementedException();
        }

        public void TrocarSenha()
        {
            throw new NotImplementedException();
        }
    }
}

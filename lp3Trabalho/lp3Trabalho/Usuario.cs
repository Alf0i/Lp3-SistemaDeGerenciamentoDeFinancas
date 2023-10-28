using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp3Trabalho
{
    internal class Usuario
    {

        public int id_Usuario;
        public string? nome;
        public string? email;
        public string? senha;

        public Usuario(int id_Usuario, string? nome, string? email, string? senha)
        {
            this.id_Usuario = id_Usuario;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_7
{
    internal class CadastroUsuario
    {
        // Criando Usuario que Podem Acessar
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Yago", Senha = "1234"},
            new Usuario(){Nome = "Leo", Senha = "1234"},
            new Usuario(){Nome = "Ana", Senha = "1234"},
            new Usuario(){Nome = "Isis", Senha = "1234"}
        };


        // Verificar o usuario que esta logado
        private static Usuario userLogado = null;


        // Definir o Usuario que Esta Logado (Ativa o Arry que Esta Acima)
        public static Usuario UsuarioLogado 
        {
            get { return userLogado; }
            set {  userLogado = value; }
        }


        // Controle de Login
        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios) 
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}

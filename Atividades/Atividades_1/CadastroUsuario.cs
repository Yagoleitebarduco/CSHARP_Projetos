using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_1
{
    internal class CadastroUsuario
    {
        // Criando Usuarios que Podem Acessar
        private static Login[] usuario =
        {
            new Login() {Nome = "Yago", Senha = "1234"},
            new Login() {Nome = "Leo", Senha = "1234"},
            new Login() {Nome = "Ana", Senha = "1234"},
            new Login() {Nome = "Isis", Senha = "1234"},
            new Login() {Nome = "Cassio", Senha = "1234"},
            new Login() {Nome = "Emily", Senha = "1234"}
        };

        // Verifica se o Usuario eta logado
        public static Login userLogin = null;


        // Ativa o Array 
        public static Login clienteLogado
        {
            get { return userLogin; }
            set { userLogin = value; }
        }

        // Controle de Login
        public static bool Clientes(string nome, string senha)
        {
            foreach (Login usuario in usuario) 
            { 
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    clienteLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}

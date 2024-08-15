using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.br.com.atividade.CONEXAO
{
    internal class Conexao
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["projetosoftware"].ConnectionString;
            return new MySqlConnection(conexao);
        }

        internal MySqlConnection getConnection() 
        {
            throw new NotImplementedException();
        }
    }
}

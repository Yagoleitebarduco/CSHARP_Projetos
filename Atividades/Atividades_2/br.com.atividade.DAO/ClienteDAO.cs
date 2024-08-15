using MySql.Data.MySqlClient;
using Atividade_2.br.com.atividade.CONEXAO;
using Atividade_2.br.com.atividade.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data;
using Mysqlx;

namespace Atividade_2.br.com.atividade.DAO
{
    internal class ClienteDAO
    {
        #region Conexao
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                // 1° Passo - Definir Comando SQL
                string sql = @"INSERT INTO tb_clientes (nome_projeto, cliente, data_inicio, data_termino, status, 
                               equipe_responsavel, descricao_projeto, tecnologia_utiliazda)
                               VAlUES(@nome_projeto, @cliente, @data_inicio, @data_termino, @status, @equipe_responsavel, 
                               @descricao_projeto, @tecnologia_utiliazda)";

                // 2° Passo - Organizar o Camando SQL
                MySqlCommand exedata = new MySqlCommand(sql, conexao);

                exedata.Parameters.AddWithValue("@nome_projeto", obj.nome_projeto);
                exedata.Parameters.AddWithValue("@cliente", obj.cliente);
                exedata.Parameters.AddWithValue("@data_inicio", obj.data_inicio);
                exedata.Parameters.AddWithValue("@data_termino", obj.data_termino);
                exedata.Parameters.AddWithValue("@status", obj.status);
                exedata.Parameters.AddWithValue("@equipe_responsavel", obj.equipe_responsavel);
                exedata.Parameters.AddWithValue("@descricao_projeto", obj.descricao_projeto);
                exedata.Parameters.AddWithValue("@tecnologia_utiliazda", obj.tecnologia_usada);

                // 3° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                exedata.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso", "Sucesso !!!");

                // 4° Passo - Fechar a Conexão
                conexao.Close();

            }
            catch (Exception erro) 
            {
                MessageBox.Show("ERROR - Aconteceu" + erro);
            }
        }
        #endregion

        #region Listar
        public DataTable ListarCliente()
        {
            try
            {
                // 1° Passo - Instanciar o DataTable
                DataTable tabelaClientes = new DataTable();

                // 2° Passo - Definir o Camando SQL
                string sql = @"SELECT * FROM tb_clientes";

                // 3° Passo - Organizar o Comando SQL
                MySqlCommand exedata = new MySqlCommand(sql, conexao);

                // 4° Passo - Abrir Conexao e Executar o Comando SQL
                conexao.Open();
                exedata.ExecuteNonQuery();

                // 5° Passo - Preenchemos os Dados do DataTable
                MySqlDataAdapter dg = new MySqlDataAdapter(exedata);
                dg.Fill(tabelaClientes);

                // 6° Passo - Fechar Conexao
                conexao.Close();

                // 7° Passo - Retornar um Valor 
                return tabelaClientes;
            }
            catch (Exception erro) 
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
                return null;
            }
        }

       
        
        #endregion

        #region Alterar
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                // 1° Passo - Definir Comando SQL
                string sql = @"UPDATE tb_clientes SET nome_projeto=@nome_projeto, cliente=@cliente, data_inicio=@data_inicio,
                             data_termino=@data_termino, status=@status, equipe_responsavel=@equipe_responsavel, 
                             descricao_projeto=@descricao_projeto, tecnologia_utiliazda=@tecnologia_utiliazda";

                // 2° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@tecnologia_usada", obj.nome_projeto);
                executarcmd.Parameters.AddWithValue("@cliente", obj.cliente);
                executarcmd.Parameters.AddWithValue("@data_inicio", obj.data_inicio);
                executarcmd.Parameters.AddWithValue("@data_termino", obj.data_termino);
                executarcmd.Parameters.AddWithValue("@status", obj.status);
                executarcmd.Parameters.AddWithValue("@equipe_responsavel", obj.equipe_responsavel);
                executarcmd.Parameters.AddWithValue("@descricao_projeto", obj.descricao_projeto);
                executarcmd.Parameters.AddWithValue("@tecnologia_utiliazda", obj.tecnologia_usada);

                // 3° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso", "Sucesso !!!");


                // 4° Passo - Fechar a Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
            }
        }
        #endregion

        #region Excluir
        public void ExcluirClientes(Cliente obj)
        {
            try
            {
                // 1° Passo - Definir Comando SQL
                string sql = @"DELETE FROM tb_clientes WHERE nome_projeto=@nome_projeto";

                // 2° Passo - Organizar Comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome_projeto", obj.nome_projeto);

                // 3° Passo - Abrir Conexao e Executar o Comando SQL
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso", "SUCESSO !!!");

                // 4° Passo - Fechar a Conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR - Aconteceu" + erro);
            }
        }
        #endregion
    }
}

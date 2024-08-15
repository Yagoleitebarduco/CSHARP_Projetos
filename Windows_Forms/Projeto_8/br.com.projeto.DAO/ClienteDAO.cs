using MySql.Data.MySqlClient;
using Projeto_8.br.com.projeto.CONEXAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.DAO
{
    internal class ClienteDAO
    {
        #region Conexao 
        private MySqlConnection conexao;
        public ClienteDAO()
        {
            conexao  = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void CadastrarCliente(Clientes obj)
        {
            try
            {
                // 1° Passo - Definir Comando SQL
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email, telefone, celular, 
                             cep, endereco, numero, complemento, bairro, cidade, estado)
                             VALUES(@nome, @rg, @cpf, @email, @telefone, @celular, 
                             @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";


                // 2° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.Rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.Email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.Celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.Cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.Numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.Estado);


                // 3° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso", "Sucesso !!!");

                // 4° Passo - Fechar a Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
            }
        }
        #endregion

        #region Listar
        public DataTable ListarClientes()
        {
            try
            {
                // 1° Passo - Instanciar o DataTable
                DataTable tabelaClientes = new DataTable();


                // 2° Passo - Definir Comando SQL
                string sql = @"SELECT * FROM tb_clientes";


                // 3° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);


                // 4° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();
                /// MessageBox.Show("Cliente Cadastrado com Sucesso", "Sucesso !!!");


                // 5°  Passo - Preenchemos os Dados do DataTable
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaClientes);
                

                // 6° Passo - Fechar a Conexão
                conexao.Close();
                return tabelaClientes;

                // 7° Passo - Retorna um Valor (return tabelaCliente)
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
                return null;
            }
        }
        #endregion

        #region Alterar 
        public void AlterarCliente(Clientes obj)
        {
            try
            {
                // 1° Passo - Definir Comando SQL
                string sql = @"UPDATE tb_clientes SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, 
                    celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, 
                    bairro=@bairro, cidade=@cidade, estado=@estado
                    WHERE id=@id";


                // 2° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", obj.Nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.Rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.Email);

                executarcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.Celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.Cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.Endereco);

                executarcmd.Parameters.AddWithValue("@numero", obj.Numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.Estado);

                executarcmd.Parameters.AddWithValue("@id", obj.Codigo);


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
        public void ExcluirCliente(Clientes obj)
        {
            try
            {
                // 1° Passo - Definir Comando SQL
                string sql = @"DELETE FROM tb_clientes WHERE id = @id";


                // 2° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@id", obj.Codigo);

                // 3° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso", "Sucesso !!!");

                // 4° Passo - Fechar a Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
            }
        }
        #endregion

        #region  Buscar Cliente - Por Nome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                // 1° Passo - Instanciar o DataTable
                DataTable tabelaClientes = new DataTable();


                // 2° Passo - Definir Comando SQL
                string sql = @"SELECT * FROM tb_clientes WHERE nome = @nome";


                // 3° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", nome);


                // 4° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();
                /// MessageBox.Show("Cliente Cadastrado com Sucesso", "Sucesso !!!");


                // 5°  Passo - Preenchemos os Dados do DataTable
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaClientes);


                // 6° Passo - Fechar a Conexão
                conexao.Close();
                return tabelaClientes;

                // 7° Passo - Retorna um Valor (return tabelaCliente)

            }
            catch (Exception erro)
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
                return null;
            }
        }
        #endregion

        #region Buscar Cliente - Listando
        public DataTable BuscarClienteListando(string nome)
        {
            try
            {
                // 1° Passo - Instanciar o DataTable
                DataTable tabelaClientes = new DataTable();


                // 2° Passo - Definir Comando SQL
                string sql = @"SELECT * FROM tb_clientes WHERE nome LIKE @nome";


                // 3° Passo - Organizar o Comando Sql
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", nome);


                // 4° Passo - Abrir Conexão e Executar o Comando Sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();
                /// MessageBox.Show("Cliente Cadastrado com Sucesso", "Sucesso !!!");


                // 5°  Passo - Preenchemos os Dados do DataTable
                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaClientes);


                // 6° Passo - Fechar a Conexão
                conexao.Close();
                return tabelaClientes;

                // 7° Passo - Retorna um Valor (return tabelaCliente)

            }
            catch (Exception erro)
            {
                MessageBox.Show("EROR - Aconteceu" + erro);
                return null;
            }
        }
        #endregion

    }
}

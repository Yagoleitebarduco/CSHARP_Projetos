using Projeto_8.br.com.projeto.DAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class formularioClientes : Form
    {
        public formularioClientes()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void formularioClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao =new ClienteDAO();

            dataGridView_listagem.DataSource = dao.ListarClientes();
        }

        private void dataGridView_listagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1° Passo - Pegar os Dados
            txtbox_codigo.Text = dataGridView_listagem.CurrentRow.Cells[0].Value.ToString();
            txtbox_nome.Text = dataGridView_listagem.CurrentRow.Cells[1].Value.ToString();
            masktxt_rg.Text = dataGridView_listagem.CurrentRow.Cells[2].Value.ToString();
            masktxt_cpf.Text = dataGridView_listagem.CurrentRow.Cells[3].Value.ToString();
            // -----------------------------------------------------------------------------------
            txtbox_email.Text = dataGridView_listagem.CurrentRow.Cells[4].Value.ToString();
            masktxt_telefone.Text = dataGridView_listagem.CurrentRow.Cells[5].Value.ToString();
            masktxt_celular.Text = dataGridView_listagem.CurrentRow.Cells[6].Value.ToString();
            masktxt_cep.Text = dataGridView_listagem.CurrentRow.Cells[7].Value.ToString();
            // -----------------------------------------------------------------------------------
            txtbox_endereco.Text = dataGridView_listagem.CurrentRow.Cells[8].Value.ToString();
            txtbox_numero.Text = dataGridView_listagem.CurrentRow.Cells[9].Value.ToString();
            txtbox_complemento.Text = dataGridView_listagem.CurrentRow.Cells[10].Value.ToString();
            txtbox_bairro.Text = dataGridView_listagem.CurrentRow.Cells[11].Value.ToString();
            // -----------------------------------------------------------------------------------
            txtbox_cidade.Text = dataGridView_listagem.CurrentRow.Cells[12].Value.ToString();
            comboBox_estado.Text = dataGridView_listagem.CurrentRow.Cells[13].Value.ToString();


            // 2° Passo - Alterar Para a Guia de Dados Pessoais
            tabControl_Clientes.SelectedTab = tabPage_dadosPessoais;
        }

        private void button_novo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            // 1° Passo - Receber os Dados
            obj.Nome = txtbox_nome.Text;
            obj.Rg = masktxt_rg.Text.Replace(",", ".");
            obj.Cpf = masktxt_cpf.Text.Replace(",", ".");
            obj.Email = txtbox_email.Text;
            obj.Telefone = masktxt_telefone.Text;
            obj.Celular = masktxt_celular.Text;
            obj.Cep = masktxt_cep.Text;
            obj.Endereco = txtbox_endereco.Text;
            obj.Numero = int.Parse(txtbox_numero.Text);
            obj.Complemento = txtbox_complemento.Text;
            obj.Bairro = txtbox_bairro.Text;
            obj.Cidade = txtbox_cidade.Text;
            obj.Estado = comboBox_estado.Text;


            // 2° Passo - Criar um Objeto e Chamar o Metodo 
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            dataGridView_listagem.DataSource = dao.ListarClientes();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            // 1° Passo - Receber os Dados
            obj.Nome = txtbox_nome.Text;
            obj.Rg = masktxt_rg.Text.Replace(",", ".");
            obj.Cpf = masktxt_cpf.Text.Replace(",", ".");
            obj.Email = txtbox_email.Text;
            obj.Telefone = masktxt_telefone.Text;
            obj.Celular = masktxt_celular.Text;
            obj.Cep = masktxt_cep.Text;
            obj.Endereco = txtbox_endereco.Text;
            obj.Numero = int.Parse(txtbox_numero.Text);
            obj.Complemento = txtbox_complemento.Text;
            obj.Bairro = txtbox_bairro.Text;
            obj.Cidade = txtbox_cidade.Text;
            obj.Estado = comboBox_estado.Text;

            obj.Codigo = int.Parse(txtbox_codigo.Text);

            // 2° Passo - Criar um Objeto e Chamar o Metodo 
            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);

            // 3° Passo - Recarregar o DataGrid
            dataGridView_listagem.DataSource = dao.ListarClientes();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            // 1° Passo - Receber os Dados
            obj.Codigo = int.Parse(txtbox_codigo.Text);


            // 2° Passo - Criar um Objeto e Chamar o Metodo 
            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(obj);


            // 3° Passo - Recarregar o DataGrid
            dataGridView_listagem.DataSource = dao.ListarClientes();


            // 4° Passo - Retorna dados Pessoais
            tabControl_Clientes.SelectedTab = tabPage_consulta;
        }

        private void txtbox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_pesquisaConsulta_Click(object sender, EventArgs e)
        {
            string nome = txtbox_nomeConsula.Text;

            ClienteDAO dao = new ClienteDAO();

            dataGridView_listagem.DataSource = dao.BuscarClientePorNome(nome);

            if (dataGridView_listagem.Rows.Count == 0)
            {
                dataGridView_listagem.DataSource = dao.ListarClientes();
            }
        }

        private void txtbox_nomeConsula_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtbox_nomeConsula.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            dataGridView_listagem.DataSource = dao.BuscarClienteListando(nome);
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = masktxt_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtbox_endereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbox_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtbox_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtbox_complemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                comboBox_estado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereco Não Encontado, Por Favor Tente Novamente");
            }
        }
    }
}

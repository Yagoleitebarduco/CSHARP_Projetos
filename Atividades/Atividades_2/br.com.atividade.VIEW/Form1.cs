using Atividade_2.br.com.atividade.DAO;
using Atividade_2.br.com.atividade.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox_status.Items.Add("Em Andamento");
            comboBox_status.Items.Add("Concluido");
            comboBox_status.Items.Add("Atrasado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            dataGridView_listagem.DataSource = dao.ListarCliente();
        }

        private void dataGridView_listagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_nomeProjeto.Text = dataGridView_listagem.CurrentRow.Cells[0].Value.ToString();
            textBox_cliente.Text = dataGridView_listagem.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker_dataInicio.Text = dataGridView_listagem.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_dateTermino.Text = dataGridView_listagem.CurrentRow.Cells[3].Value.ToString();
            comboBox_status.Text = dataGridView_listagem.CurrentRow.Cells[4].Value.ToString();
            textBox_equipeResponsavel.Text = dataGridView_listagem.CurrentRow.Cells[5].Value.ToString();
            textBox_descProjeto.Text = dataGridView_listagem.CurrentRow.Cells[6].Value.ToString();
            textBox_tecUtilizada.Text = dataGridView_listagem.CurrentRow.Cells[7].Value.ToString();

            tabControl_Clientes.SelectedTab = tabPage_dadosPessoais;
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome_projeto = textBox_nomeProjeto.Text;
            obj.cliente = textBox_cliente.Text;
            obj.data_inicio = dateTimePicker_dataInicio.Text;
            obj.data_termino = dateTimePicker_dateTermino.Text;
            obj.status = comboBox_status.Text;
            obj.equipe_responsavel = textBox_equipeResponsavel.Text;
            obj.descricao_projeto = textBox_descProjeto.Text;
            obj.tecnologia_usada = textBox_tecUtilizada.Text;


            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            dataGridView_listagem.DataSource = dao.ListarCliente();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome_projeto = textBox_nomeProjeto.Text;
            obj.cliente = textBox_cliente.Text;
            obj.data_inicio = dateTimePicker_dataInicio.Text;
            obj.data_termino = dateTimePicker_dateTermino.Text;
            obj.status = comboBox_status.Text;
            obj.equipe_responsavel = textBox_equipeResponsavel.Text;
            obj.descricao_projeto = textBox_descProjeto.Text;
            obj.tecnologia_usada = textBox_tecUtilizada.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);

            dataGridView_listagem.DataSource = dao.ListarCliente();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome_projeto = textBox_nomeProjeto.Text;


            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirClientes(obj);


            dataGridView_listagem.DataSource = dao.ListarCliente();


            tabControl_Clientes.SelectedTab = tabPage_consulta;
        }

        private void dataGridView_listagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

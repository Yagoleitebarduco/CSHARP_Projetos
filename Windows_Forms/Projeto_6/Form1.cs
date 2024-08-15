using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeo_6
{
    public partial class Form1 : Form
    {
        List <Pessoa> pessoas;


        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa> ();

            comboBox_estadoCivil.Items.Add("Cassado");
            comboBox_estadoCivil.Items.Add("Solteiro");
            comboBox_estadoCivil.Items.Add("Viuvo");
            comboBox_estadoCivil.Items.Add("Divorciado");

            comboBox_estadoCivil.SelectedIndex = 0;


            // Data Grid View

            dataGridView_lista.Columns.Add("Nome", "Nome");
            dataGridView_lista.Columns.Add("DataNascimento", "Data Nascimento");
            dataGridView_lista.Columns.Add("EstadoCivil", "Estado Civil");
            dataGridView_lista.Columns.Add("Telefone", "Telefone");
            dataGridView_lista.Columns.Add("CasaPropria", "Casa Propria");
            dataGridView_lista.Columns.Add("Veiculo", "Veiculo");
            dataGridView_lista.Columns.Add("Sexo", "Sexo");
        }

        private void button_cadastrarAlterar_Click(object sender, EventArgs e)
        {
            int valorNegativo = -1; // Verifica se o Usuario ja Esta Cadastrado

            // Verifica se os Nome sao iguais (Nome é parametro)
            foreach (Pessoa cadastro in pessoas)
            {
                if (cadastro.Nome == textBox_nome.Text)
                {
                    valorNegativo = pessoas.IndexOf(cadastro);
                }
            }

            // Verifica se os Campos Foram Prenchidos
            if (textBox_nome.Text == "")
            {
                MessageBox.Show("Prencha o Campo do Nome!", "Alerta !!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox_nome.Focus();
                return;
            }

            if (maskedTextBox_telefone.Text == "(  )        - ")
            {
                MessageBox.Show("Prencha o Campo de Telefone", "Alerta !!!", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                maskedTextBox_telefone.Focus();
                return;
            }

            char sexo;
            if (radioButton_masculino.Checked) 
            {
                sexo = 'M';
            } else if (radioButton_feminino.Checked) {
                sexo = 'F';
            } else {
                sexo = 'O';
            }

            // Atribuir Valores
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = textBox_nome.Text;
            pessoa.DataNascimento = dateTimePicker_dataNascimento.Text;
            pessoa.EstadoCivil = comboBox_estadoCivil.SelectedItem.ToString();
            pessoa.Telefone = maskedTextBox_telefone.Text;
            pessoa.CasaPropria = checkBox_possuiCasa.Checked;
            pessoa.Veiculo = checkBox_possuiVeiculo.Checked;
            pessoa.Sexo = sexo;

            // Verifica se ja esta cadastrado
            if (valorNegativo < 0) 
            {
                pessoas.Add(pessoa);
            } else {
                pessoas[valorNegativo] = pessoa;
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);

            Listar();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = string.Empty;
            dateTimePicker_dataNascimento.Value = DateTime.Now;
            comboBox_estadoCivil.SelectedIndex = 0;
            maskedTextBox_telefone.Text = string.Empty;

            checkBox_possuiCasa.Checked = false;
            checkBox_possuiVeiculo.Checked = false;
            radioButton_masculino.Checked = false;
            radioButton_feminino.Checked = false;
            radioButton_outros.Checked = false;

            textBox_nome.Focus();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int indices = dataGridView_lista.CurrentCell.RowIndex;

            pessoas.RemoveAt(indices);

            Listar();
        }


        private void comboBox_estadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            // listBox.Items.Clear();
            dataGridView_lista.Rows.Clear();


            foreach (Pessoa p in pessoas)
            {
                // listBox.Items.Add(p.Nome);
                // listBox.Items.Add(p.Telefone);

                // listBox.Items.Add(p.ToString());

                dataGridView_lista.Rows.Add(
                    p.Nome,
                    p.DataNascimento,
                    p.EstadoCivil,
                    p.Telefone,
                    p.CasaPropria ? "SIM" : "NÃO",
                    p.Veiculo ? "SIM" : "NÃO",
                    p.Sexo
                    );
            }
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = listBox.SelectedIndex;
            Pessoa pessoa = pessoas[indice];

            textBox_nome.Text = pessoa.Nome;
            dateTimePicker_dataNascimento.Text = pessoa.DataNascimento;
            comboBox_estadoCivil.SelectedItem = pessoa.EstadoCivil;
            maskedTextBox_telefone.Text = pessoa.Telefone;

            checkBox_possuiCasa.Checked = pessoa.CasaPropria;
            checkBox_possuiVeiculo.Checked = pessoa.Veiculo;
            
            switch (pessoa.Sexo)
            {
                case 'M':
                    radioButton_masculino.Checked = true;
                    break;
                case 'F':
                    radioButton_feminino.Checked = true;
                    break;
                default:
                    radioButton_outros.Checked = true;
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            Pessoa pessoa = pessoas[indice];

            textBox_nome.Text = pessoa.Nome;
            dateTimePicker_dataNascimento.Text = pessoa.DataNascimento;
            comboBox_estadoCivil.SelectedItem = pessoa.EstadoCivil;
            maskedTextBox_telefone.Text = pessoa.Telefone;

            checkBox_possuiCasa.Checked = pessoa.CasaPropria;
            checkBox_possuiVeiculo.Checked = pessoa.Veiculo;

            switch (pessoa.Sexo)
            {
                case 'M':
                    radioButton_masculino.Checked = true;
                    break;
                case 'F':
                    radioButton_feminino.Checked = true;
                    break;
                default:
                    radioButton_outros.Checked = true;
                    break;
            }
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

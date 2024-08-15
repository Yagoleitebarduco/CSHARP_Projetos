using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades_1
{
    public partial class Form1 : Form
    {

        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboBox_planoDeSaude.Items.Add("Basico");
            comboBox_planoDeSaude.Items.Add("Intermediario");
            comboBox_planoDeSaude.Items.Add("Premiuns");

            comboBox_planoDeSaude.SelectedIndex = 0;

            // dataGridView

            dataGridView_listagem.Columns.Add("Nome", "Nome");
            dataGridView_listagem.Columns.Add("DataNascimento", "Data Nascimento");
            dataGridView_listagem.Columns.Add("Endereco", "Endereco");
            dataGridView_listagem.Columns.Add("Telefone", "Telefone");
            dataGridView_listagem.Columns.Add("NumeroCartaoSus", "Numero Cartao do Sus");
            dataGridView_listagem.Columns.Add("HistoricoMedico", "Historico Medico");
            dataGridView_listagem.Columns.Add("DataUltimaConsulta", "Data da Ultima Consulta");
            dataGridView_listagem.Columns.Add("PlanoMedico", "Plano Medico");
            dataGridView_listagem.Columns.Add("Sexo", "Sexo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuarioLogin usuario = new UsuarioLogin();

            while (CadastroUsuario.clienteLogado == null)
            {
                Visible = false;
                usuario.ShowDialog();

                if (UsuarioLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }
            Visible = true;
        }

        private void Listar()
        {
            dataGridView_listagem.Rows.Clear();

            foreach (Pessoa p in pessoas)
            {
                dataGridView_listagem.Rows.Add(
                    p.Nome,
                    p.DataNascimento,
                    p.Endereco,
                    p.Telefone,
                    p.NumeroCartaoSus,
                    p.HistoricoMedico,
                    p.DataUltimaConsulta,
                    p.PlanoMedico,
                    p.Sexo
                    );
            }
        }

        private void button_enviar_Click(object sender, EventArgs e)
        {
            int valorNegativo = -1; // Verifica se o Usuario ja Esta Cadastrado

            // Verificar se o Campo Foi Prenchido
            foreach (Pessoa cadastro in pessoas)
            {
                if (cadastro.Nome == textBox_nome.Text)
                {
                    valorNegativo = pessoas.IndexOf(cadastro);
                }
            }

            if (textBox_nome.Text == "")
            {
                MessageBox.Show("Prencha O Campo do Nome" , "ALERTA !!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox_nome.Focus();
                return;
            }

            if (textBox_endereco.Text == "")
            {
                MessageBox.Show("Prencha O Campo do Endereco", "ALERTA !!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox_endereco.Focus(); 
                return;
            }

            if (maskedTextBox_telefone.Text == "(  )       - ")
            {
                MessageBox.Show("Prencha O Campo do Telefone", "ALERTA !!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                maskedTextBox_telefone .Focus();
                return;
            }

            if (textBox_numeroCartaoSUS.Text == "")
            {
                MessageBox.Show("Prencha O Numero do Cartao do SUS", "ALERTA !!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox_numeroCartaoSUS .Focus();
                return;
            }

            string sexo;
            if (radioButton_masculino.Checked)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Feminino";
            }


            // Atribuir Valores
            Pessoa usuario = new Pessoa();

            usuario.Nome = textBox_nome.Text;
            usuario.DataNascimento = dateTimePicker_dataNascimento.Text;
            usuario.Endereco = textBox_endereco.Text;
            usuario.Telefone = maskedTextBox_telefone.Text;
            usuario.NumeroCartaoSus = textBox_numeroCartaoSUS.Text;
            usuario.HistoricoMedico = textBox_historicoMedico.Text;
            usuario.DataUltimaConsulta = dateTimePicker_datUltimaConsulta.Text;
            usuario.PlanoMedico = comboBox_planoDeSaude.SelectedItem.ToString();
            usuario.Sexo = sexo;
            

            // Verificar se ja esta Cadastrado
            if (valorNegativo < 0)
            {
                pessoas.Add(usuario);
            } 
            else
            {
                pessoas[valorNegativo] = usuario;
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);

            Listar();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = string.Empty;
            dateTimePicker_dataNascimento.Value = DateTime.Now;
            textBox_endereco.Text = string.Empty;
            maskedTextBox_telefone.Text = string.Empty;
            textBox_numeroCartaoSUS.Text = string.Empty;
            textBox_historicoMedico.Text = string.Empty;
            dateTimePicker_datUltimaConsulta.Value = DateTime.Now;
            comboBox_planoDeSaude.SelectedIndex = 0;
            radioButton_masculino.Checked = false;
            radioButton_feminino.Checked = false;
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int indice = dataGridView_listagem.CurrentCell.RowIndex;

            pessoas.RemoveAt(indice);

            Listar();
        }


        private void dataGridView_listagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int indice = e.RowIndex;
            Pessoa pessoa = pessoas[indice];

            textBox_nome.Text = pessoa.Nome;
            dateTimePicker_dataNascimento.Text = pessoa.DataNascimento;
            textBox_endereco.Text = pessoa.Endereco;
            maskedTextBox_telefone.Text = pessoa.Telefone;
            textBox_numeroCartaoSUS.Text = pessoa.NumeroCartaoSus;
            textBox_historicoMedico.Text = pessoa.HistoricoMedico;
            dateTimePicker_datUltimaConsulta.Text = pessoa.DataUltimaConsulta;

            comboBox_planoDeSaude.SelectedItem = pessoa.PlanoMedico;

            pessoa.Sexo = pessoa.Sexo.ToUpper();

            switch (pessoa.Sexo)
            {
                case "MASCULINO":
                    radioButton_masculino.Checked = true;
                    break;
                default: 
                    radioButton_feminino.Checked = true;
                    break;
            } 
            
            button_alterar_Click(sender, e);
        }
        private void button_alterar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

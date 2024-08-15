using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 260);
            groupBox_valoresPacotes.Visible = false;   
        }


        private void button_limpar_Click(object sender, EventArgs e)
        {
            // AÇÃO DE LIMPAR

            // textBox_nome = "";


            textBox_nome.Clear();
            comboBox_destino.Text = "";
            radioButton_aviao.Checked = false;
            radioButton_onibus.Checked = false;
            dateTimePicker_data.Value = DateTime.Now;
        }


        private void button_confirmar_Click(object sender, EventArgs e)
        {
            // AÇÃO DE CONFIRMAR

            if (textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite Seu Nome: ", "Alerta");
                textBox_nome.Focus();
            }

            if (comboBox_destino.Text == "")
            {
                MessageBox.Show("Destino não Selecionado", "Alerta");
                comboBox_destino.Focus();
            }

            if (radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            {
                MessageBox.Show("Selecione o Meio de Transporte", "Alerta");
            }
        }


        private void button_caucular_Click(object sender, EventArgs e)
        {
            // AÇÃO CAUCULAR
            double gasto_destino, gasto_transporte, valor_total;


            // DESTINO
            switch (comboBox_destino.Text.ToUpper())
            {
                case "SP":
                    gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }


            // MEIO TRANSPORTE
            if (radioButton_aviao.Checked == true)
            {
                gasto_transporte = 100;
            }
            else 
            {
                gasto_transporte = 30;
            }


            // CAUCULAR VALOR TOTAL
            valor_total = gasto_transporte + gasto_destino;


            // REDIDIONAMENTO
            this.ClientSize = new System.Drawing.Size(640, 300);
            groupBox_valoresPacotes.Visible = true;


            // EXIBIR
            label1_resultGastoTransporte.Text = gasto_transporte.ToString("F2");
            label_resultGastoDestino.Text = gasto_destino.ToString("F2");
            labelresultValorTotal.Text = valor_total.ToString("F2");

            }
        }
    }


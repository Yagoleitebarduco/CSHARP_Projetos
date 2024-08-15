using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Projeto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(364, 243);
            label_nomeResult.Visible = false;
        }


        private void button_adicao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            double soma = valor1 + valor2;

            this.ClientSize = new System.Drawing.Size(364, 400);
            label_nomeResult.Visible = true;

            label_resultValor.Text = soma.ToString("F2", CultureInfo.InvariantCulture);
        }


        private void button_subtracao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            double subtracao = valor1 - valor2;

            this.ClientSize = new System.Drawing.Size(364, 400);
            label_nomeResult.Visible = true;

            label_resultValor.Text = subtracao.ToString("F2", CultureInfo.InvariantCulture);
        }


        private void button_divisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            double divisao = valor1 / valor2;

            this.ClientSize = new System.Drawing.Size(364, 400);
            label_nomeResult.Visible = true;

            label_resultValor.Text = divisao.ToString("F2", CultureInfo.InvariantCulture);
        }


        private void button_multiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            double multiplicacao = valor1 * valor2;

            this.ClientSize = new System.Drawing.Size(364, 400);
            label_nomeResult.Visible = true;

            label_resultValor.Text = multiplicacao.ToString("F2", CultureInfo.InvariantCulture);
        }


        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_valor1.Clear();
            textBox_valor2.Clear();

            label_resultValor.Text = "";

            this.ClientSize = new System.Drawing.Size(364, 243);
            label_nomeResult.Visible = false;
        }
    }
}

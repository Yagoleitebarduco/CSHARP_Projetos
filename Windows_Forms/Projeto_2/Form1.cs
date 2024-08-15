using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Form_Saudacao : Form
    {
        public Form_Saudacao()
        {
            InitializeComponent();
        }

        private void Form_Saudacao_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_exibir_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"Ola {textBox_nome.Text}");


            string nome = textBox_nome.Text;
            MessageBox.Show($"Ola {nome}", 
                "Titulo da Resposta", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
    }
}

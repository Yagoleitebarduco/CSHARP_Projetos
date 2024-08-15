using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_7
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void bnt_entrar_Click(object sender, EventArgs e)
        {
            string nome = txtb_usuario.Text;
            string senha = txtb_senha.Text;

            if (CadastroUsuario.Login(nome, senha))
            {
                Close();
            } 
            else
            {
                MessageBox.Show("Acesso Negado", "ALERTA !!!");
                txtb_usuario.Text = " ";
                txtb_senha.Text = " ";
                txtb_usuario.Focus();
                Close();
            }
        }

        private void bnt_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}

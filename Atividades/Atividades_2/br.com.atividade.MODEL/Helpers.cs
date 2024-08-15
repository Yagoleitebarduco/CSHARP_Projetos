using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2.br.com.atividade.MODEL
{
    internal class Helpers
    {
        public void LimparTela(Form1 tela)
        {
            foreach(Control ctrlPai in tela.Controls)
            {
                foreach(Control ctrl1 in ctrlPai.Controls)
                {
                    if (ctrl1 is TabPage)
                    {
                        foreach(Control ctrl2 in ctrl1.Controls)
                        {
                            if (ctrl2 is TextBox)
                            {
                                // Limpar TextBox
                                (ctrl2 as TextBox).Text = string.Empty;
                            }

                            if (ctrl2 is ComboBox) 
                            {
                                // Limpar ComboBox
                                (ctrl2 as ComboBox).Text = string.Empty;
                            }

                            if (ctrl2 is DateTimePicker)
                            {
                                // Limpar DateTimePicker
                                (ctrl2 as DateTimePicker).Text = string.Empty;  
                            }
                        }
                    }
                }
            }
        }
    }
}

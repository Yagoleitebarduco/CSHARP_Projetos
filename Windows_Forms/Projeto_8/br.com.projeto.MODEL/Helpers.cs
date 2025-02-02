﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.MODEL
{
    internal class Helpers
    {
        public void LimparTela(Form tela)
        {
            foreach(Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach(Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                // Limpar os Dados (TextBox)
                                (ctr2 as TextBox).Text = string.Empty;
                                
                            }

                            if (ctr2 is MaskedTextBox)
                            {
                                // Limpar os Dados (MaskedTextBox)
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }

                            if (ctr2 is ComboBox)
                            {
                                // Limpar os Dados (ComboBox)
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}

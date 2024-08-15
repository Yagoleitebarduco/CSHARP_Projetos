namespace Projeto_8.br.com.projeto.VIEW
{
    partial class formularioFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.tabControl_funcionario = new System.Windows.Forms.TabControl();
            this.tabPage_dadosPessoaisFuncionarios = new System.Windows.Forms.TabPage();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.txtbox_bairro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbox_cidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.masktxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.masktxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.masktxt_rg = new System.Windows.Forms.MaskedTextBox();
            this.masktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.masktxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbox_complemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbox_numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_endereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_consultaFuncionario = new System.Windows.Forms.TabPage();
            this.dataGridView_listagemFuncionario = new System.Windows.Forms.DataGridView();
            this.button_pesquisaConsulta = new System.Windows.Forms.Button();
            this.txtbox_nomeConsula = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_novo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox_nivel = new System.Windows.Forms.ComboBox();
            this.comboBox_cargo = new System.Windows.Forms.ComboBox();
            this.tabControl_funcionario.SuspendLayout();
            this.tabPage_dadosPessoaisFuncionarios.SuspendLayout();
            this.tabPage_consultaFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listagemFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_salvar.FlatAppearance.BorderSize = 0;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_salvar.Location = new System.Drawing.Point(802, 360);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(86, 37);
            this.button_salvar.TabIndex = 42;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = false;
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.Transparent;
            this.button_excluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_excluir.Location = new System.Drawing.Point(762, 170);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(86, 37);
            this.button_excluir.TabIndex = 44;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            // 
            // tabControl_funcionario
            // 
            this.tabControl_funcionario.Controls.Add(this.tabPage_dadosPessoaisFuncionarios);
            this.tabControl_funcionario.Controls.Add(this.tabPage_consultaFuncionario);
            this.tabControl_funcionario.Location = new System.Drawing.Point(12, 105);
            this.tabControl_funcionario.Name = "tabControl_funcionario";
            this.tabControl_funcionario.SelectedIndex = 0;
            this.tabControl_funcionario.Size = new System.Drawing.Size(744, 341);
            this.tabControl_funcionario.TabIndex = 40;
            // 
            // tabPage_dadosPessoaisFuncionarios
            // 
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.comboBox_cargo);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.comboBox_nivel);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label19);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label18);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.textBox_senha);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label17);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.comboBox_estado);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label15);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.button_pesquisar);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_bairro);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label14);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_cidade);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label13);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.masktxt_celular);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.masktxt_telefone);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.masktxt_rg);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.masktxt_cpf);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.masktxt_cep);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label12);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_complemento);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label11);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_numero);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label10);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_endereco);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label9);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_email);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_nome);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label8);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label7);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label6);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label5);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label4);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label3);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.txtbox_codigo);
            this.tabPage_dadosPessoaisFuncionarios.Controls.Add(this.label2);
            this.tabPage_dadosPessoaisFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabPage_dadosPessoaisFuncionarios.Name = "tabPage_dadosPessoaisFuncionarios";
            this.tabPage_dadosPessoaisFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dadosPessoaisFuncionarios.Size = new System.Drawing.Size(736, 315);
            this.tabPage_dadosPessoaisFuncionarios.TabIndex = 0;
            this.tabPage_dadosPessoaisFuncionarios.Text = "Dados Pessoai";
            this.tabPage_dadosPessoaisFuncionarios.UseVisualStyleBackColor = true;
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PE",
            "PI",
            "RJ",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox_estado.Location = new System.Drawing.Point(83, 280);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(121, 21);
            this.comboBox_estado.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Estado:";
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_pesquisar.Location = new System.Drawing.Point(302, 261);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(181, 35);
            this.button_pesquisar.TabIndex = 32;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            // 
            // txtbox_bairro
            // 
            this.txtbox_bairro.Location = new System.Drawing.Point(357, 191);
            this.txtbox_bairro.Name = "txtbox_bairro";
            this.txtbox_bairro.Size = new System.Drawing.Size(126, 20);
            this.txtbox_bairro.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(295, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Bairro:";
            // 
            // txtbox_cidade
            // 
            this.txtbox_cidade.Location = new System.Drawing.Point(357, 220);
            this.txtbox_cidade.Name = "txtbox_cidade";
            this.txtbox_cidade.Size = new System.Drawing.Size(126, 20);
            this.txtbox_cidade.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(295, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cidade:";
            // 
            // masktxt_celular
            // 
            this.masktxt_celular.Location = new System.Drawing.Point(313, 134);
            this.masktxt_celular.Mask = "(99) 99999 - 9999";
            this.masktxt_celular.Name = "masktxt_celular";
            this.masktxt_celular.Size = new System.Drawing.Size(170, 20);
            this.masktxt_celular.TabIndex = 27;
            // 
            // masktxt_telefone
            // 
            this.masktxt_telefone.Location = new System.Drawing.Point(313, 103);
            this.masktxt_telefone.Mask = "(99) 99999 - 9999";
            this.masktxt_telefone.Name = "masktxt_telefone";
            this.masktxt_telefone.Size = new System.Drawing.Size(170, 20);
            this.masktxt_telefone.TabIndex = 26;
            // 
            // masktxt_rg
            // 
            this.masktxt_rg.Location = new System.Drawing.Point(68, 128);
            this.masktxt_rg.Mask = "99,999,999 - 9";
            this.masktxt_rg.Name = "masktxt_rg";
            this.masktxt_rg.Size = new System.Drawing.Size(167, 20);
            this.masktxt_rg.TabIndex = 25;
            // 
            // masktxt_cpf
            // 
            this.masktxt_cpf.Location = new System.Drawing.Point(68, 103);
            this.masktxt_cpf.Mask = "999,999,999 - 99";
            this.masktxt_cpf.Name = "masktxt_cpf";
            this.masktxt_cpf.Size = new System.Drawing.Size(167, 20);
            this.masktxt_cpf.TabIndex = 24;
            // 
            // masktxt_cep
            // 
            this.masktxt_cep.Location = new System.Drawing.Point(83, 250);
            this.masktxt_cep.Mask = "99999-999";
            this.masktxt_cep.Name = "masktxt_cep";
            this.masktxt_cep.Size = new System.Drawing.Size(121, 20);
            this.masktxt_cep.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "CEP:";
            // 
            // txtbox_complemento
            // 
            this.txtbox_complemento.Location = new System.Drawing.Point(83, 220);
            this.txtbox_complemento.Name = "txtbox_complemento";
            this.txtbox_complemento.Size = new System.Drawing.Size(121, 20);
            this.txtbox_complemento.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Compl:";
            // 
            // txtbox_numero
            // 
            this.txtbox_numero.Location = new System.Drawing.Point(83, 191);
            this.txtbox_numero.Name = "txtbox_numero";
            this.txtbox_numero.Size = new System.Drawing.Size(121, 20);
            this.txtbox_numero.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "N°:";
            // 
            // txtbox_endereco
            // 
            this.txtbox_endereco.Location = new System.Drawing.Point(83, 166);
            this.txtbox_endereco.Name = "txtbox_endereco";
            this.txtbox_endereco.Size = new System.Drawing.Size(400, 20);
            this.txtbox_endereco.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Endereco:";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(68, 68);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(415, 20);
            this.txtbox_email.TabIndex = 11;
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(68, 37);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(415, 20);
            this.txtbox_nome.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(241, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(241, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // txtbox_codigo
            // 
            this.txtbox_codigo.Location = new System.Drawing.Point(68, 10);
            this.txtbox_codigo.Name = "txtbox_codigo";
            this.txtbox_codigo.Size = new System.Drawing.Size(168, 20);
            this.txtbox_codigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // tabPage_consultaFuncionario
            // 
            this.tabPage_consultaFuncionario.Controls.Add(this.dataGridView_listagemFuncionario);
            this.tabPage_consultaFuncionario.Controls.Add(this.button_pesquisaConsulta);
            this.tabPage_consultaFuncionario.Controls.Add(this.txtbox_nomeConsula);
            this.tabPage_consultaFuncionario.Controls.Add(this.label16);
            this.tabPage_consultaFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consultaFuncionario.Name = "tabPage_consultaFuncionario";
            this.tabPage_consultaFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consultaFuncionario.Size = new System.Drawing.Size(736, 315);
            this.tabPage_consultaFuncionario.TabIndex = 1;
            this.tabPage_consultaFuncionario.Text = "Consulta";
            this.tabPage_consultaFuncionario.UseVisualStyleBackColor = true;
            // 
            // dataGridView_listagemFuncionario
            // 
            this.dataGridView_listagemFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listagemFuncionario.Location = new System.Drawing.Point(12, 63);
            this.dataGridView_listagemFuncionario.Name = "dataGridView_listagemFuncionario";
            this.dataGridView_listagemFuncionario.Size = new System.Drawing.Size(576, 236);
            this.dataGridView_listagemFuncionario.TabIndex = 34;
            // 
            // button_pesquisaConsulta
            // 
            this.button_pesquisaConsulta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_pesquisaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisaConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisaConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_pesquisaConsulta.Location = new System.Drawing.Point(615, 63);
            this.button_pesquisaConsulta.Name = "button_pesquisaConsulta";
            this.button_pesquisaConsulta.Size = new System.Drawing.Size(104, 35);
            this.button_pesquisaConsulta.TabIndex = 33;
            this.button_pesquisaConsulta.Text = "Pesquisar";
            this.button_pesquisaConsulta.UseVisualStyleBackColor = false;
            // 
            // txtbox_nomeConsula
            // 
            this.txtbox_nomeConsula.Location = new System.Drawing.Point(94, 14);
            this.txtbox_nomeConsula.Name = "txtbox_nomeConsula";
            this.txtbox_nomeConsula.Size = new System.Drawing.Size(625, 20);
            this.txtbox_nomeConsula.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(8, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "Nome:";
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.Color.Transparent;
            this.button_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editar.Location = new System.Drawing.Point(762, 127);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(86, 37);
            this.button_editar.TabIndex = 43;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            // 
            // button_novo
            // 
            this.button_novo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_novo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_novo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_novo.Location = new System.Drawing.Point(802, 404);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(86, 37);
            this.button_novo.TabIndex = 41;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 82);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(361, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionario";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(570, 37);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(130, 20);
            this.textBox_senha.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(508, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 36;
            this.label17.Text = "Senha:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(508, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "Nivel:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(508, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "Cargo:";
            // 
            // comboBox_nivel
            // 
            this.comboBox_nivel.FormattingEnabled = true;
            this.comboBox_nivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboBox_nivel.Location = new System.Drawing.Point(570, 70);
            this.comboBox_nivel.Name = "comboBox_nivel";
            this.comboBox_nivel.Size = new System.Drawing.Size(130, 21);
            this.comboBox_nivel.TabIndex = 42;
            // 
            // comboBox_cargo
            // 
            this.comboBox_cargo.FormattingEnabled = true;
            this.comboBox_cargo.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Estagiario"});
            this.comboBox_cargo.Location = new System.Drawing.Point(570, 105);
            this.comboBox_cargo.Name = "comboBox_cargo";
            this.comboBox_cargo.Size = new System.Drawing.Size(130, 21);
            this.comboBox_cargo.TabIndex = 43;
            // 
            // formularioFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.tabControl_funcionario);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.panel1);
            this.Name = "formularioFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Funcionarios";
            this.tabControl_funcionario.ResumeLayout(false);
            this.tabPage_dadosPessoaisFuncionarios.ResumeLayout(false);
            this.tabPage_dadosPessoaisFuncionarios.PerformLayout();
            this.tabPage_consultaFuncionario.ResumeLayout(false);
            this.tabPage_consultaFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listagemFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.TabControl tabControl_funcionario;
        private System.Windows.Forms.TabPage tabPage_dadosPessoaisFuncionarios;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.TextBox txtbox_bairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbox_cidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox masktxt_celular;
        private System.Windows.Forms.MaskedTextBox masktxt_telefone;
        private System.Windows.Forms.MaskedTextBox masktxt_rg;
        private System.Windows.Forms.MaskedTextBox masktxt_cpf;
        private System.Windows.Forms.MaskedTextBox masktxt_cep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbox_complemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbox_numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_endereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_consultaFuncionario;
        private System.Windows.Forms.DataGridView dataGridView_listagemFuncionario;
        private System.Windows.Forms.Button button_pesquisaConsulta;
        private System.Windows.Forms.TextBox txtbox_nomeConsula;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_cargo;
        private System.Windows.Forms.ComboBox comboBox_nivel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label17;
    }
}
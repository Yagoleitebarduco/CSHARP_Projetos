namespace Projeo_6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_estadoCivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_possuiCasa = new System.Windows.Forms.CheckBox();
            this.checkBox_possuiVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_outros = new System.Windows.Forms.RadioButton();
            this.radioButton_feminino = new System.Windows.Forms.RadioButton();
            this.radioButton_masculino = new System.Windows.Forms.RadioButton();
            this.button_cadastrarAlterar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.dateTimePicker_dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.listBox = new System.Windows.Forms.ListBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView_lista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(67, 19);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(448, 20);
            this.textBox_nome.TabIndex = 1;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimeno: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Civil: ";
            // 
            // comboBox_estadoCivil
            // 
            this.comboBox_estadoCivil.FormattingEnabled = true;
            this.comboBox_estadoCivil.Location = new System.Drawing.Point(351, 45);
            this.comboBox_estadoCivil.Name = "comboBox_estadoCivil";
            this.comboBox_estadoCivil.Size = new System.Drawing.Size(164, 21);
            this.comboBox_estadoCivil.TabIndex = 5;
            this.comboBox_estadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox_estadoCivil_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone: ";
            // 
            // checkBox_possuiCasa
            // 
            this.checkBox_possuiCasa.AutoSize = true;
            this.checkBox_possuiCasa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_possuiCasa.Location = new System.Drawing.Point(258, 76);
            this.checkBox_possuiCasa.Name = "checkBox_possuiCasa";
            this.checkBox_possuiCasa.Size = new System.Drawing.Size(142, 19);
            this.checkBox_possuiCasa.TabIndex = 8;
            this.checkBox_possuiCasa.Text = "Possui Casa Propria";
            this.checkBox_possuiCasa.UseVisualStyleBackColor = true;
            // 
            // checkBox_possuiVeiculo
            // 
            this.checkBox_possuiVeiculo.AutoSize = true;
            this.checkBox_possuiVeiculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_possuiVeiculo.Location = new System.Drawing.Point(406, 74);
            this.checkBox_possuiVeiculo.Name = "checkBox_possuiVeiculo";
            this.checkBox_possuiVeiculo.Size = new System.Drawing.Size(109, 19);
            this.checkBox_possuiVeiculo.TabIndex = 9;
            this.checkBox_possuiVeiculo.Text = "Possui Veiculo";
            this.checkBox_possuiVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_outros);
            this.groupBox1.Controls.Add(this.radioButton_feminino);
            this.groupBox1.Controls.Add(this.radioButton_masculino);
            this.groupBox1.Location = new System.Drawing.Point(15, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButton_outros
            // 
            this.radioButton_outros.AutoSize = true;
            this.radioButton_outros.Location = new System.Drawing.Point(159, 19);
            this.radioButton_outros.Name = "radioButton_outros";
            this.radioButton_outros.Size = new System.Drawing.Size(56, 17);
            this.radioButton_outros.TabIndex = 2;
            this.radioButton_outros.TabStop = true;
            this.radioButton_outros.Text = "Outros";
            this.radioButton_outros.UseVisualStyleBackColor = true;
            // 
            // radioButton_feminino
            // 
            this.radioButton_feminino.AutoSize = true;
            this.radioButton_feminino.Location = new System.Drawing.Point(86, 19);
            this.radioButton_feminino.Name = "radioButton_feminino";
            this.radioButton_feminino.Size = new System.Drawing.Size(67, 17);
            this.radioButton_feminino.TabIndex = 1;
            this.radioButton_feminino.TabStop = true;
            this.radioButton_feminino.Text = "Feminino";
            this.radioButton_feminino.UseVisualStyleBackColor = true;
            // 
            // radioButton_masculino
            // 
            this.radioButton_masculino.AutoSize = true;
            this.radioButton_masculino.Location = new System.Drawing.Point(6, 19);
            this.radioButton_masculino.Name = "radioButton_masculino";
            this.radioButton_masculino.Size = new System.Drawing.Size(73, 17);
            this.radioButton_masculino.TabIndex = 0;
            this.radioButton_masculino.TabStop = true;
            this.radioButton_masculino.Text = "Masculino";
            this.radioButton_masculino.UseVisualStyleBackColor = true;
            // 
            // button_cadastrarAlterar
            // 
            this.button_cadastrarAlterar.Location = new System.Drawing.Point(135, 185);
            this.button_cadastrarAlterar.Name = "button_cadastrarAlterar";
            this.button_cadastrarAlterar.Size = new System.Drawing.Size(111, 27);
            this.button_cadastrarAlterar.TabIndex = 11;
            this.button_cadastrarAlterar.Text = "Cadastrar | Alterar";
            this.button_cadastrarAlterar.UseVisualStyleBackColor = true;
            this.button_cadastrarAlterar.Click += new System.EventHandler(this.button_cadastrarAlterar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(15, 185);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(72, 27);
            this.button_excluir.TabIndex = 12;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(15, 152);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(72, 27);
            this.button_limpar.TabIndex = 13;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // dateTimePicker_dataNascimento
            // 
            this.dateTimePicker_dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dataNascimento.Location = new System.Drawing.Point(147, 45);
            this.dateTimePicker_dataNascimento.Name = "dateTimePicker_dataNascimento";
            this.dateTimePicker_dataNascimento.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker_dataNascimento.TabIndex = 14;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(15, 232);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(231, 95);
            this.listBox.TabIndex = 15;
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(88, 73);
            this.maskedTextBox_telefone.Mask = "(99) 9 9999 - 9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox_telefone.TabIndex = 16;
            // 
            // dataGridView_lista
            // 
            this.dataGridView_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lista.Location = new System.Drawing.Point(258, 101);
            this.dataGridView_lista.Name = "dataGridView_lista";
            this.dataGridView_lista.Size = new System.Drawing.Size(257, 226);
            this.dataGridView_lista.TabIndex = 17;
            this.dataGridView_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lista_CellContentClick);
            this.dataGridView_lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lista_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(535, 339);
            this.Controls.Add(this.dataGridView_lista);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.dateTimePicker_dataNascimento);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cadastrarAlterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_possuiVeiculo);
            this.Controls.Add(this.checkBox_possuiCasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_estadoCivil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_estadoCivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_possuiCasa;
        private System.Windows.Forms.CheckBox checkBox_possuiVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_outros;
        private System.Windows.Forms.RadioButton radioButton_feminino;
        private System.Windows.Forms.RadioButton radioButton_masculino;
        private System.Windows.Forms.Button button_cadastrarAlterar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataNascimento;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.DataGridView dataGridView_lista;
    }
}


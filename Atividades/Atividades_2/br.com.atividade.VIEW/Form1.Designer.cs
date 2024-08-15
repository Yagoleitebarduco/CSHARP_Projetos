namespace Atividade_2
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
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.tabControl_Clientes = new System.Windows.Forms.TabControl();
            this.tabPage_dadosPessoais = new System.Windows.Forms.TabPage();
            this.textBox_descProjeto = new System.Windows.Forms.TextBox();
            this.textBox_tecUtilizada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_equipeResponsavel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateTermino = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_nomeProjeto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage_consulta = new System.Windows.Forms.TabPage();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.txtbox_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_listagem = new System.Windows.Forms.DataGridView();
            this.tabControl_Clientes.SuspendLayout();
            this.tabPage_dadosPessoais.SuspendLayout();
            this.tabPage_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_cadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cadastrar.Location = new System.Drawing.Point(532, 81);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(107, 42);
            this.button_cadastrar.TabIndex = 19;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = false;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(62, 9);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(150, 5, 150, 5);
            this.label9.Size = new System.Drawing.Size(537, 34);
            this.label9.TabIndex = 20;
            this.label9.Text = "Empressa de Software";
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editar.Location = new System.Drawing.Point(532, 227);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(107, 42);
            this.button_editar.TabIndex = 21;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_limpar.Location = new System.Drawing.Point(532, 129);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(107, 42);
            this.button_limpar.TabIndex = 22;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = false;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_excluir.Location = new System.Drawing.Point(532, 179);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(107, 42);
            this.button_excluir.TabIndex = 23;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // tabControl_Clientes
            // 
            this.tabControl_Clientes.Controls.Add(this.tabPage_dadosPessoais);
            this.tabControl_Clientes.Controls.Add(this.tabPage_consulta);
            this.tabControl_Clientes.Location = new System.Drawing.Point(12, 59);
            this.tabControl_Clientes.Name = "tabControl_Clientes";
            this.tabControl_Clientes.SelectedIndex = 0;
            this.tabControl_Clientes.Size = new System.Drawing.Size(514, 281);
            this.tabControl_Clientes.TabIndex = 24;
            // 
            // tabPage_dadosPessoais
            // 
            this.tabPage_dadosPessoais.Controls.Add(this.textBox_descProjeto);
            this.tabPage_dadosPessoais.Controls.Add(this.textBox_tecUtilizada);
            this.tabPage_dadosPessoais.Controls.Add(this.label10);
            this.tabPage_dadosPessoais.Controls.Add(this.label11);
            this.tabPage_dadosPessoais.Controls.Add(this.textBox_equipeResponsavel);
            this.tabPage_dadosPessoais.Controls.Add(this.label12);
            this.tabPage_dadosPessoais.Controls.Add(this.comboBox_status);
            this.tabPage_dadosPessoais.Controls.Add(this.label13);
            this.tabPage_dadosPessoais.Controls.Add(this.dateTimePicker_dateTermino);
            this.tabPage_dadosPessoais.Controls.Add(this.dateTimePicker_dataInicio);
            this.tabPage_dadosPessoais.Controls.Add(this.label14);
            this.tabPage_dadosPessoais.Controls.Add(this.label15);
            this.tabPage_dadosPessoais.Controls.Add(this.textBox_cliente);
            this.tabPage_dadosPessoais.Controls.Add(this.label16);
            this.tabPage_dadosPessoais.Controls.Add(this.textBox_nomeProjeto);
            this.tabPage_dadosPessoais.Controls.Add(this.label17);
            this.tabPage_dadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabPage_dadosPessoais.Name = "tabPage_dadosPessoais";
            this.tabPage_dadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dadosPessoais.Size = new System.Drawing.Size(506, 255);
            this.tabPage_dadosPessoais.TabIndex = 0;
            this.tabPage_dadosPessoais.Text = "Dados do Projeto";
            this.tabPage_dadosPessoais.UseVisualStyleBackColor = true;
            // 
            // textBox_descProjeto
            // 
            this.textBox_descProjeto.Location = new System.Drawing.Point(189, 172);
            this.textBox_descProjeto.Multiline = true;
            this.textBox_descProjeto.Name = "textBox_descProjeto";
            this.textBox_descProjeto.Size = new System.Drawing.Size(298, 66);
            this.textBox_descProjeto.TabIndex = 34;
            // 
            // textBox_tecUtilizada
            // 
            this.textBox_tecUtilizada.Location = new System.Drawing.Point(189, 138);
            this.textBox_tecUtilizada.Name = "textBox_tecUtilizada";
            this.textBox_tecUtilizada.Size = new System.Drawing.Size(298, 20);
            this.textBox_tecUtilizada.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tenologia Utilizada: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Descricao do Projeto: ";
            // 
            // textBox_equipeResponsavel
            // 
            this.textBox_equipeResponsavel.Location = new System.Drawing.Point(189, 108);
            this.textBox_equipeResponsavel.Name = "textBox_equipeResponsavel";
            this.textBox_equipeResponsavel.Size = new System.Drawing.Size(298, 20);
            this.textBox_equipeResponsavel.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "Equipe Responsavel: ";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(366, 78);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_status.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(288, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Status: ";
            // 
            // dateTimePicker_dateTermino
            // 
            this.dateTimePicker_dateTermino.CustomFormat = "2024/08/01";
            this.dateTimePicker_dateTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateTermino.Location = new System.Drawing.Point(159, 77);
            this.dateTimePicker_dateTermino.Name = "dateTimePicker_dateTermino";
            this.dateTimePicker_dateTermino.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker_dateTermino.TabIndex = 26;
            // 
            // dateTimePicker_dataInicio
            // 
            this.dateTimePicker_dataInicio.CustomFormat = "2024/08/01";
            this.dateTimePicker_dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dataInicio.Location = new System.Drawing.Point(159, 44);
            this.dateTimePicker_dataInicio.Name = "dateTimePicker_dataInicio";
            this.dateTimePicker_dataInicio.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker_dataInicio.TabIndex = 25;
            this.dateTimePicker_dataInicio.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Data de Termino: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 19);
            this.label15.TabIndex = 23;
            this.label15.Text = "Data de Inicio:";
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Location = new System.Drawing.Point(366, 44);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(121, 20);
            this.textBox_cliente.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(288, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 19);
            this.label16.TabIndex = 21;
            this.label16.Text = "Cliente: ";
            // 
            // textBox_nomeProjeto
            // 
            this.textBox_nomeProjeto.Location = new System.Drawing.Point(159, 12);
            this.textBox_nomeProjeto.Name = "textBox_nomeProjeto";
            this.textBox_nomeProjeto.Size = new System.Drawing.Size(328, 20);
            this.textBox_nomeProjeto.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 19);
            this.label17.TabIndex = 19;
            this.label17.Text = "Nome do Projeto: ";
            // 
            // tabPage_consulta
            // 
            this.tabPage_consulta.Controls.Add(this.button_pesquisar);
            this.tabPage_consulta.Controls.Add(this.txtbox_pesquisa);
            this.tabPage_consulta.Controls.Add(this.label1);
            this.tabPage_consulta.Controls.Add(this.dataGridView_listagem);
            this.tabPage_consulta.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consulta.Name = "tabPage_consulta";
            this.tabPage_consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consulta.Size = new System.Drawing.Size(506, 255);
            this.tabPage_consulta.TabIndex = 1;
            this.tabPage_consulta.Text = "Consulta";
            this.tabPage_consulta.UseVisualStyleBackColor = true;
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_pesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_pesquisar.Location = new System.Drawing.Point(393, 6);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(107, 34);
            this.button_pesquisar.TabIndex = 25;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            // 
            // txtbox_pesquisa
            // 
            this.txtbox_pesquisa.Location = new System.Drawing.Point(159, 13);
            this.txtbox_pesquisa.Name = "txtbox_pesquisa";
            this.txtbox_pesquisa.Size = new System.Drawing.Size(222, 20);
            this.txtbox_pesquisa.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome do Projeto: ";
            // 
            // dataGridView_listagem
            // 
            this.dataGridView_listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listagem.Location = new System.Drawing.Point(10, 48);
            this.dataGridView_listagem.Name = "dataGridView_listagem";
            this.dataGridView_listagem.Size = new System.Drawing.Size(371, 187);
            this.dataGridView_listagem.TabIndex = 0;
            this.dataGridView_listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listagem_CellContentClick);
            this.dataGridView_listagem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listagem_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 352);
            this.Controls.Add(this.tabControl_Clientes);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_cadastrar);
            this.Name = "Form1";
            this.Text = "Empressa de Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Clientes.ResumeLayout(false);
            this.tabPage_dadosPessoais.ResumeLayout(false);
            this.tabPage_dadosPessoais.PerformLayout();
            this.tabPage_consulta.ResumeLayout(false);
            this.tabPage_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.TabControl tabControl_Clientes;
        private System.Windows.Forms.TabPage tabPage_dadosPessoais;
        private System.Windows.Forms.TabPage tabPage_consulta;
        private System.Windows.Forms.TextBox textBox_descProjeto;
        private System.Windows.Forms.TextBox textBox_tecUtilizada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_equipeResponsavel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateTermino;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataInicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_nomeProjeto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.TextBox txtbox_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_listagem;
    }
}


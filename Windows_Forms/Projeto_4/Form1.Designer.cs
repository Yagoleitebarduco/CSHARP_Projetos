namespace Projeto_4
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
            this.label_nome = new System.Windows.Forms.Label();
            this.label_destino = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.label_data = new System.Windows.Forms.Label();
            this.groupBox_meiostransporte = new System.Windows.Forms.GroupBox();
            this.radioButton_onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.groupBox_valoresPacotes = new System.Windows.Forms.GroupBox();
            this.label_gastoTransporte = new System.Windows.Forms.Label();
            this.label_gastoDestino = new System.Windows.Forms.Label();
            this.label_valorTotal = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.button_caucular = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.labelresultValorTotal = new System.Windows.Forms.Label();
            this.label_resultGastoDestino = new System.Windows.Forms.Label();
            this.label1_resultGastoTransporte = new System.Windows.Forms.Label();
            this.groupBox_meiostransporte.SuspendLayout();
            this.groupBox_valoresPacotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(200, 5, 200, 5);
            this.label1.Size = new System.Drawing.Size(579, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva de Passagem";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(16, 55);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(52, 16);
            this.label_nome.TabIndex = 1;
            this.label_nome.Text = "Nome: ";
            // 
            // label_destino
            // 
            this.label_destino.AutoSize = true;
            this.label_destino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destino.Location = new System.Drawing.Point(16, 91);
            this.label_destino.Name = "label_destino";
            this.label_destino.Size = new System.Drawing.Size(62, 16);
            this.label_destino.TabIndex = 2;
            this.label_destino.Text = "Destino: ";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(80, 51);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(527, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data.Location = new System.Drawing.Point(80, 124);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker_data.TabIndex = 6;
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
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
            this.comboBox_destino.Location = new System.Drawing.Point(80, 90);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(121, 21);
            this.comboBox_destino.TabIndex = 7;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(16, 124);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(48, 16);
            this.label_data.TabIndex = 8;
            this.label_data.Text = "Data:  ";
            // 
            // groupBox_meiostransporte
            // 
            this.groupBox_meiostransporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_meiostransporte.Controls.Add(this.radioButton_aviao);
            this.groupBox_meiostransporte.Controls.Add(this.radioButton_onibus);
            this.groupBox_meiostransporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_meiostransporte.Location = new System.Drawing.Point(216, 87);
            this.groupBox_meiostransporte.Name = "groupBox_meiostransporte";
            this.groupBox_meiostransporte.Size = new System.Drawing.Size(162, 42);
            this.groupBox_meiostransporte.TabIndex = 9;
            this.groupBox_meiostransporte.TabStop = false;
            this.groupBox_meiostransporte.Text = "Meios de Transporte";
            // 
            // radioButton_onibus
            // 
            this.radioButton_onibus.AutoSize = true;
            this.radioButton_onibus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_onibus.Location = new System.Drawing.Point(6, 17);
            this.radioButton_onibus.Name = "radioButton_onibus";
            this.radioButton_onibus.Size = new System.Drawing.Size(65, 19);
            this.radioButton_onibus.TabIndex = 0;
            this.radioButton_onibus.TabStop = true;
            this.radioButton_onibus.Text = "Onibus";
            this.radioButton_onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_aviao.Location = new System.Drawing.Point(84, 17);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(54, 19);
            this.radioButton_aviao.TabIndex = 1;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Avião";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox_valoresPacotes
            // 
            this.groupBox_valoresPacotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_valoresPacotes.Controls.Add(this.labelresultValorTotal);
            this.groupBox_valoresPacotes.Controls.Add(this.label_resultGastoDestino);
            this.groupBox_valoresPacotes.Controls.Add(this.label1_resultGastoTransporte);
            this.groupBox_valoresPacotes.Controls.Add(this.label_valorTotal);
            this.groupBox_valoresPacotes.Controls.Add(this.label_gastoDestino);
            this.groupBox_valoresPacotes.Controls.Add(this.label_gastoTransporte);
            this.groupBox_valoresPacotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_valoresPacotes.Location = new System.Drawing.Point(80, 163);
            this.groupBox_valoresPacotes.Name = "groupBox_valoresPacotes";
            this.groupBox_valoresPacotes.Size = new System.Drawing.Size(328, 86);
            this.groupBox_valoresPacotes.TabIndex = 10;
            this.groupBox_valoresPacotes.TabStop = false;
            this.groupBox_valoresPacotes.Text = "Valores dos Pacotes";
            // 
            // label_gastoTransporte
            // 
            this.label_gastoTransporte.AutoSize = true;
            this.label_gastoTransporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gastoTransporte.Location = new System.Drawing.Point(6, 24);
            this.label_gastoTransporte.Name = "label_gastoTransporte";
            this.label_gastoTransporte.Size = new System.Drawing.Size(107, 14);
            this.label_gastoTransporte.TabIndex = 0;
            this.label_gastoTransporte.Text = "Gasto do Transporte";
            // 
            // label_gastoDestino
            // 
            this.label_gastoDestino.AutoSize = true;
            this.label_gastoDestino.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gastoDestino.Location = new System.Drawing.Point(132, 24);
            this.label_gastoDestino.Name = "label_gastoDestino";
            this.label_gastoDestino.Size = new System.Drawing.Size(98, 14);
            this.label_gastoDestino.TabIndex = 1;
            this.label_gastoDestino.Text = "Gasto com Destino";
            // 
            // label_valorTotal
            // 
            this.label_valorTotal.AutoSize = true;
            this.label_valorTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valorTotal.Location = new System.Drawing.Point(250, 24);
            this.label_valorTotal.Name = "label_valorTotal";
            this.label_valorTotal.Size = new System.Drawing.Size(57, 14);
            this.label_valorTotal.TabIndex = 2;
            this.label_valorTotal.Text = "Valor Total";
            // 
            // button_confirmar
            // 
            this.button_confirmar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_confirmar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_confirmar.Location = new System.Drawing.Point(478, 152);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(105, 29);
            this.button_confirmar.TabIndex = 12;
            this.button_confirmar.Text = "CONFIRMAR";
            this.button_confirmar.UseVisualStyleBackColor = false;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // button_caucular
            // 
            this.button_caucular.BackColor = System.Drawing.SystemColors.Control;
            this.button_caucular.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_caucular.Location = new System.Drawing.Point(531, 91);
            this.button_caucular.Name = "button_caucular";
            this.button_caucular.Size = new System.Drawing.Size(75, 32);
            this.button_caucular.TabIndex = 13;
            this.button_caucular.Text = "Caucular";
            this.button_caucular.UseVisualStyleBackColor = false;
            this.button_caucular.Click += new System.EventHandler(this.button_caucular_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.BackColor = System.Drawing.SystemColors.Control;
            this.button_limpar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(450, 91);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 32);
            this.button_limpar.TabIndex = 14;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = false;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(478, 186);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(105, 27);
            this.button_sair.TabIndex = 15;
            this.button_sair.Text = "SAIR";
            this.button_sair.UseVisualStyleBackColor = true;
            // 
            // labelresultValorTotal
            // 
            this.labelresultValorTotal.AutoSize = true;
            this.labelresultValorTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultValorTotal.Location = new System.Drawing.Point(257, 56);
            this.labelresultValorTotal.Name = "labelresultValorTotal";
            this.labelresultValorTotal.Size = new System.Drawing.Size(50, 14);
            this.labelresultValorTotal.TabIndex = 5;
            this.labelresultValorTotal.Text = "R$ 00,00";
            // 
            // label_resultGastoDestino
            // 
            this.label_resultGastoDestino.AutoSize = true;
            this.label_resultGastoDestino.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultGastoDestino.Location = new System.Drawing.Point(148, 56);
            this.label_resultGastoDestino.Name = "label_resultGastoDestino";
            this.label_resultGastoDestino.Size = new System.Drawing.Size(50, 14);
            this.label_resultGastoDestino.TabIndex = 4;
            this.label_resultGastoDestino.Text = "R$ 00,00";
            // 
            // label1_resultGastoTransporte
            // 
            this.label1_resultGastoTransporte.AutoSize = true;
            this.label1_resultGastoTransporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_resultGastoTransporte.Location = new System.Drawing.Point(28, 56);
            this.label1_resultGastoTransporte.Name = "label1_resultGastoTransporte";
            this.label1_resultGastoTransporte.Size = new System.Drawing.Size(50, 14);
            this.label1_resultGastoTransporte.TabIndex = 3;
            this.label1_resultGastoTransporte.Text = "R$ 00,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_caucular);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.groupBox_valoresPacotes);
            this.Controls.Add(this.groupBox_meiostransporte);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.dateTimePicker_data);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_destino);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(270, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilhete de Passagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_meiostransporte.ResumeLayout(false);
            this.groupBox_meiostransporte.PerformLayout();
            this.groupBox_valoresPacotes.ResumeLayout(false);
            this.groupBox_valoresPacotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_destino;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.GroupBox groupBox_meiostransporte;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.RadioButton radioButton_onibus;
        private System.Windows.Forms.GroupBox groupBox_valoresPacotes;
        private System.Windows.Forms.Label label_valorTotal;
        private System.Windows.Forms.Label label_gastoDestino;
        private System.Windows.Forms.Label label_gastoTransporte;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.Button button_caucular;
        private System.Windows.Forms.Label labelresultValorTotal;
        private System.Windows.Forms.Label label_resultGastoDestino;
        private System.Windows.Forms.Label label1_resultGastoTransporte;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_sair;
    }
}


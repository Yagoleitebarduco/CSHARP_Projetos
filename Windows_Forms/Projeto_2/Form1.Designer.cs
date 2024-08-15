namespace Projeto_2
{
    partial class Form_Saudacao
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
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button1_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_nome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(12, 9);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(72, 24);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_nome.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(91, 10);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(235, 23);
            this.textBox_nome.TabIndex = 1;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1_exibir
            // 
            this.button1_exibir.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1_exibir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_exibir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1_exibir.Location = new System.Drawing.Point(104, 91);
            this.button1_exibir.Name = "button1_exibir";
            this.button1_exibir.Size = new System.Drawing.Size(113, 33);
            this.button1_exibir.TabIndex = 2;
            this.button1_exibir.Text = "&Clique Aqui!";
            this.button1_exibir.UseVisualStyleBackColor = false;
            this.button1_exibir.Click += new System.EventHandler(this.button1_exibir_Click);
            // 
            // Form_Saudacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(338, 136);
            this.Controls.Add(this.button1_exibir);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Saudacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 2 - Saudações";
            this.Load += new System.EventHandler(this.Form_Saudacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button1_exibir;
    }
}


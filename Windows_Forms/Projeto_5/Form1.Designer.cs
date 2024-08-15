namespace Projeto_5
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.button_adicao = new System.Windows.Forms.Button();
            this.button_subtracao = new System.Windows.Forms.Button();
            this.button_divisao = new System.Windows.Forms.Button();
            this.button_multiplicacao = new System.Windows.Forms.Button();
            this.label_nomeResult = new System.Windows.Forms.Label();
            this.label_resultValor = new System.Windows.Forms.Label();
            this.button_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Valor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite Outro Valor:";
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(131, 40);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(199, 20);
            this.textBox_valor2.TabIndex = 2;
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(131, 8);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(199, 20);
            this.textBox_valor1.TabIndex = 3;
            // 
            // button_adicao
            // 
            this.button_adicao.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicao.Location = new System.Drawing.Point(61, 93);
            this.button_adicao.Name = "button_adicao";
            this.button_adicao.Size = new System.Drawing.Size(54, 39);
            this.button_adicao.TabIndex = 4;
            this.button_adicao.Text = "+";
            this.button_adicao.UseVisualStyleBackColor = true;
            this.button_adicao.Click += new System.EventHandler(this.button_adicao_Click);
            // 
            // button_subtracao
            // 
            this.button_subtracao.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtracao.Location = new System.Drawing.Point(121, 93);
            this.button_subtracao.Name = "button_subtracao";
            this.button_subtracao.Size = new System.Drawing.Size(54, 39);
            this.button_subtracao.TabIndex = 5;
            this.button_subtracao.Text = "-";
            this.button_subtracao.UseVisualStyleBackColor = true;
            this.button_subtracao.Click += new System.EventHandler(this.button_subtracao_Click);
            // 
            // button_divisao
            // 
            this.button_divisao.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divisao.Location = new System.Drawing.Point(181, 93);
            this.button_divisao.Name = "button_divisao";
            this.button_divisao.Size = new System.Drawing.Size(54, 39);
            this.button_divisao.TabIndex = 6;
            this.button_divisao.Text = "/";
            this.button_divisao.UseVisualStyleBackColor = true;
            this.button_divisao.Click += new System.EventHandler(this.button_divisao_Click);
            // 
            // button_multiplicacao
            // 
            this.button_multiplicacao.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiplicacao.Location = new System.Drawing.Point(241, 93);
            this.button_multiplicacao.Name = "button_multiplicacao";
            this.button_multiplicacao.Size = new System.Drawing.Size(54, 39);
            this.button_multiplicacao.TabIndex = 7;
            this.button_multiplicacao.Text = "*";
            this.button_multiplicacao.UseVisualStyleBackColor = true;
            this.button_multiplicacao.Click += new System.EventHandler(this.button_multiplicacao_Click);
            // 
            // label_nomeResult
            // 
            this.label_nomeResult.AutoSize = true;
            this.label_nomeResult.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeResult.Location = new System.Drawing.Point(12, 214);
            this.label_nomeResult.Name = "label_nomeResult";
            this.label_nomeResult.Size = new System.Drawing.Size(125, 24);
            this.label_nomeResult.TabIndex = 8;
            this.label_nomeResult.Text = "Resultado: ";
            // 
            // label_resultValor
            // 
            this.label_resultValor.AutoSize = true;
            this.label_resultValor.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultValor.Location = new System.Drawing.Point(125, 286);
            this.label_resultValor.Name = "label_resultValor";
            this.label_resultValor.Size = new System.Drawing.Size(78, 56);
            this.label_resultValor.TabIndex = 9;
            this.label_resultValor.Text = "00";
            // 
            // button_limpar
            // 
            this.button_limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(259, 156);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(77, 31);
            this.button_limpar.TabIndex = 10;
            this.button_limpar.Text = "LIMPAR";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 361);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.label_resultValor);
            this.Controls.Add(this.label_nomeResult);
            this.Controls.Add(this.button_multiplicacao);
            this.Controls.Add(this.button_divisao);
            this.Controls.Add(this.button_subtracao);
            this.Controls.Add(this.button_adicao);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.Name = "Form1";
            this.Text = "Cauculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.Button button_adicao;
        private System.Windows.Forms.Button button_subtracao;
        private System.Windows.Forms.Button button_divisao;
        private System.Windows.Forms.Button button_multiplicacao;
        private System.Windows.Forms.Label label_nomeResult;
        private System.Windows.Forms.Label label_resultValor;
        private System.Windows.Forms.Button button_limpar;
    }
}


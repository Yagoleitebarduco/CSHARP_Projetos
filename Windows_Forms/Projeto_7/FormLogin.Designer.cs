namespace Projeto_7
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_usuario = new System.Windows.Forms.TextBox();
            this.txtb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.bnt_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.Location = new System.Drawing.Point(19, 36);
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.Size = new System.Drawing.Size(230, 20);
            this.txtb_usuario.TabIndex = 1;
            // 
            // txtb_senha
            // 
            this.txtb_senha.Location = new System.Drawing.Point(19, 88);
            this.txtb_senha.Name = "txtb_senha";
            this.txtb_senha.PasswordChar = '*';
            this.txtb_senha.Size = new System.Drawing.Size(230, 20);
            this.txtb_senha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha: ";
            // 
            // bnt_cancelar
            // 
            this.bnt_cancelar.Location = new System.Drawing.Point(19, 135);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(97, 39);
            this.bnt_cancelar.TabIndex = 5;
            this.bnt_cancelar.Text = "Cancelar";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            this.bnt_cancelar.Click += new System.EventHandler(this.bnt_cancelar_Click);
            // 
            // bnt_entrar
            // 
            this.bnt_entrar.Location = new System.Drawing.Point(152, 135);
            this.bnt_entrar.Name = "bnt_entrar";
            this.bnt_entrar.Size = new System.Drawing.Size(97, 39);
            this.bnt_entrar.TabIndex = 6;
            this.bnt_entrar.Text = "Entrar";
            this.bnt_entrar.UseVisualStyleBackColor = true;
            this.bnt_entrar.Click += new System.EventHandler(this.bnt_entrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 188);
            this.ControlBox = false;
            this.Controls.Add(this.bnt_entrar);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.txtb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_usuario;
        private System.Windows.Forms.TextBox txtb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_cancelar;
        private System.Windows.Forms.Button bnt_entrar;
    }
}
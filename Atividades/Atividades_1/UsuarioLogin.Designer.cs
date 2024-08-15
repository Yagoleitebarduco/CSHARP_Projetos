namespace Atividades_1
{
    partial class UsuarioLogin
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
            this.bnt_entrar = new System.Windows.Forms.Button();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.txtb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_entrar
            // 
            this.bnt_entrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_entrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_entrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnt_entrar.Location = new System.Drawing.Point(277, 141);
            this.bnt_entrar.Name = "bnt_entrar";
            this.bnt_entrar.Size = new System.Drawing.Size(97, 39);
            this.bnt_entrar.TabIndex = 12;
            this.bnt_entrar.Text = "Entrar";
            this.bnt_entrar.UseVisualStyleBackColor = false;
            this.bnt_entrar.Click += new System.EventHandler(this.bnt_entrar_Click);
            // 
            // bnt_cancelar
            // 
            this.bnt_cancelar.Location = new System.Drawing.Point(174, 141);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(97, 39);
            this.bnt_cancelar.TabIndex = 11;
            this.bnt_cancelar.Text = "Cancelar";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            this.bnt_cancelar.Click += new System.EventHandler(this.bnt_cancelar_Click);
            // 
            // txtb_senha
            // 
            this.txtb_senha.Location = new System.Drawing.Point(96, 96);
            this.txtb_senha.Name = "txtb_senha";
            this.txtb_senha.PasswordChar = '*';
            this.txtb_senha.Size = new System.Drawing.Size(277, 20);
            this.txtb_senha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha: ";
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.Location = new System.Drawing.Point(96, 63);
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.Size = new System.Drawing.Size(277, 20);
            this.txtb_usuario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(90, 5, 90, 5);
            this.label10.Size = new System.Drawing.Size(363, 42);
            this.label10.TabIndex = 13;
            this.label10.Text = "Clinica Geral";
            // 
            // UsuarioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 192);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnt_entrar);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.txtb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UsuarioLgin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_entrar;
        private System.Windows.Forms.Button bnt_cancelar;
        private System.Windows.Forms.TextBox txtb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}
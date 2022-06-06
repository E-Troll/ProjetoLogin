namespace ProjetoLogin.Apresentacao
{
    partial class CadastreSe
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
            this.btnCadastrarSe = new System.Windows.Forms.Button();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.confSenha = new System.Windows.Forms.Label();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarSe
            // 
            this.btnCadastrarSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrarSe.Location = new System.Drawing.Point(50, 151);
            this.btnCadastrarSe.Name = "btnCadastrarSe";
            this.btnCadastrarSe.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrarSe.TabIndex = 0;
            this.btnCadastrarSe.Text = "Cadastrar-se";
            this.btnCadastrarSe.UseVisualStyleBackColor = false;
            this.btnCadastrarSe.Click += new System.EventHandler(this.CadastrarSe_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(98, 24);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(100, 20);
            this.txbLogin.TabIndex = 1;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(98, 59);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(10, 27);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(10, 66);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // confSenha
            // 
            this.confSenha.AutoSize = true;
            this.confSenha.Location = new System.Drawing.Point(10, 103);
            this.confSenha.Name = "confSenha";
            this.confSenha.Size = new System.Drawing.Size(82, 13);
            this.confSenha.TabIndex = 5;
            this.confSenha.Text = "Comfirma senha";
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Location = new System.Drawing.Point(98, 96);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.PasswordChar = '*';
            this.txbConfSenha.Size = new System.Drawing.Size(100, 20);
            this.txbConfSenha.TabIndex = 6;
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(217, 234);
            this.Controls.Add(this.txbConfSenha);
            this.Controls.Add(this.confSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnCadastrarSe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.Text = "Cadastre-se";
            this.Load += new System.EventHandler(this.CadastreSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarSe;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label confSenha;
        private System.Windows.Forms.TextBox txbConfSenha;
    }
}
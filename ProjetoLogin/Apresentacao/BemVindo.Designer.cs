namespace ProjetoLogin.Apresentacao
{
    partial class BemVindo
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
            this.lblBemVindos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBemVindos
            // 
            this.lblBemVindos.AutoSize = true;
            this.lblBemVindos.Font = new System.Drawing.Font("MV Boli", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindos.Location = new System.Drawing.Point(-11, 52);
            this.lblBemVindos.Name = "lblBemVindos";
            this.lblBemVindos.Size = new System.Drawing.Size(664, 125);
            this.lblBemVindos.TabIndex = 0;
            this.lblBemVindos.Text = "Bem Vindo ! ";
            this.lblBemVindos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBemVindos.Click += new System.EventHandler(this.lblBemVindos_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 304);
            this.Controls.Add(this.lblBemVindos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BemVindo";
            this.Text = "Bem Vindo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindos;
    }
}
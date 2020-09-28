namespace TRANSPORTADORA
{
    partial class FrmLoggin
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
            this.txtloggin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btmlogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtloggin
            // 
            this.txtloggin.Location = new System.Drawing.Point(283, 266);
            this.txtloggin.Name = "txtloggin";
            this.txtloggin.Size = new System.Drawing.Size(189, 20);
            this.txtloggin.TabIndex = 0;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(283, 332);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '6';
            this.txtsenha.Size = new System.Drawing.Size(189, 20);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // btmlogar
            // 
            this.btmlogar.Location = new System.Drawing.Point(396, 374);
            this.btmlogar.Name = "btmlogar";
            this.btmlogar.Size = new System.Drawing.Size(75, 23);
            this.btmlogar.TabIndex = 2;
            this.btmlogar.Text = "Iniciar";
            this.btmlogar.UseVisualStyleBackColor = true;
            this.btmlogar.Click += new System.EventHandler(this.btmlogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(283, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(285, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(185, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loading...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(246, 406);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // FrmLoggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TRANSPORTADORA.Properties.Resources.loggin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmlogar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtloggin);
            this.DoubleBuffered = true;
            this.Name = "FrmLoggin";
            this.Text = "Autenticação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtloggin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btmlogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
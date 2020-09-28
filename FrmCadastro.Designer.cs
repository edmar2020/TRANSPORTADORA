namespace TRANSPORTADORA
{
    partial class FrmCadastro
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
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.cmdAdicionarCliente = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEnderecocli = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNomecli = new System.Windows.Forms.TextBox();
            this.lblNomecli = new System.Windows.Forms.Label();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastro
            // 
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.rbMasculino);
            this.gbCadastro.Controls.Add(this.rbFeminino);
            this.gbCadastro.Controls.Add(this.cmdAdicionarCliente);
            this.gbCadastro.Controls.Add(this.txtCpf);
            this.gbCadastro.Controls.Add(this.lblCpf);
            this.gbCadastro.Controls.Add(this.txtCidade);
            this.gbCadastro.Controls.Add(this.lblCidade);
            this.gbCadastro.Controls.Add(this.txtBairro);
            this.gbCadastro.Controls.Add(this.lblBairro);
            this.gbCadastro.Controls.Add(this.txtEnderecocli);
            this.gbCadastro.Controls.Add(this.lblEndereco);
            this.gbCadastro.Controls.Add(this.txtNomecli);
            this.gbCadastro.Controls.Add(this.lblNomecli);
            this.gbCadastro.Location = new System.Drawing.Point(129, 140);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(508, 235);
            this.gbCadastro.TabIndex = 11;
            this.gbCadastro.TabStop = false;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(150, 198);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(39, 198);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 6;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // cmdAdicionarCliente
            // 
            this.cmdAdicionarCliente.Location = new System.Drawing.Point(397, 198);
            this.cmdAdicionarCliente.Name = "cmdAdicionarCliente";
            this.cmdAdicionarCliente.Size = new System.Drawing.Size(83, 23);
            this.cmdAdicionarCliente.TabIndex = 8;
            this.cmdAdicionarCliente.Text = "CADASTRAR";
            this.cmdAdicionarCliente.UseVisualStyleBackColor = true;
            this.cmdAdicionarCliente.Click += new System.EventHandler(this.cmdAdicionarCliente_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(83, 56);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(414, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(36, 58);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 18);
            this.lblCpf.TabIndex = 19;
            this.lblCpf.Text = "CPF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(105, 151);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(392, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(36, 153);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(69, 18);
            this.lblCidade.TabIndex = 17;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(105, 116);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(392, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(36, 118);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(63, 18);
            this.lblBairro.TabIndex = 15;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEnderecocli
            // 
            this.txtEnderecocli.Location = new System.Drawing.Point(133, 82);
            this.txtEnderecocli.Name = "txtEnderecocli";
            this.txtEnderecocli.Size = new System.Drawing.Size(364, 20);
            this.txtEnderecocli.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(36, 84);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(91, 18);
            this.lblEndereco.TabIndex = 13;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNomecli
            // 
            this.txtNomecli.Location = new System.Drawing.Point(180, 25);
            this.txtNomecli.Name = "txtNomecli";
            this.txtNomecli.Size = new System.Drawing.Size(317, 20);
            this.txtNomecli.TabIndex = 1;
            // 
            // lblNomecli
            // 
            this.lblNomecli.AutoSize = true;
            this.lblNomecli.BackColor = System.Drawing.Color.Transparent;
            this.lblNomecli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomecli.Location = new System.Drawing.Point(36, 27);
            this.lblNomecli.Name = "lblNomecli";
            this.lblNomecli.Size = new System.Drawing.Size(143, 18);
            this.lblNomecli.TabIndex = 11;
            this.lblNomecli.Text = "Nome do Cliente:";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TRANSPORTADORA.Properties.Resources.cadastro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.gbCadastro);
            this.DoubleBuffered = true;
            this.Name = "FrmCadastro";
            this.Text = "Cadastro de Clientes";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button cmdAdicionarCliente;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEnderecocli;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNomecli;
        private System.Windows.Forms.Label lblNomecli;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
    }
}
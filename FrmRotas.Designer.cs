﻿namespace TRANSPORTADORA
{
    partial class FrmRotas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomerotas = new System.Windows.Forms.TextBox();
            this.txtprecorota = new System.Windows.Forms.TextBox();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.cmdcadastrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Rotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Rota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço R$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distância:";
            // 
            // txtnomerotas
            // 
            this.txtnomerotas.Location = new System.Drawing.Point(130, 164);
            this.txtnomerotas.Name = "txtnomerotas";
            this.txtnomerotas.Size = new System.Drawing.Size(191, 20);
            this.txtnomerotas.TabIndex = 5;
            // 
            // txtprecorota
            // 
            this.txtprecorota.Location = new System.Drawing.Point(130, 198);
            this.txtprecorota.Name = "txtprecorota";
            this.txtprecorota.Size = new System.Drawing.Size(191, 20);
            this.txtprecorota.TabIndex = 6;
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(106, 232);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(215, 20);
            this.txtdistancia.TabIndex = 7;
            // 
            // cmdcadastrar
            // 
            this.cmdcadastrar.Location = new System.Drawing.Point(234, 258);
            this.cmdcadastrar.Name = "cmdcadastrar";
            this.cmdcadastrar.Size = new System.Drawing.Size(87, 23);
            this.cmdcadastrar.TabIndex = 9;
            this.cmdcadastrar.Text = "CADASTRAR";
            this.cmdcadastrar.UseVisualStyleBackColor = true;
            this.cmdcadastrar.Click += new System.EventHandler(this.cmdcadastrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(393, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 251);
            this.listBox1.TabIndex = 10;
            // 
            // cmdlimpar
            // 
            this.cmdlimpar.Location = new System.Drawing.Point(143, 258);
            this.cmdlimpar.Name = "cmdlimpar";
            this.cmdlimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdlimpar.TabIndex = 11;
            this.cmdlimpar.Text = "LIMPAR";
            this.cmdlimpar.UseVisualStyleBackColor = true;
            this.cmdlimpar.Click += new System.EventHandler(this.cmdlimpar_Click);
            // 
            // FrmRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TRANSPORTADORA.Properties.Resources.rotas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdlimpar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdcadastrar);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.txtprecorota);
            this.Controls.Add(this.txtnomerotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FrmRotas";
            this.Text = "Rotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomerotas;
        private System.Windows.Forms.TextBox txtprecorota;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.Button cmdcadastrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdlimpar;
    }
}
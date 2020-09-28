namespace TRANSPORTADORA
{
    partial class FrmInicial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasEDestinosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasEDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularFretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClientesToolStripMenuItem,
            this.rotasEDestinosToolStripMenuItem1,
            this.rotasEDestinosToolStripMenuItem,
            this.calcularFretesToolStripMenuItem,
            this.frotasToolStripMenuItem,
            this.faturamentoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            this.cadastrarClientesToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cadastrarClientesToolStripMenuItem.Text = "Cadastrar Clientes";
            this.cadastrarClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClientesToolStripMenuItem_Click);
            // 
            // rotasEDestinosToolStripMenuItem1
            // 
            this.rotasEDestinosToolStripMenuItem1.Name = "rotasEDestinosToolStripMenuItem1";
            this.rotasEDestinosToolStripMenuItem1.Size = new System.Drawing.Size(104, 20);
            this.rotasEDestinosToolStripMenuItem1.Text = "Rotas e destinos";
            this.rotasEDestinosToolStripMenuItem1.Click += new System.EventHandler(this.rotasEDestinosToolStripMenuItem1_Click);
            // 
            // rotasEDestinosToolStripMenuItem
            // 
            this.rotasEDestinosToolStripMenuItem.Name = "rotasEDestinosToolStripMenuItem";
            this.rotasEDestinosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // calcularFretesToolStripMenuItem
            // 
            this.calcularFretesToolStripMenuItem.Name = "calcularFretesToolStripMenuItem";
            this.calcularFretesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.calcularFretesToolStripMenuItem.Text = "Calcular Fretes";
            this.calcularFretesToolStripMenuItem.Click += new System.EventHandler(this.calcularFretesToolStripMenuItem_Click);
            // 
            // frotasToolStripMenuItem
            // 
            this.frotasToolStripMenuItem.Name = "frotasToolStripMenuItem";
            this.frotasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.frotasToolStripMenuItem.Text = "Frotas";
            this.frotasToolStripMenuItem.Click += new System.EventHandler(this.frotasToolStripMenuItem_Click);
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            this.faturamentoToolStripMenuItem.Click += new System.EventHandler(this.faturamentoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Font = new System.Drawing.Font("Berkelium Type", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Silver;
            this.lbltimer.Location = new System.Drawing.Point(12, 44);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(313, 21);
            this.lbltimer.TabIndex = 1;
            this.lbltimer.Text = "Hora Atual : 00:00:00";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TRANSPORTADORA.Properties.Resources.PROJETO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicial";
            this.Text = "AREADO TRANSPORTES - (35) 3293-2678";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasEDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularFretesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasEDestinosToolStripMenuItem1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}


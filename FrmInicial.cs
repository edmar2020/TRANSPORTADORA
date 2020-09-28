using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA
{
    public partial class FrmInicial : Form
    {
        List<cliente> Listacliente = new List<cliente>();
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro CC = new FrmCadastro();
            CC.ListaCadastro = Listacliente;
            CC.ShowDialog();
        }

        private void rotasEDestinosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRotas RD = new FrmRotas();
            RD.ShowDialog();
        }

        private void calcularFretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalcular CF = new FrmCalcular();
            CF.ListaCalcular = Listacliente;
            CF.ShowDialog();
        }

        private void frotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFrotas FR = new FrmFrotas();
            FR.ShowDialog();
        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFaturamento FT = new FrmFaturamento();
            FT.ShowDialog();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = "Hora Atual: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("http://www.unifenas.br");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre SB = new FrmSobre();
            SB.ShowDialog();
        }
    }
}

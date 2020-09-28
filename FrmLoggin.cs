using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TRANSPORTADORA
{
    public partial class FrmLoggin : Form
    {
        public FrmLoggin()
        {
            InitializeComponent();
        }

        private void btmlogar_Click(object sender, EventArgs e)
        {
            FrmInicial LO = new FrmInicial();
            string nome = txtloggin.Text;
            string senha = txtsenha.ToString();

            if (nome == "Edmar")
            {
                MessageBox.Show("Loggin Efetuado com Sucesso");
                int cont = 0;
                progressBar1.Value = 0;
                for (int i = 0; i <= progressBar1.Maximum; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(50);
                }
               
                FrmInicial IN = new FrmInicial();
                IN.ShowDialog();
                Close();
            }


            else
                MessageBox.Show("Dados INCORRETOS, tente novamente");
                txtloggin.Enabled = true;
                txtsenha.Enabled = true;
         }

    }
}


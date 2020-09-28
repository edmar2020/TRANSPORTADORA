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
    public partial class FrmRotas : Form
    {
        internal List<Rotas> Listaderotas = new List<Rotas>();
        
        public FrmRotas()
        {
            InitializeComponent();
        }
        
        internal List<Rotas> Listaderotas1 { get => Listaderotas; set => Listaderotas = value; }
        int aux = 0;
        private void cmdcadastrar_Click(object sender, EventArgs e)
        {
            Rotas r1 = new Rotas();
            r1.Nome = txtnomerotas.Text;
            r1.Km = txtdistancia.Text;
            r1.Preco = txtprecorota.Text;
            Listaderotas1.Add(r1);
            txtnomerotas.Clear();
            txtdistancia.Clear();
            txtprecorota.Clear();
            
            listBox1.Items.Add(Listaderotas[aux].Nome);
            aux++;
        }

        private void cmdlimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}

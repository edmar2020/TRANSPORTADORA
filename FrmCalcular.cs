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
    public partial class FrmCalcular : Form
    {
        FrmFaturamento manda = null;
        List<Rotas> listaRotas = new List<Rotas>();
        List<cliente> listaCalcular = null;
        internal List<cliente> ListaCalcular { get => listaCalcular; set => listaCalcular = value; }
        internal List<Rotas> ListaRotas { get => listaRotas; set => listaRotas = value; }

        cliente CF = null;
        Rotas LR = null;
        int x = 0;
        int y = 0;
        public FrmCalcular()
        {
            InitializeComponent();
        }



        //Por algum motivo essa função estava escrita errada por isso não executava o Foreach
        private void FrmCalcular_Load(object sender, EventArgs e)
        {
            foreach (cliente x in ListaCalcular)
            {
                cb1.Items.Add(x.Nome);

            }

        }

        public void btmCalcular_Click(object sender, EventArgs e)
        {
            cb1.Enabled = true;
            cb2.Enabled = true;
            cb2.Items.Clear();
            listaRotas.Clear();
            monthCalendar1.Enabled = true;
            monthCalendar1.RemoveAllMonthlyBoldedDates();
            listBox1.Items.Clear();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Essa função pega o Indice da lista
            //O local exato de onde está o cliente que vc quer
            int aux = cb1.SelectedIndex;
            //Usando essa funçãozinha aq voce consegue acessar todos os campos que precisa
            listBox1.Items.Add(listaCalcular[aux].MostraResultado());
            Rotas r1 = new Rotas();
            r1.Nome = "Areado - Alterosa";
            r1.Km = 17.ToString();
            r1.Preco = 70.ToString();
            ListaRotas.Add(r1);


            foreach (Rotas y in ListaRotas)
            {
                cb2.Items.Add(y.Nome);

            }
            cb1.Enabled = false;
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux2 = cb2.SelectedIndex;
            listBox1.Items.Add(ListaRotas[aux2].MostraResultadoRotas());
            cb2.Enabled = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            listBox1.Items.Add("Data: " + monthCalendar1.SelectionRange.Start.ToShortDateString());
            monthCalendar1.Enabled = false;
        }

        private void btmEnviar_Click(object sender, EventArgs e)
        {
            manda = new FrmFaturamento(listBox1);
        }
    }
}


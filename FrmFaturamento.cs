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
    public partial class FrmFaturamento : Form
    {
        private FrmCalcular Calcular = new FrmCalcular();
        ListBox Lista = new ListBox();

        public FrmFaturamento()
        {
            InitializeComponent();
        }

        public FrmFaturamento(ListBox box)
        {
            InitializeComponent();
            Lista = box;
            atualiza();
        }

        public void atualiza()
        {
            list1 = Lista;
        }
        

        
    }
}

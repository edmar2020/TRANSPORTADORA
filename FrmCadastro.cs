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
    public partial class FrmCadastro : Form
    {
        List<cliente> listaCadastro = null;
        internal List<cliente> ListaCadastro { get => listaCadastro; set => listaCadastro = value; }
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void cmdAdicionarCliente_Click(object sender, EventArgs e)
        {
            cliente c1 = new cliente();

            c1.Nome = txtNomecli.Text;
            c1.Cpf = txtCpf.Text;
            c1.Endereco = txtEnderecocli.Text;
            c1.Bairro = txtBairro.Text;
            c1.Cidade = txtCidade.Text;
            if (rbFeminino.Checked == true)
            {
                c1.Sexo = "feminino";
            }
            else{
                c1.Sexo = "masculino";
            }
            ListaCadastro.Add(c1);
            MessageBox.Show("Cadastro Realizado com Sucesso ! ");
            Close();
            
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA
{
    class Rotas
    {
        private string nome;
        private string preco;
        private string km;
       // private DateTime data;

        public string Nome { get => nome; set => nome = value; }
        public string Preco { get => preco; set => preco = value; }
       // public DateTime Data { get => data; set => data = value; }
        public string Km { get => km; set => km = value; }

        public string MostraResultadoRotas()
        {
            string nomeaux = "";
            string precoaux;
            string kmaux;
            precoaux = preco;
            nomeaux = "Rota: "+Nome;
            kmaux = km;
            nomeaux = nomeaux + " - Km: " + kmaux + " - Preço: "+precoaux;
            return nomeaux; // nos temos que concatenar essa linha....ai vai tudo junto
        }
    }
}

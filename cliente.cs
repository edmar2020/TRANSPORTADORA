using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTADORA
{
    class cliente
    {
        private string nome;
        private string cpf;
        private string endereco;
        private string bairro;
        private string cidade;
        private string sexo;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    
     public string MostraResultado()
        {
            string nomeaux = "";
            nomeaux = Nome;
            return nomeaux;
        }
    
    }
}

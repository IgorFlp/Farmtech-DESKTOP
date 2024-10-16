using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmtech.Entidades
{
    public class ClienteEnderecoEnt
    {
        private string clCpf;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;

        public string ClCpf { get => clCpf; set => clCpf = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
    }
    
 }

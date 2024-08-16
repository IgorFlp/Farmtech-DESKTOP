using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Entidades
{
    internal class ProdutoEnt
    {
        private int id;
        private string nome;
        private string unMedida;
        private double precoUn;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string UnMedida { get => unMedida; set => unMedida = value; }
        public double PrecoUn { get => precoUn; set => precoUn = value; }
    }
}

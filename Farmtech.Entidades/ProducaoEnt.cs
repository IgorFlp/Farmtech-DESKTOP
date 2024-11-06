using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Entidades
{
    public class ProducaoEnt
    {
        public int Id { get; set; }
        public DateTime DataProd { get; set; }
    }
    public class ProducaoProdutoEnt : EstoqueEnt {
        public int Pdc_id { get; set; } 
    }
}

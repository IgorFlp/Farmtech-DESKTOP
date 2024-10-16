using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Entidades
{
    public class VendaEnt
    {
        public int Id{ get; set; }      
        public double Subtotal{ get; set; }      
        public double Frete{ get; set; }      
        public double Desconto{ get; set; }      
        public double Total{ get; set; }      
        public string Cupom{ get; set; }      
        public string MtdPagto{ get; set; }      
        public string Entrega{ get; set; }      
        public string Cl_cpf{ get; set; }
        public DateTime DtVenda{ get; set; }      
        public int Usr_id{ get; set; }      
    }
}

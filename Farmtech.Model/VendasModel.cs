using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public class VendasModel
    {
        public CupomEnt consultarCupom(string cupom)
        {
            CupomEnt cupomEnt = new CupomEnt();
            VendasDAO vendasDAO = new VendasDAO();
            cupomEnt = vendasDAO.BuscarCupom(cupom);
            return cupomEnt;
        }
        public VendaEnt CadastrarVenda(VendaEnt venda)
        {
            VendasDAO vendaDAO = new VendasDAO();
            VendaEnt vendaEnt = new VendaEnt();
            vendaEnt = vendaDAO.CadastrarVenda(venda);
            return vendaEnt;
        }
        public string CadastrarProdutos(List<VendaProdutoEnt> produtos)
        {
            VendasDAO vendaDAO = new VendasDAO();
            string res =  vendaDAO.CadastrarProdutos(produtos);
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            string res2 = estoqueDAO.SubtrairEstoque(produtos);
            if(res == "Sucesso" && res2 == "Sucesso")
            {
                return "Sucesso";
            }
            else
            {
                return "Erro";
            }
            
            
        }
        /*
        public string Criar(VendasEnt vendas)
        {            
                VendasDAO vendasDAO = new VendasDAO();
                string res = vendasDAO.Criar(vendas);
                return res;
            
        }
        public string Excluir(int id)
        {
            VendasDAO vendasDAO = new VendasDAO();
            string res = vendasDAO.Excluir(id);
            return res;
        }
        public VendasEnt BuscarVendas(int id)
        {
            VendasEnt vendasEnt = new VendasEnt();

            VendasDAO vendasDAO = new VendasDAO();
            vendasEnt = vendasDAO.BuscarVendas(id);
            return vendasEnt;
        }
        
        public string Atualizar(VendasEnt vendasEnt)
        {
            VendasDAO vendasDAO = new VendasDAO();
            String res = vendasDAO.Atualizar(vendasEnt);
            return res;
        }*/
    }
}

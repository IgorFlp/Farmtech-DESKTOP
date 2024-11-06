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
        public List<VendaEnt> BuscarVendas()
        {
            List<VendaEnt> vendas = new List<VendaEnt>();
            VendasDAO vendasDAO = new VendasDAO();
            vendas = vendasDAO.BuscarVendas();
            return vendas;
        }
        public List<VendaProdutoEnt> BuscarVendasProdutos()
        {
            List<VendaProdutoEnt> vendasProdutos = new List<VendaProdutoEnt>();
            VendasDAO vendasDAO = new VendasDAO();
            vendasProdutos = vendasDAO.BuscarVendasProdutos();
            return vendasProdutos;
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
        
        
        public string Atualizar(VendasEnt vendasEnt)
        {
            VendasDAO vendasDAO = new VendasDAO();
            String res = vendasDAO.Atualizar(vendasEnt);
            return res;
        }*/
    }
}

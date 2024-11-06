using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public class ProdutoModel
    {
        public string Criar(ProdutoEnt produto)
        {            
                ProdutoDAO produtoDAO = new ProdutoDAO();
                ProdutoEnt p = produtoDAO.Criar(produto);
                
                int id = p.Id;
                string res = EstoqueDAO.CriarEstoque(id,100.0);
                return res;
            
        }
        public string Excluir(int id)
        {
            EstoqueDAO.DeleteEstoque(id);
            ProdutoDAO produtoDAO = new ProdutoDAO();
            string res = produtoDAO.Excluir(id);
            return res;
        }
        public ProdutoEnt BuscarProduto(int id)
        {
            ProdutoEnt produtoEnt = new ProdutoEnt();

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoEnt = produtoDAO.BuscarProduto(id);
            return produtoEnt;
        }
        public List<ProdutoEnt> BuscarProdutos()
        {
            List<ProdutoEnt> produtoEnt = new List<ProdutoEnt>();

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoEnt = produtoDAO.BuscarProdutos();
            return produtoEnt;
        }
        public static List<EstoqueEnt> BuscarEstoques()
        {
            List<EstoqueEnt> estoques = new List<EstoqueEnt>();
            estoques = EstoqueDAO.BuscarEstoques();
            return estoques;
        }

        public string Atualizar(ProdutoEnt produtoEnt)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            String res = produtoDAO.Atualizar(produtoEnt);
            return res;
        }
    }
}

using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public static class ProducaoModel
    {
        public static ProducaoEnt CadastrarProducao(ProducaoEnt producao) {
            
            producao = ProducaoDAO.CadastrarProducao(producao);
            return producao;
        }
        public static string CadastrarProdutos(List<ProducaoProdutoEnt> produtos)
        {            
            string res = ProducaoDAO.CadastrarProdutos(produtos);
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            string res2 = estoqueDAO.AdicionarEstoque(produtos);
            if (res == "Sucesso" && res2 == "Sucesso")
            {
                return "Sucesso";
            }
            else
            {
                return "Erro";
            }
        }
        public static List<ProducaoEnt> BuscarProducoes()
        {
            List<ProducaoEnt> producoes = new List<ProducaoEnt>();            
            producoes = ProducaoDAO.BuscarProducoes();
            return producoes;
        }
        public static List<ProducaoProdutoEnt> BuscarProducoesProdutos()
        {
            List<ProducaoProdutoEnt> produtos = new List<ProducaoProdutoEnt>();
            produtos = ProducaoDAO.BuscarProducoesProdutos();
            return produtos;
        }
    }
}

using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public class FornecedorModel
    {
        public static string Criar(FornecedorEnt fornecedor, FornecedorEnderecoEnt endereco)
        {            
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            string res = fornecedorDAO.Criar(fornecedor, endereco);
            return res;
        }
     
        public string Excluir(String cnpj)
        {
            FornecedorDAO fornecedorDAO=new FornecedorDAO();
            string res = fornecedorDAO.Excluir(cnpj);
            return res;     
        }
        public FornecedorEnt BuscarFornecedor(String cnpj) { 
            FornecedorEnt fornecedorEnt = new FornecedorEnt();
            
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedorEnt = fornecedorDAO.BuscarFornecedor(cnpj);
            return fornecedorEnt;
        }
        public List<FornecedorEnt> BuscarFornecedores()
        {
            List<FornecedorEnt> fornecedores = new List<FornecedorEnt>();
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            fornecedores = fornecedorDAO.BuscarFornecedores();
            return fornecedores;
        }
        public FornecedorEnderecoEnt BuscarEndereco(String cnpj)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            FornecedorEnderecoEnt enderecoEnt = new FornecedorEnderecoEnt();
            enderecoEnt = fornecedorDAO.BuscarEndereco(cnpj);
            return enderecoEnt;
        }
        public static string Atualizar(FornecedorEnt fornecedorEnt, FornecedorEnderecoEnt enderecoEnt)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            String res = fornecedorDAO.Atualizar(fornecedorEnt, enderecoEnt);
            return res; 
        }
    }
}

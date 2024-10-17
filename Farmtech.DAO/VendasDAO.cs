using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.DAO
{
    public class VendasDAO
    {
        public CupomEnt BuscarCupom(string cupom)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = "SELECT * FROM Tb_cupom WHERE nome = @nome";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    CupomEnt cupomEnt = new CupomEnt();
                    cmd.Parameters.AddWithValue("@nome", cupom);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            
                           cupomEnt.Nome = reader["nome"].ToString();
                           cupomEnt.DtValid = Convert.ToDateTime(reader["dtValid"]);
                           cupomEnt.Valor = Convert.ToDouble(reader["valor"]);
                            
                           return cupomEnt;
                        }
                        else{
                            return null;
                        }
                    }                    
                }
            }
        }
        public VendaEnt CadastrarVenda(VendaEnt venda)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = @"INSERT INTO Tb_venda (subtotal,frete,desconto,total,cupom,mtdPagto,cl_cpf,dtVenda,entrega,usr_id) values(@subtotal,@frete,@desconto,@total,@cupom,@mtdPagto,@cl_cpf,@dtVenda,@entrega,@usr_id);SELECT SCOPE_IDENTITY();";
                

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {                     
                    cmd.Parameters.AddWithValue("@subtotal", venda.Subtotal);
                    cmd.Parameters.AddWithValue("@frete", venda.Frete);
                    cmd.Parameters.AddWithValue("@desconto", venda.Desconto);
                    cmd.Parameters.AddWithValue("@total", venda.Total);
                    cmd.Parameters.AddWithValue("@cupom", venda.Cupom);
                    cmd.Parameters.AddWithValue("@mtdPagto", venda.MtdPagto);
                    cmd.Parameters.AddWithValue("@cl_cpf", venda.Cl_cpf);
                    cmd.Parameters.AddWithValue("@dtVenda", venda.DtVenda);
                    cmd.Parameters.AddWithValue("@entrega", venda.Entrega);
                    cmd.Parameters.AddWithValue("@usr_id", venda.Usr_id);
                    

                    object result = cmd.ExecuteScalar();

                    // Converte o resultado para o tipo int (ID gerado)
                    int novoId = Convert.ToInt32(result);
                    venda.Id = novoId;
                    if(novoId > 0)
                    {
                        Console.WriteLine("ID gerado: " + novoId);                        
                        return venda;
                    }
                    conn.Close();
                }
                conn.Close();
                return null;                
            }
        }
        public string CadastrarProdutos(List<VendaProdutoEnt> produtos)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = @"INSERT INTO Tb_ven_produtos (ven_id, pdt_id,quant) values(@ven_id,@pdt_id,@quant)";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        
                        foreach (VendaProdutoEnt produto in produtos)
                        {
                            Console.WriteLine("Produto id: " + produto.Pdt_id);
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ven_id", produto.Ven_id);
                            cmd.Parameters.AddWithValue("@pdt_id", produto.Pdt_id);
                            cmd.Parameters.AddWithValue("@quant", produto.Quant);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                        return "Sucesso";                        
                    }catch (Exception ex)
                    {                        
                        Console.WriteLine("Erro: "+ex.ToString());
                        return "Erro";
                    }
                }              
                               
            }
        }
        public List<VendaEnt> BuscarVendas()
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do usuario
                string query = "SELECT * FROM Tb_venda";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    List<VendaEnt> vendas = new List<VendaEnt>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                            while (reader.Read())
                            {
                                VendaEnt venda = new VendaEnt();
                                venda.Id = Convert.ToInt32(reader["id"]);
                                venda.Cl_cpf = reader["cl_cpf"].ToString();
                                venda.Subtotal = Convert.ToDouble(reader["subtotal"]);
                                venda.Frete = Convert.ToDouble(reader["frete"]);
                                venda.Desconto = Convert.ToDouble(reader["desconto"]);
                                venda.Total = Convert.ToDouble(reader["total"]);
                                venda.Cupom = reader["cupom"].ToString();
                                venda.MtdPagto = reader["mtdPagto"].ToString();
                                venda.Entrega = reader["entrega"].ToString();
                                venda.DtVenda = Convert.ToDateTime(reader["dtVenda"]);
                                venda.Usr_id = Convert.ToInt32(reader["usr_id"]);
                                vendas.Add(venda);
                            };
                        
                    }
                    return vendas;
                }
            }
        }
        public List<VendaProdutoEnt> BuscarVendasProdutos()
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do usuario
                string query = "SELECT * FROM Tb_ven_produtos";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    List<VendaProdutoEnt> vendasProdutos = new List<VendaProdutoEnt>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                            while (reader.Read())
                            {
                                VendaProdutoEnt vendaProdutos = new VendaProdutoEnt();                                
                                vendaProdutos.Ven_id = Convert.ToInt32(reader["ven_id"]);
                                vendaProdutos.Pdt_id = Convert.ToInt32(reader["pdt_id"]);                                
                                vendaProdutos.Quant = Convert.ToDouble(reader["quant"]);                                
                                vendasProdutos.Add(vendaProdutos);
                            };
                        
                    }
                    return vendasProdutos;
                }
            }
        }
    }
}

using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.DAO
{
    public class EstoqueDAO
    {
        public string SubtrairEstoque(List<VendaProdutoEnt> produtos)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = @"SELECT quant from Tb_estoque where pdt_id = @pdt_id";

                foreach (VendaProdutoEnt produto in produtos)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@pdt_id", produto.Pdt_id);
                            object result = cmd.ExecuteScalar();

                            // Converte o resultado para o tipo int (ID gerado)
                            double quant = Convert.ToDouble(result);

                            double quantNovo = quant - produto.Quant;

                            string query2 = @"UPDATE Tb_estoque SET quant = @quant WHERE pdt_id = @pdt_id";


                            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                            {
                                try
                                {                                  
                                        cmd2.Parameters.AddWithValue("@pdt_id", produto.Pdt_id);
                                        cmd2.Parameters.AddWithValue("@quant", quantNovo);
                                        cmd2.ExecuteNonQuery();                                   
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Erro: " + ex.ToString());
                                    conn.Close();
                                    return "Erro";
                                }
                            }                                                                                    
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro: " + ex.ToString());
                            conn.Close();
                            return "Erro";
                        }
                       
                    }
                }
                conn.Close();
                return "Sucesso";
            }
        }
        public string AdicionarEstoque(List<ProducaoProdutoEnt> produtos)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = @"SELECT quant from Tb_estoque where pdt_id = @pdt_id";

                foreach (ProducaoProdutoEnt produto in produtos)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@pdt_id", produto.Pdt_id);
                            object result = cmd.ExecuteScalar();

                            // Converte o resultado para o tipo int (ID gerado)
                            double quant = Convert.ToDouble(result);

                            double quantNovo = quant + produto.Quant;

                            string query2 = @"UPDATE Tb_estoque SET quant = @quant WHERE pdt_id = @pdt_id";


                            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                            {
                                try
                                {
                                    cmd2.Parameters.AddWithValue("@pdt_id", produto.Pdt_id);
                                    cmd2.Parameters.AddWithValue("@quant", quantNovo);
                                    cmd2.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Erro: " + ex.ToString());
                                    conn.Close();
                                    return "Erro";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro: " + ex.ToString());
                            conn.Close();
                            return "Erro";
                        }

                    }
                }
                conn.Close();
                return "Sucesso";
            }
        }
    }
}

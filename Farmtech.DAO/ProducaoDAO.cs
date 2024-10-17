using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.DAO
{
    public static class ProducaoDAO
    {
        public static ProducaoEnt CadastrarProducao(ProducaoEnt producao)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = @"INSERT INTO Tb_producao (dataProd) values(@dataProd);SELECT SCOPE_IDENTITY();";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dataProd", producao.DataProd);

                    object result = cmd.ExecuteScalar();

                    // Converte o resultado para o tipo int (ID gerado)
                    int novoId = Convert.ToInt32(result);
                    producao.Id = novoId;
                    if (novoId > 0)
                    {
                        Console.WriteLine("ID gerado: " + novoId);
                        return producao;
                    }
                    conn.Close();
                }
                conn.Close();
                return null;
            }
        }
        public static string CadastrarProdutos(List<ProducaoProdutoEnt> produtos)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = @"INSERT INTO Tb_producao_produtos (pdc_id, pdt_id,quant) values(@pdc_id,@pdt_id,@quant)";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {

                        foreach (ProducaoProdutoEnt produto in produtos)
                        {
                            Console.WriteLine("Produto id: " + produto.Pdt_id);
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@pdc_id", produto.Pdc_id);
                            cmd.Parameters.AddWithValue("@pdt_id", produto.Pdt_id);
                            cmd.Parameters.AddWithValue("@quant", produto.Quant);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                        return "Sucesso";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro: " + ex.ToString());
                        return "Erro";
                    }
                }

            }
        }
    }
}

using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.DAO
{
    public class ProdutoDAO
    {
        public ProdutoEnt Criar(ProdutoEnt produto) {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "INSERT INTO Tb_produto (nome,unMedida,precoUn) VALUES (@nome,@unMedida,@precoUn);SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@unMedida", produto.UnMedida);
                    cmd.Parameters.AddWithValue("@precoUn", produto.PrecoUn);

                    object result = cmd.ExecuteScalar();

                    
                    int novoId = Convert.ToInt32(result);
                    produto.Id = novoId;
                    cmd.Parameters.Clear();
                    sqlconn.Close();

                    return produto;
                }
                catch (Exception ex)
                {
                    return null;                    
                }

            }                        
        }
        public string Excluir(int id)
        {            
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "DELETE FROM Tb_produto WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@id", id); 
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    return "Produto deletado do banco de dados";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de produto" + ex.Message;                    
                }

            }
        }
        public ProdutoEnt BuscarProduto(int id)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = "SELECT * FROM Tb_produto WHERE id = @id";                

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    ProdutoEnt produto = new ProdutoEnt();
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            {
                                produto.Id = Convert.ToInt32(reader["id"]);
                                produto.Nome = reader["nome"].ToString();
                                produto.UnMedida = reader["unMedida"].ToString();
                                produto.PrecoUn = Convert.ToDouble(reader["precoUn"]);
                                
                            };
                            
                        }
                    }
                    return produto;
                }                
            }            
        }
        public List<ProdutoEnt> BuscarProdutos()
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do produto
                string query = "SELECT * FROM Tb_produto";
                using (SqlCommand cmd = new SqlCommand("Select * from Tb_produto", conn))
                {
                    List<ProdutoEnt> produtos = new List<ProdutoEnt>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                                while(reader.Read())
                                {
                                    ProdutoEnt produto = new ProdutoEnt();
                                    produto.Id = Convert.ToInt32(reader["id"]);
                                    produto.Nome = reader["nome"].ToString();
                                    produto.UnMedida = reader["unMedida"].ToString();
                                    produto.PrecoUn = Convert.ToDouble(reader["precoUn"]);
                                    produtos.Add(produto);
                                }
                    }
                    return produtos;
                }               
            }
        }
        public string Atualizar(ProdutoEnt produto)
        {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "UPDATE Tb_produto SET nome = @nome,unMedida = @unMedida,precoUn = @precoUn WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@unMedida", produto.UnMedida);
                    cmd.Parameters.AddWithValue("@precoUn", produto.PrecoUn);                    
                    
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();

                    return "Produto cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de produto " + ex.Message;                   
                }

            }            
        }
    }
}

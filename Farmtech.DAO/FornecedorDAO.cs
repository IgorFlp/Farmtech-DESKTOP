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
    public class FornecedorDAO
    {
        public string Criar(FornecedorEnt fornecedor, FornecedorEnderecoEnt endereco) {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "INSERT INTO Tb_fornecedor (cnpj,nomeFantasia, razaoSocial,telefone,email) VALUES (@cnpj,@nomeFantasia, @razaoSocial,@telefone,@email)";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                    cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                    cmd.Parameters.AddWithValue("@razaoSocial", fornecedor.RazaoSocial);
                    cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                    cmd.Parameters.AddWithValue("@email", fornecedor.Email);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de fornecedor" + ex.Message;                    
                }

            }
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = $"insert into Tb_frn_Endereco (frn_cnpj,rua,bairro,cidade,estado,cep)values (@cnpj,@rua,@bairro,@cidade,@estado,@cep)";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cnpj", endereco.Frn_cnpj);
                    cmd.Parameters.AddWithValue("@rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", endereco.Cep);
                    cmd.ExecuteNonQuery();
                    sqlconn.Close();
                    return "Cadastro completo";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de endereço" + ex.Message;                    
                }
            }            
        }
        public string Excluir(string cnpj)
        {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "DELETE FROM Tb_frn_endereco WHERE frn_cnpj = @cnpj";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    //return "Fornecedor deletado do banco de dados";
                }
                catch (Exception ex)
                {
                    //return "Erro no cadastro de fornecedor" + ex.Message;
                }

            }
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "DELETE FROM Tb_fornecedor WHERE cnpj = @cnpj";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj); 
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    return "Fornecedor deletado do banco de dados";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de fornecedor" + ex.Message;                    
                }

            }
        }
        public FornecedorEnt BuscarFornecedor(String cnpj)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do fornecedor
                string query = "SELECT cnpj, nomeFantasia, razaoSocial, telefone, email FROM Tb_fornecedor WHERE cnpj = @cnpj";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    FornecedorEnt fornecedor = new FornecedorEnt();
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {                            
                            {
                                fornecedor.Cnpj = Convert.ToString(reader["cnpj"]);
                                fornecedor.NomeFantasia = reader["nomeFantasia"].ToString();
                                fornecedor.RazaoSocial = reader["razaoSocial"].ToString();
                                fornecedor.Email = reader["email"].ToString();
                                fornecedor.Telefone = reader["telefone"].ToString();                                
                            };                            
                        }
                    }
                    return fornecedor;
                }                
            }            
        }
        public List<FornecedorEnt> BuscarFornecedores()
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do usuario
                string query = "SELECT * FROM Tb_fornecedor";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    List<FornecedorEnt> fornecedores = new List<FornecedorEnt>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            while (reader.Read())
                            {
                                FornecedorEnt fornecedor = new FornecedorEnt();
                                fornecedor.Cnpj = reader["cnpj"].ToString();
                                fornecedor.NomeFantasia = reader["nomeFantasia"].ToString();
                                fornecedor.RazaoSocial = reader["razaoSocial"].ToString();
                                fornecedor.Telefone = reader["telefone"].ToString();
                                fornecedor.Email = reader["email"].ToString();
                                fornecedores.Add(fornecedor);
                            };
                        }
                    }
                    return fornecedores;
                }
            }
        }
        public FornecedorEnderecoEnt BuscarEndereco(String cnpj)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do fornecedor
                string query = "SELECT frn_cnpj, rua, bairro, cidade, estado, cep FROM Tb_frn_endereco WHERE frn_cnpj = @cnpj";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    FornecedorEnderecoEnt endereco = new FornecedorEnderecoEnt();
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Inicializa o objeto Fornecedor e preenche os atributos diretamente dos dados do banco

                            {
                                endereco.Frn_cnpj = Convert.ToString(reader["frn_cnpj"]);
                                endereco.Rua = reader["rua"].ToString();
                                endereco.Bairro  = reader["bairro"].ToString();
                                endereco.Cidade  = reader["cidade"].ToString();
                                endereco.Estado  = reader["estado"].ToString();
                                endereco.Cep     = reader["cep"].ToString();
                            };

                        }
                    }
                    return endereco;
                }
            }
        }
        public string Atualizar(FornecedorEnt fornecedor, FornecedorEnderecoEnt endereco)
        {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "UPDATE Tb_fornecedor SET nomeFantasia = @nomeFantasia, razaoSocial = @razaoSocial,telefone = @telefone,email = @email WHERE cnpj = @cnpj";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                    cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                    cmd.Parameters.AddWithValue("@razaoSocial", fornecedor.RazaoSocial);
                    cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                    cmd.Parameters.AddWithValue("@email", fornecedor.Email);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();

                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de fornecedor " + ex.Message;                   
                }

            }
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = $"UPDATE Tb_frn_endereco SET rua = @rua,bairro = @bairro,cidade = @cidade,estado = @estado, cep = @cep WHERE frn_cnpj = @cnpj";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cnpj", endereco.Frn_cnpj);
                    cmd.Parameters.AddWithValue("@rua", endereco.Rua);
                    cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", endereco.Cep);
                    cmd.ExecuteNonQuery();
                    sqlconn.Close();
                    return "Cadastro completo";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de endereço " + ex.Message;
                }
            }
        }
    }
}

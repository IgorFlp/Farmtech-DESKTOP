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
    public class ClienteDAO
    {
        public string Criar(ClienteEnt cliente, ClienteEnderecoEnt endereco) {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "INSERT INTO Tb_cliente (cpf,nome,telefone,email,dataNasc,genero) VALUES (@cpf,@nome,@telefone,@email,@dataNasc,@genero)";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cpf", cliente.Cpf); // Criar validação ainda
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@dataNasc", cliente.DataNasc);
                    cmd.Parameters.AddWithValue("@genero", cliente.Genero);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de cliente" + ex.Message;
                    Console.WriteLine("Erro: " + ex.Message);
                }

            }
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = $"insert into Tb_cl_Endereco (cl_cpf,rua,bairro,cidade,estado,cep)values (@cpf,@rua,@bairro,@cidade,@estado,@cep)";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cpf", endereco.ClCpf);
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
        public string Excluir(string cpf)
        {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "DELETE FROM Tb_cl_endereco WHERE cl_cpf = @cpf";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    //return "Cliente deletado do banco de dados";
                }
                catch (Exception ex)
                {
                    //return "Erro no cadastro de cliente" + ex.Message;
                }

            }
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "DELETE FROM Tb_cliente WHERE cpf = @cpf";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cpf", cpf); 
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    return "Cliente deletado do banco de dados";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de cliente" + ex.Message;                    
                }

            }
        }
        public ClienteEnt BuscarCliente(String cpf)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do cliente
                string query = "SELECT cpf, nome, telefone, email, dataNasc, genero FROM Tb_cliente WHERE cpf = @cpf";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    ClienteEnt cliente = new ClienteEnt();
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Inicializa o objeto Cliente e preenche os atributos diretamente dos dados do banco
                            
                            {
                                cliente.Cpf = Convert.ToString(reader["cpf"]);
                                cliente.Nome = reader["nome"].ToString();
                                cliente.Email = reader["email"].ToString();
                                cliente.Telefone = reader["telefone"].ToString();
                                cliente.DataNasc = Convert.ToDateTime(reader["dataNasc"]);
                                cliente.Genero = Convert.ToChar(reader["genero"]);
                            };
                            
                        }
                    }
                    return cliente;
                }                
            }            
        }
        public List<ClienteEnt> BuscarClientes()
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do usuario
                string query = "SELECT * FROM Tb_cliente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    List<ClienteEnt> clientes = new List<ClienteEnt>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            while (reader.Read())
                            {
                                ClienteEnt cliente = new ClienteEnt();
                                cliente.Cpf = reader["cpf"].ToString();
                                cliente.Nome = reader["nome"].ToString();
                                cliente.DataNasc = Convert.ToDateTime(reader["dataNasc"]);
                                cliente.Genero = Convert.ToChar(reader["genero"]);
                                cliente.Telefone = reader["telefone"].ToString();
                                cliente.Email = reader["email"].ToString();
                                clientes.Add(cliente);
                            };
                        }
                    }
                    return clientes;
                }
            }
        }
        public ClienteEnderecoEnt BuscarEndereco(String cpf)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do cliente
                string query = "SELECT cl_cpf, rua, bairro, cidade, estado, cep FROM Tb_cl_endereco WHERE cl_cpf = @cpf";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    ClienteEnderecoEnt endereco = new ClienteEnderecoEnt();
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Inicializa o objeto Cliente e preenche os atributos diretamente dos dados do banco

                            {
                                endereco.ClCpf = Convert.ToString(reader["cl_cpf"]);
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
        public string Atualizar(ClienteEnt cliente, ClienteEnderecoEnt endereco)
        {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "UPDATE Tb_cliente SET nome = @nome,telefone = @telefone,email = @email,dataNasc = @dataNasc,genero = @genero WHERE cpf = @cpf";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@dataNasc", cliente.DataNasc);
                    cmd.Parameters.AddWithValue("@genero", cliente.Genero);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();

                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de cliente " + ex.Message;                   
                }

            }
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = $"UPDATE Tb_cl_endereco SET rua = @rua,bairro = @bairro,cidade = @cidade,estado = @estado, cep = @cep WHERE cl_cpf = @cpf";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@cpf", endereco.ClCpf);
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

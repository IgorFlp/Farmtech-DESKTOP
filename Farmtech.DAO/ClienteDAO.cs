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
        public string Criar(ClientEnt cliente, EnderecoEnt endereco) {
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
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }            
        }
    }
}

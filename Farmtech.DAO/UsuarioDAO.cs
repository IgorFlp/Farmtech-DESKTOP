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
    public class UsuarioDAO
    {
        public string Criar(UsuarioEnt usuario) {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "INSERT INTO Tb_usuario (login,senha,cargo,nome) VALUES (@login,@senha,@cargo,@nome)";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@login", usuario.Login); 
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();

                    return "Usuario cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de usuario " + ex.Message;                    
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
                    string query = "DELETE FROM Tb_usuario WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@id", id); 
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();
                    return "Usuario deletado do banco de dados";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de usuario" + ex.Message;                    
                }

            }
        }
        public UsuarioEnt BuscarUsuario(int id)
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do usuario
                string query = "SELECT id, login, senha, cargo, nome FROM Tb_usuario WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    UsuarioEnt usuario = new UsuarioEnt();
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            {
                                usuario.Id = Convert.ToInt32(reader["id"]);
                                usuario.Nome = reader["nome"].ToString();
                                usuario.Login = reader["login"].ToString();
                                usuario.Senha = reader["senha"].ToString();
                                usuario.Cargo = reader["cargo"].ToString();
                            };
                            
                        }
                    }
                    return usuario;
                }                
            }            
        }
        public List<UsuarioEnt> BuscarUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(configBanco.connectionString))
            {
                conn.Open();

                // Consulta para buscar os dados do usuario
                string query = "SELECT * FROM Tb_usuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    List<UsuarioEnt> usuarios = new List<UsuarioEnt>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            while(reader.Read())
                            {
                                UsuarioEnt usuario = new UsuarioEnt();  
                                usuario.Id = Convert.ToInt32(reader["id"]);
                                usuario.Nome = reader["nome"].ToString();
                                usuario.Login = reader["login"].ToString();
                                usuario.Senha = reader["senha"].ToString();
                                usuario.Cargo = reader["cargo"].ToString();
                                usuarios.Add(usuario);
                            };

                        }
                    }
                    return usuarios;
                }
            }
        }
        public string Atualizar(UsuarioEnt usuario)
        {
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                try
                {
                    sqlconn.Open();
                    string query = "UPDATE Tb_usuario SET nome = @nome,login = @login,senha = @senha,cargo = @cargo WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlconn);
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@login", usuario.Login);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    sqlconn.Close();

                    return "Usuario cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    return "Erro no cadastro de usuario " + ex.Message;                   
                }

            }            
        }
    }
}

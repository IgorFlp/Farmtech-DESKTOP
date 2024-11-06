using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Farmtech.DAO
{   
    public static class configBanco
    {        
        public static string connectionString = "Server=.;Database=Db_Farmtech;User Id=farmtech;Password=123456789";
        //String pra conectar no banco de dados ^ não alterar, usar dentro do SqlConnection(configBanco.connectionString)
    }
    
    public class LoginDAO
    {
        
        public static UsuarioEnt Logar(UsuarioEnt usuario)
        {                    
           
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                sqlconn.Open();                                           
                string query = "SELECT * FROM Db_farmtech.dbo.Tb_usuario WHERE login = @Login";
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login", usuario.Login);                
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    UsuarioEnt u = new UsuarioEnt();
                    u.Nome = leitor["nome"].ToString();
                    u.Senha = leitor["senha"].ToString();
                    u.Cargo = leitor["cargo"].ToString();
                    u.Login = leitor["login"].ToString();
                    u.Id = Convert.ToInt32(leitor["id"]);

                    // Verificar se o password fornecido corresponde ao password do usuário
                    if (usuario.Senha == u.Senha)
                    {                        
                        Console.WriteLine($"Login bem-sucedido para o usuário '{u.Nome}'.");
                        leitor.Close();
                        sqlconn.Close();
                        return u;
                    }
                    else
                    {                                              
                                                
                        {
                            leitor.Close();
                            sqlconn.Close();
                            return null;                             
                        }
                        
                    }
                    
                }
                else
                {
                    leitor.Close();
                    sqlconn.Close();
                    return null;
                    
                }                

            }
        }
            //Criar leitura no banco de dados e retornar Correto ou incorreto
            //Depois que criar pode apagar essa parte de baixo VV           
        
    }
}

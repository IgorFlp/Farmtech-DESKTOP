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
        public static string connectionString { get; } = "Server=.;Database=Db_Farmtech;User Id=farmtech;Password=123456789";
        //String pra conectar no banco de dados ^ não alterar, usar dentro do SqlConnection(configBanco.connectionString)
    }
    
    public class LoginDAO
    {
        
        public static string Logar(LoginEnt usuario)
        {                    
           
            using (SqlConnection sqlconn = new SqlConnection(configBanco.connectionString))
            {
                sqlconn.Open();                                           
                string query = "SELECT nome, senha FROM Db_farmtech.dbo.Tb_usuario WHERE nome = @Nome";
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nome", usuario.Login);                
                SqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    string nomeUsuario = leitor["nome"].ToString();
                    string senhaUsuario = leitor["senha"].ToString();

                    // Verificar se o password fornecido corresponde ao password do usuário
                    if (usuario.Senha == senhaUsuario)
                    {
                        Console.WriteLine($"Login bem-sucedido para o usuário '{nomeUsuario}'.");
                        leitor.Close();
                        sqlconn.Close();
                        return "Correto";
                    }
                    else
                    {                                              
                                                
                        {
                            leitor.Close();
                            sqlconn.Close();
                            return "Incorreto";                             
                        }
                        
                    }
                    
                }
                else
                {
                    leitor.Close();
                    sqlconn.Close();
                    return "Incorreto";
                    
                }
                

            }
        }
            //Criar leitura no banco de dados e retornar Correto ou incorreto
            //Depois que criar pode apagar essa parte de baixo VV           
        
    }
}

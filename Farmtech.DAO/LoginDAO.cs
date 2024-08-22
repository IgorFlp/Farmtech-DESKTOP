using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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
        
        public static string Logar(UsuarioEnt usuario)
        {                     
            //Criar leitura no banco de dados e retornar Correto ou incorreto
            //Depois que criar pode apagar essa parte de baixo VV
            if (usuario.Nome == "Jorge" && usuario.Senha == "123")
            {
                return "Correto";
            }
            else
            {
                return "Incorreto";
            }
        }
    }
}

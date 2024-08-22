using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmtech.DAO
{
    public class LoginDAO
    {       
        
        public static string Logar(UsuarioEnt usuario)
        {
            //Criar leitura no banco de dados e retornar Correto ou incorreto
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

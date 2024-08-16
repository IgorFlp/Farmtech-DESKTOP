using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Farmtech.DAO
{
    public class UsuarioDAO
    {
        //Cad usuario CRIA, DELETA, ALTERA, OU VISUALIZA Tb_Usuario
        public void CriaUsuario(UsuarioEnt usuario) { }
        //{
        //    string queryString = "INSERT INTO dbo.Usuario(nome, usuario, senha) VALUES(@nome, @usuario, @senha))";
        //    using(SqlConnection connection = new SqlConnection(connectionString)){                
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(queryString, connection))
        //            command.Parameters.AddWithValue('@nome', objeto.Nome);
        //            command.Parameters.AddWithValue('@nome', objeto.usuario);
        //            command.Parameters.AddWithValue('@nome', objeto.senha);                
        //            command.ExecuteNonQuery();
        //    }
        //}
        //Login VISUALIZA existencia do usuario e retorna erro ou efetua login
        public static string LoginDAO(UsuarioEnt usuario)
        {
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

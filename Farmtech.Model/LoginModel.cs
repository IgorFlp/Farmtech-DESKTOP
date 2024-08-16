using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Farmtech.Controller;
using Farmtech.Entidades;



namespace Farmtech.Model
{

    public class LoginModel
    {
        public static event Action<string> resultLogin;
        public static void logar(string nome, string senha)
        {
            UsuarioEnt usuario = new UsuarioEnt();
            LoginCtr loginCtr = new LoginCtr();
            usuario.Nome = nome;
            usuario.Senha = senha;
            string res = loginCtr.Logar(usuario);
            resultLogin?.Invoke(res);
        }
    }
}
            
        
    


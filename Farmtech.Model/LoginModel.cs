using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Farmtech.DAO;
using Farmtech.Entidades;



namespace Farmtech.Model
{

    public class LoginModel
    {
        public static event Action<string> resultLogin;
        public static string logar(UsuarioEnt usuario)
        {
            string res = LoginDAO.Logar(usuario);
            return res;
        }
    }
}
            
        
    


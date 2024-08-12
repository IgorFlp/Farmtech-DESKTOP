using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Farmtech_DESKTOP.Login;

namespace Farmtech_DESKTOP
{
    internal class Model
    {
        public static Login LoginModel(string user, string senha) {
            string res = UsuariosDAO.LoginDAO(user, senha);
            Login login = new Login();
            if (res != "Correto")
            {
                login.lblAvisoGs.ForeColor = Color.Red;
                login.lblAvisoGs.Text = "Usuario ou senha incorreto tente novamente";
                return login;
                
                
            }
            else
            {
                login.ForeColor = Color.Black;
                login.Text = "Efetuando login...";
                return login;

            }          
        }
    }
}

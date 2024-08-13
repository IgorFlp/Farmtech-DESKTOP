using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;
using static Farmtech_DESKTOP.Login;
using static Farmtech_DESKTOP.GenericTimer;

namespace Farmtech_DESKTOP
{
    
    internal class Model
    {
        
        public static async void LoginModel(Login loginform,string user, string senha) {
            
            string res = UsuariosDAO.LoginDAO(user, senha);
            Login login = new Login();
            if (res != "Correto")
            {
                
                loginform.lblAvisoGs.ForeColor = Color.Red;
                loginform.lblAvisoGs.Text = "Usuario ou senha incorreto tente novamente";
                //loginform.lblAvisoGs.Text = string.Empty;

                


            }
            else
            {
                loginform.lblAvisoGs.ForeColor = Color.Black;
                loginform.lblAvisoGs.Text = "Efetuando login...";
                
            }          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using Farmtech.View;

namespace Farmtech.View
{
    
    internal class AbrirForm
    {       
        
        public static void abrirForm(string menu)
        {
            switch (menu) {
                case "Home":
                    var home = new Inicio();
                    home.Show();
                    break;
                case "Usuario":
                    var usuario = new Usuario();
                    usuario.Show();
                    break;                 
            }
        }
    }
}

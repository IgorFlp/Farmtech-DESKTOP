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
                    var home = new Home();
                    home.Show();
                    break;
                case "Usuario":
                    var usuario = new Usuario();
                    usuario.Show();
                    break; 
                case "Usuario_Incluir":
                    var usuarioIncluir = new Usuario_Incluir();
                    Console.WriteLine("usuario_incluir ativou");
                    usuarioIncluir.Show();
                    break;
            }
        }
    }
}

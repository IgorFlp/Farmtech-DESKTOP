using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Controller
{
    public class LoginCtr
    {
        private UsuarioDAO usuarioDAO;

        public LoginCtr()
        {
            usuarioDAO = new UsuarioDAO();
        }
        public string Logar(UsuarioEnt usuario)
        {
            return UsuarioDAO.LoginDAO(usuario);
        }
    }
}

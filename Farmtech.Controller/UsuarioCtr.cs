using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Controller
{
    public class UsuarioCtr
    {
        private LoginDAO usuarioDAO;

        public UsuarioCtr()
        {
            usuarioDAO = new LoginDAO();
        }
        public void CriaUsuario(UsuarioEnt usuario)
        {
            usuarioDAO.CriaUsuario(usuario);
        }
    }
}

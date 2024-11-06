using Farmtech.DAO;
using Farmtech.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmtech.Model
{
    public class UsuarioModel
    {
        public string Criar(UsuarioEnt usuario)
        {            
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                string res = usuarioDAO.Criar(usuario);
                return res;
            
        }
        public string Excluir(int id)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string res = usuarioDAO.Excluir(id);
            return res;
        }
        public UsuarioEnt BuscarUsuario(int id)
        {
            UsuarioEnt usuarioEnt = new UsuarioEnt();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioEnt = usuarioDAO.BuscarUsuario(id);
            return usuarioEnt;
        }
        
        public List<UsuarioEnt> BuscarUsuarios()
        {
            List<UsuarioEnt> usuarios = new List<UsuarioEnt>();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarios = usuarioDAO.BuscarUsuarios();
            return usuarios;
        }

        public string Atualizar(UsuarioEnt usuarioEnt)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            String res = usuarioDAO.Atualizar(usuarioEnt);
            return res;
        }
    }
}

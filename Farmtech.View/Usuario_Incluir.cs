using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmtech.View.UsuariosDAO

namespace Farmtech.View
{
    public partial class Usuario_Incluir : Form
    {
        public Usuario_Incluir()
        {
            InitializeComponent();
        }

        
        private void btnCriar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            UsuariosDAO.criaUsuario(usuario);
        }
    }
}

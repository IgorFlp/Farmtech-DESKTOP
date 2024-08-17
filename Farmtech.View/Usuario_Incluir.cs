using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmtech.Model;



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
            UsuarioModel model = new UsuarioModel();
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string nome = txtNome.Text;
            string cargo = boxCargo.Text;
            model.CriaUsuario(login,senha,nome,cargo);
        }                   
    }
}

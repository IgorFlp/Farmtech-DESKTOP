using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmtech.Entidades;
using Farmtech.Model;




namespace Farmtech.View
{
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }     
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
           UsuarioEnt usuario = new UsuarioEnt();
           usuario.Login = inputUser.Text;
           usuario.Senha = inputSenha.Text;
           UsuarioEnt response = new UsuarioEnt();
           response = LoginModel.logar(usuario); 
           attLogin(response);
        }

        private void attLogin(UsuarioEnt response)
        {
            if (response == null)
            {
                lblAvisoGs.ForeColor = Color.Red;
                lblAvisoGs.Text = "Usuario ou senha incorreto";
                //loginform.lblAvisoGs.Text = string.Empty;
            }
            else
                {
                    lblAvisoGs.ForeColor = Color.Black;
                    lblAvisoGs.Text = "Efetuando login...";
                //Thread.Sleep(1000);
                Farmtech_DESKTOP.Properties.Settings.Default.UsuarioNome = response.Nome;
                Farmtech_DESKTOP.Properties.Settings.Default.UsuarioId = response.Id;
                Farmtech_DESKTOP.Properties.Settings.Default.Save();
                this.Hide();
                    //1-Home
                    AbrirForm.abrirForm("Home");

                }
            }
    }
}

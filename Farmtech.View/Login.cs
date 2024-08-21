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
           string res = LoginModel.logar(usuario); 
           attLogin(res);
        }

        private void attLogin(string res)
        {
            if (res != "Correto")
            {
                lblAvisoGs.ForeColor = Color.Red;
                lblAvisoGs.Text = "Usuario ou senha incorreto tente novamente";
                //loginform.lblAvisoGs.Text = string.Empty;
            }
            else
                {
                    lblAvisoGs.ForeColor = Color.Black;
                    lblAvisoGs.Text = "Efetuando login...";
                    //Thread.Sleep(1000);
                    this.Hide();
                    //1-Home
                    AbrirFormModel.abrirForm("Home");

                }
            }
    }
}

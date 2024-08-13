using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;




namespace Farmtech_DESKTOP
{
    
    public partial class Login : Form
    {
        public System.Windows.Forms.Timer timer;
        public Login()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Model.LoginModel(this,inputUser.Text, inputSenha.Text);            
        }

        private void inputUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

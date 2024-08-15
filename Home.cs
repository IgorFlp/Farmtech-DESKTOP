using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmtech.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {   
            //2 = Usuario.cs
            AbrirFormModel.abrirForm("Usuario");
        }
    }
}

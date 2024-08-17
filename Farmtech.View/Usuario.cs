using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmtech.View
{
    public partial class Usuario : Form
    {
        private string nome;
        private string login;
        private string senha;
        public string Nome {get{ return this.nome; }set{ this.nome = value; } }
        public string Login { get{ return this.login;} set{ this.nome = value;} }
        public string Senha { get { return this.senha; } set { this.senha = value; } }
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //3 -Usuario novo
            AbrirForm.abrirForm("Usuario_Incluir");
        }
    }
}

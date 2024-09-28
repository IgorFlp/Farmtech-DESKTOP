using Farmtech.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmtech_DESKTOP
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.db_FarmtechDataSet.Tb_cliente);


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ClienteNovo clienteNovo = new ClienteNovo();
            clienteNovo.Show();
        }
    }
}

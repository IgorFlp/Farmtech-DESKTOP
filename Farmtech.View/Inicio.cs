using Farmtech_DESKTOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Farmtech.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }    

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();

        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Show();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            Producao producao = new Producao();
            producao.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using Farmtech.Entidades;
using Farmtech.Model;

namespace Farmtech.View
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }
        String tipo;
        int produtoId;

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            produtoId = 0;
            tipo = "Novo";
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.db_FarmtechDataSet.Tb_produto);
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_produtoTableAdapter.Fill(this.db_FarmtechDataSet.Tb_produto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
        private void habilitarCampos()
        {
            txtNome.Enabled = true;            
            txtPreco.Enabled = true;
            cbUnidade.Enabled = true;
            btnSalvar.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;           
            txtPreco.Enabled = false;
            cbUnidade.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void limparCampos()
        {
            txtNome.Text = "";            
            txtPreco.Text = "";
            cbUnidade.Text = "";    
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridProdutos.SelectedRows[0];

                int produtoId = Convert.ToInt32(linhaSelecionada.Cells[3].Value);

                ProdutoModel produtoModel = new ProdutoModel();
                string res = produtoModel.Excluir(produtoId);

                this.Hide();
                Form novoForm = new Produto();
                novoForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Selecione um produto para deletar.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutoEnt produto = new ProdutoEnt();
            habilitarCampos();
            if (dataGridProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridProdutos.SelectedRows[0];

                produtoId = Convert.ToInt32(linhaSelecionada.Cells[3].Value);

                ProdutoModel produtoModel = new ProdutoModel();
                produto = produtoModel.BuscarProduto(produtoId);
                
                txtNome.Text = produto.Nome;
                txtPreco.Text = produto.PrecoUn.ToString();                
                cbUnidade.SelectedText = produto.UnMedida;

                
                tipo = "Alterar";                
            }
            else
            {
                MessageBox.Show("Selecione um produto para deletar.");
               
                this.Hide();
                Form novoForm = new Produto();
                novoForm.ShowDialog();
                this.Close();
            }
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoModel produtoModel = new ProdutoModel();
            ProdutoEnt produto = new ProdutoEnt();
            if (txtNome.Text != String.Empty &&
                txtPreco.Text != String.Empty &&
                cbUnidade.Text != String.Empty&& Convert.ToDecimal(cbUnidade.Text) > 0)
            {
                produto.PrecoUn = Convert.ToDouble(txtPreco.Text);
                produto.UnMedida = cbUnidade.Text;
                produto.Nome = txtNome.Text;
                if (tipo == "Novo")
                {
                    produtoModel.Criar(produto);

                }
                else if (tipo == "Alterar")
                {
                    produto.Id = produtoId;
                    produtoModel.Atualizar(produto);

                }
                limparCampos();
                desabilitarCampos();

                this.Hide();
                Form novoForm = new Produto();
                novoForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form novoForm = new Produto();
            novoForm.ShowDialog(); 
            this.Close();
        }
    }
}

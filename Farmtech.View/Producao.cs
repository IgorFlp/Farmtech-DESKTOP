using Farmtech.Entidades;
using Farmtech.Model;
using Farmtech.View;
using Farmtech_DESKTOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Producao : Form
    {
        List<ProdutoEnt> produtos = new List<ProdutoEnt>();
        public Producao()
        {
            InitializeComponent();
        }    
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            gbAddProd.Enabled = true;
        }               

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            int id = 0;
            string nome = "nome";
            string unidade = "Ts";
            double quant;
            row.CreateCells(tabelaProducao);
            row.Cells[0].Value = cbProduto.SelectedValue;
            row.Cells[1].Value = cbProduto.Text;
            foreach (ProdutoEnt produto in produtos)
            {
                if (produto.Id == Convert.ToInt32(cbProduto.SelectedValue))
                {
                    id = produto.Id;
                    nome = produto.Nome;
                    unidade = produto.UnMedida;
                }
            }
            quant = Convert.ToDouble(txtQuant.Value);

            row.Cells[0].Value = id;
            row.Cells[1].Value = nome;
            row.Cells[2].Value = unidade;
            row.Cells[3].Value = quant.ToString("F2");
            
            tabelaProducao.Rows.Add(row);

            cbProduto.SelectedIndex = 0;
            txtQuant.Value = 0;
            gbAddProd.Enabled = false;
        }

        private void Producao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.db_FarmtechDataSet.Tb_cliente);
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.db_FarmtechDataSet.Tb_produto);
            ProdutoModel produtoModel = new ProdutoModel();
            produtos = produtoModel.BuscarProdutos();

            lblUsuario.Text = Farmtech_DESKTOP.Properties.Settings.Default.UsuarioNome;
            lblUsuario.Tag = Farmtech_DESKTOP.Properties.Settings.Default.UsuarioId;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabelaProducao.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = tabelaProducao.SelectedRows[0];

                tabelaProducao.Rows.RemoveAt(linhaSelecionada.Index);
            }
            else
            {
                MessageBox.Show("Selecione um cliente para deletar.");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ProducaoEnt producaoEnt = new ProducaoEnt();
            producaoEnt.DataProd = DateTime.Now;

            producaoEnt = ProducaoModel.CadastrarProducao(producaoEnt);

            List<ProducaoProdutoEnt> produtos = new List<ProducaoProdutoEnt>();
            for (int i = 0; i < tabelaProducao.RowCount; i++)
            {
                ProducaoProdutoEnt produto = new ProducaoProdutoEnt();
                produto.Pdc_id = producaoEnt.Id;
                produto.Quant = Convert.ToDouble(tabelaProducao.Rows[i].Cells[3].Value.ToString().Replace("R$ ", ""));
                produto.Pdt_id = Convert.ToInt32(tabelaProducao.Rows[i].Cells[0].Value.ToString().Replace("R$ ", ""));
                produtos.Add(produto);
            }
            string produtoRes = ProducaoModel.CadastrarProdutos(produtos);
            if (producaoEnt.Id > 0 && produtoRes == "Sucesso")
            {
                DialogResult dr = MessageBox.Show("Producao cadastrada com sucesso.");
                if(dr == DialogResult.OK)
                {
                    this.Hide();
                    Form novoForm = new Producao();
                    novoForm.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Erro no cadastro da producao.");
            }

            string json = JsonConvert.SerializeObject(producaoEnt);
            string json2 = JsonConvert.SerializeObject(produtos);
            Console.WriteLine("Producao: " + json + "Produtos: " + json2);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
               
    }
    // private void label1_Click(object sender, EventArgs e)
    // {

    // }

    //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    //{

    // }

    // private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    // {

    //}

    // private void label2_Click(object sender, EventArgs e)
    //{

    // }
}

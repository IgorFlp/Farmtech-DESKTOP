using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmtech.Entidades;
using Farmtech.Model;
using Farmtech_DESKTOP;
using Newtonsoft.Json;
using WinFormsApp1;

namespace Farmtech.View
{
    public partial class Vendas : Form
    {
        List<ProdutoEnt> produtos = new List<ProdutoEnt>();
        public Vendas()
        {
            InitializeComponent();

            tabelaVenda.RowsAdded += new DataGridViewRowsAddedEventHandler(atualizarSubtotal);
            tabelaVenda.RowsRemoved += new DataGridViewRowsRemovedEventHandler(atualizarSubtotal);
            slcEntrega.SelectedIndexChanged += new EventHandler(atualizarFrete);
            txtCupom.KeyPress += new KeyPressEventHandler(atualizarDesconto);
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            gbAddProd.Enabled = true;
            cbProduto.Enabled = true;
            txtQuant.Enabled = true;
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.db_FarmtechDataSet.Tb_produto);
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.db_FarmtechDataSet.Tb_cliente);

            ProdutoModel produtoModel = new ProdutoModel();
            produtos = produtoModel.BuscarProdutos();

            lblUsuario.Text = Farmtech_DESKTOP.Properties.Settings.Default.UsuarioNome;
            lblUsuario.Tag = Farmtech_DESKTOP.Properties.Settings.Default.UsuarioId;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            double precoUn = 0d;
            double precoTotal;
            double quant;
            row.CreateCells(tabelaVenda);
            row.Cells[0].Value = cbProduto.SelectedValue;
            row.Cells[1].Value = cbProduto.Text;
            foreach (ProdutoEnt produto in produtos)
            {
                if (produto.Id == Convert.ToInt32(cbProduto.SelectedValue))
                {
                    precoUn = produto.PrecoUn;
                }
            }
            quant = Convert.ToDouble(txtQuant.Value);
            precoTotal = precoUn * quant;

            row.Cells[2].Value = precoUn.ToString("C2");
            row.Cells[3].Value = quant.ToString("F2");
            row.Cells[4].Value = precoTotal.ToString("C2");
            tabelaVenda.Rows.Add(row);

            cbProduto.SelectedIndex = 0;
            txtQuant.Value = 0;
            gbAddProd.Enabled = false;

        }

        private void tabelaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabelaVenda.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = tabelaVenda.SelectedRows[0];

                tabelaVenda.Rows.RemoveAt(linhaSelecionada.Index);


            }
            else
            {
                MessageBox.Show("Selecione um cliente para deletar.");
            }
        }

        private void atualizarSubtotal(object sender, EventArgs e)
        {
            double subtotal = 0;
            for (int i = 0; i < tabelaVenda.RowCount; i++)
            {
                subtotal = Convert.ToDouble(tabelaVenda.Rows[i].Cells[4].Value.ToString().Replace("R$ ","")) + subtotal;
            }
            lblSubtotal.Text = subtotal.ToString("C2");
            atualizarTotal();
        }
        private void atualizarTotal()
        {            
            double subtotal = Convert.ToDouble(lblSubtotal.Text.Replace("R$ ",""));
            double frete = Convert.ToDouble(lblFrete.Text.Replace("R$ ", ""));
            double desconto = Convert.ToDouble(lblDesconto.Text.Replace("R$ ", ""));
            double total = 0;
            total = subtotal + frete - desconto;
            lblTotal.Text = total.ToString("C2");
        }
        private void atualizarFrete(object sender, EventArgs e)
        {
            if (slcEntrega.Text == "Entrega")
            {
                lblFrete.Text = "R$ 25,00";                
            }
            else
            {
                lblFrete.Text = "R$ 00,00";                
            }
            atualizarTotal();
        }
        private void atualizarDesconto(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                VendasModel vendasModel = new VendasModel();
                CupomEnt cupomEnt = new CupomEnt();
                cupomEnt = vendasModel.consultarCupom(txtCupom.Text);
                if (cupomEnt != null)
                {
                    DateTime hoje = DateTime.Now;
                    if (cupomEnt.DtValid.CompareTo(hoje) >= 0)
                    {
                        lblDesconto.Text = cupomEnt.Valor.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Cupom fora da validade");
                    }

                }
                else {
                    MessageBox.Show("Cupom não existe");
                }
                
            }
        }

        private void btnCupom_Click(object sender, EventArgs e)
        {
            VendasModel vendasModel = new VendasModel();
            CupomEnt cupomEnt = new CupomEnt();
            cupomEnt = vendasModel.consultarCupom(txtCupom.Text);
            if (cupomEnt != null)
            {
                DateTime hoje = DateTime.Now;
                if (cupomEnt.DtValid.CompareTo(hoje) >= 0)
                {
                    lblDesconto.Text = cupomEnt.Valor.ToString("C2");
                    MessageBox.Show("Desconto aplicado");
                }
                else
                {
                    lblDesconto.Text = "R$ 00,00";
                    MessageBox.Show("Cupom fora da validade");
                }

            }
            else
            {
                lblDesconto.Text = "R$ 00,00";
                MessageBox.Show("Cupom não existe");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            VendaEnt vendaEnt = new VendaEnt();
            vendaEnt.Cl_cpf = slcCliente.SelectedValue.ToString();
            vendaEnt.Subtotal = Convert.ToDouble(lblSubtotal.Text.Replace("R$ ",""));
            vendaEnt.Frete = Convert.ToDouble(lblFrete.Text.Replace("R$ ",""));
            vendaEnt.Desconto = Convert.ToDouble(lblDesconto.Text.Replace("R$ ",""));
            vendaEnt.Total = Convert.ToDouble(lblTotal.Text.Replace("R$ ",""));
            vendaEnt.Cupom = txtCupom.Text;
            vendaEnt.MtdPagto = slcPagto.Text;
            vendaEnt.Entrega = slcEntrega.Text;
            vendaEnt.Usr_id = Convert.ToInt32(lblUsuario.Tag);
            vendaEnt.DtVenda = DateTime.Now;

            VendasModel vendaModel = new VendasModel();
            vendaEnt = vendaModel.CadastrarVenda(vendaEnt);


            List<VendaProdutoEnt> produtos = new List<VendaProdutoEnt>();
            for(int i = 0;i < tabelaVenda.RowCount;i++)
            {
                VendaProdutoEnt produto = new VendaProdutoEnt();
                produto.Ven_id = vendaEnt.Id;
                produto.Quant = Convert.ToDouble(tabelaVenda.Rows[i].Cells[3].Value.ToString().Replace("R$ ", ""));
                produto.Pdt_id = Convert.ToInt32(tabelaVenda.Rows[i].Cells[0].Value.ToString().Replace("R$ ", ""));
                produtos.Add(produto);
            }
            string produtoRes = vendaModel.CadastrarProdutos(produtos);
            if (vendaEnt.Id > 0 && produtoRes == "Sucesso")
            {
                DialogResult dr = MessageBox.Show("Venda cadastrada com sucesso.");
                if (dr == DialogResult.OK)
                {
                    this.Hide();
                    Form novoForm = new Vendas();
                    novoForm.ShowDialog();
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Erro no cadastro da venda.");
            }
            

            string json = JsonConvert.SerializeObject(vendaEnt);
            string json2 = JsonConvert.SerializeObject(produtos);
            Console.WriteLine("Venda: "+json + "Produtos: "+json2);



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

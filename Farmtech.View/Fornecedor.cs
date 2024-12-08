using Farmtech.Entidades;
using Farmtech.Model;
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
using Newtonsoft.Json;

namespace Farmtech_DESKTOP
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.db_FarmtechDataSet.Tb_fornecedor);


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FornecedorNovo fornecedorNovo = new FornecedorNovo();
            this.Hide();
            this.Close();
            fornecedorNovo.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (dataGridFornecedores.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridFornecedores.SelectedRows[0];

                String fornecedorCnpj = Convert.ToString(linhaSelecionada.Cells[0].Value);
                
                FornecedorModel fornecedorModel = new FornecedorModel();
                string res = fornecedorModel.Excluir(fornecedorCnpj);

                this.Hide();
                Form novoForm = new Fornecedor();
                novoForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para deletar.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridFornecedores.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridFornecedores.SelectedRows[0];

                String fornecedorCnpj = Convert.ToString(linhaSelecionada.Cells[0].Value);

                FornecedorModel fornecedorModel = new FornecedorModel();

                FornecedorEnt fornecedorEnt = new FornecedorEnt();
                FornecedorEnderecoEnt enderecoEnt = new FornecedorEnderecoEnt();

               fornecedorEnt = fornecedorModel.BuscarFornecedor(fornecedorCnpj);
               enderecoEnt = fornecedorModel.BuscarEndereco(fornecedorCnpj);
               string json = JsonConvert.SerializeObject(fornecedorEnt);
               string json2 = JsonConvert.SerializeObject(enderecoEnt);
               Console.WriteLine("Fornecedor: "+json+"Endereco: "+json2);
               FornecedorAlterar fornecedorAlterar = new FornecedorAlterar(fornecedorEnt,enderecoEnt);

               this.Hide();
               this.Close();

               fornecedorAlterar.Show();
                

            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para Alterar.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form novoForm = new Fornecedor();
            novoForm.ShowDialog();
            this.Close();
        }
        
    }
}

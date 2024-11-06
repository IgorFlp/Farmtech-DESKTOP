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

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridClientes.SelectedRows[0];

                String clienteCpf = Convert.ToString(linhaSelecionada.Cells[0].Value);
                
                ClienteModel clienteModel = new ClienteModel();
                string res = clienteModel.Excluir(clienteCpf);

                this.Hide();
                Form novoForm = new Cliente();
                novoForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para deletar.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridClientes.SelectedRows[0];

                String clienteCpf = Convert.ToString(linhaSelecionada.Cells[0].Value);

                ClienteModel clienteModel = new ClienteModel();

                ClienteEnt clienteEnt = new ClienteEnt();
                ClienteEnderecoEnt enderecoEnt = new ClienteEnderecoEnt();

               clienteEnt = clienteModel.BuscarCliente(clienteCpf);
               enderecoEnt = clienteModel.BuscarEndereco(clienteCpf);
               //string json = JsonConvert.SerializeObject(clienteEnt);
               //string json2 = JsonConvert.SerializeObject(enderecoEnt);
               //MessageBox.Show("Cliente: "+json+"Endereco: "+json2);
               ClienteAlterar clienteAlterar = new ClienteAlterar(clienteEnt,enderecoEnt);
               clienteAlterar.Show();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para Alterar.");
            }
        }
    }
}

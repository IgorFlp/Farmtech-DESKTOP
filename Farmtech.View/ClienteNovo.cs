using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmtech.Entidades;
using Farmtech.Model;
using Farmtech_DESKTOP;
using Newtonsoft.Json;

namespace Farmtech.View
{
    public partial class ClienteNovo : Form
    {
        public ClienteNovo()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            ClienteEnt cliente = new ClienteEnt();    
            ClienteEnderecoEnt endereco = new ClienteEnderecoEnt();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.DataNasc = dataNasc.Value;
            if(cbGenero.Text == "Masculino")
            {
                cliente.Genero = 'M';
            }else if(cbGenero.Text == "Feminino")
            {
                cliente.Genero = 'F';
            }
            else
            {
                cliente.Genero = 'O';
            }
            endereco.ClCpf = txtCpf.Text;
            endereco.Rua = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = cbEstado.Text;
            endereco.Cep = txtCep.Text;

            
            string res = ClienteModel.Criar(cliente,endereco);
            MessageBox.Show(res);
            this.Hide();
            this.Close();

            this.Hide();
            Form novoForm = new Cliente();
            novoForm.ShowDialog();
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form novoForm = new Cliente();
            novoForm.ShowDialog();
            this.Close();
        }
    }
}

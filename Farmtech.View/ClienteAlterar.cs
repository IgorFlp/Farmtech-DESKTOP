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
    public partial class ClienteAlterar : Form
    {
        public ClienteAlterar(ClienteEnt clienteEnt, ClienteEnderecoEnt enderecoEnt)
        {            
            InitializeComponent(clienteEnt, enderecoEnt);
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

            ClienteModel clienteModel = new ClienteModel();
            string res = clienteModel.Atualizar(cliente,endereco);
            Alerta alerta = new Alerta();
            alerta.LblAlerta.Text = res;
            alerta.Show();

            
            //Console.WriteLine(JsonConvert.SerializeObject(cliente));
            //Console.WriteLine(JsonConvert.SerializeObject(endereco));

        }
    }
}
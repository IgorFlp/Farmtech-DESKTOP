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
    public partial class FornecedorAlterar : Form
    {
        public FornecedorAlterar(FornecedorEnt fornecedor, FornecedorEnderecoEnt endereco)
        {
            InitializeComponent(fornecedor,endereco);
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            FornecedorEnt fornecedor = new FornecedorEnt();    
            FornecedorEnderecoEnt endereco = new FornecedorEnderecoEnt();

            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmail.Text;            
            
            endereco.Frn_cnpj = txtCnpj.Text;
            endereco.Rua = txtRua.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Estado = cbEstado.Text;
            endereco.Cep = txtCep.Text; 


            FornecedorModel fornecedorModel = new FornecedorModel();    
            string res = fornecedorModel.Atualizar(fornecedor,endereco);
            Alerta alerta = new Alerta();
            alerta.LblAlerta.Text = res;
            alerta.Show();

            this.Close();

            
            //Console.WriteLine(JsonConvert.SerializeObject(fornecedor));
            //Console.WriteLine(JsonConvert.SerializeObject(endereco));

        }
    }
}
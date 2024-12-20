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
            InitializeComponent(fornecedor, endereco);
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            FornecedorEnt fornecedor = new FornecedorEnt();    
            FornecedorEnderecoEnt endereco = new FornecedorEnderecoEnt();
            if (
                txtRazaoSocial.Text != String.Empty &&
            txtNomeFantasia.Text != String.Empty &&
            txtCnpj.Text != String.Empty &&
            txtTelefone.Text != String.Empty &&
            txtEmail.Text != String.Empty &&
            txtRua.Text != String.Empty &&
            txtBairro.Text != String.Empty &&
            txtCidade.Text != String.Empty &&
            cbEstado.Text != String.Empty &&
            txtCep.Text != String.Empty
                )
            {
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


                string res = FornecedorModel.Atualizar(fornecedor, endereco);
                DialogResult ok = MessageBox.Show(res);
                if (ok == DialogResult.OK)
                {
                    this.Hide();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}

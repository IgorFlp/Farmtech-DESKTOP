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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        String tipo;
        int usuarioId;

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            usuarioId = 0;
            tipo = "Novo";
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_FarmtechDataSet.Tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.db_FarmtechDataSet.Tb_usuario);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            cbCargo.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            cbCargo.Enabled = false;
        }
        private void limparCampos()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            cbCargo.Text = "";    
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridUsuarios.SelectedRows[0];

                int usuarioId = Convert.ToInt32(linhaSelecionada.Cells[4].Value);

                UsuarioModel usuarioModel = new UsuarioModel();
                string res = usuarioModel.Excluir(usuarioId);

                this.Hide();
                Form novoForm = new Usuario();
                novoForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Selecione um usuario para deletar.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            UsuarioEnt usuario = new UsuarioEnt();
            habilitarCampos();
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridUsuarios.SelectedRows[0];

                usuarioId = Convert.ToInt32(linhaSelecionada.Cells[4].Value);

                UsuarioModel usuarioModel = new UsuarioModel();
                usuario = usuarioModel.BuscarUsuario(usuarioId);
                
                txtNome.Text = usuario.Nome;
                txtLogin.Text = usuario.Login;
                txtSenha.Text = usuario.Senha;
                cbCargo.SelectedText = usuario.Cargo;

                
                tipo = "Alterar";                
            }
            else
            {
                MessageBox.Show("Selecione um usuario para deletar.");
            }
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            UsuarioEnt usuario = new UsuarioEnt();
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Cargo = cbCargo.Text;
            usuario.Nome = txtNome.Text;
            if (txtLogin.Text != String.Empty &&
                txtSenha.Text != String.Empty &&
                txtNome.Text != String.Empty &&
                cbCargo.Text != String.Empty) {
                if (tipo == "Novo")
                {
                    usuarioModel.Criar(usuario);

                } else if (tipo == "Alterar")
                {
                    usuario.Id = usuarioId;
                    usuarioModel.Atualizar(usuario);

                }
                limparCampos();
                desabilitarCampos();

                this.Hide();
                Form novoForm = new Usuario();
                novoForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente");                
            }
            
        }

       
    }
}

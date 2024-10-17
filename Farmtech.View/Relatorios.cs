﻿using Farmtech.Entidades;
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

namespace Farmtech_DESKTOP
{
    public partial class Relatorios : Form
    {
        
        public Relatorios()
        {
            InitializeComponent();
        }
        List<ClienteEnt> clientes = new List<ClienteEnt>();
        List<ProdutoEnt> produtos = new List<ProdutoEnt>();
        
        List<VendaEnt> vendas = new List<VendaEnt>();        
        List<VendaProdutoEnt> vendaProdutos = new List<VendaProdutoEnt>();

        List<ProducaoEnt> producoes = new List<ProducaoEnt>();
        List<ProducaoProdutoEnt> producoesProdutos = new List<ProducaoProdutoEnt>();        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string relatorio = slcRelatorio.Text;
            switch (relatorio)
            {
                case "Vendas":
                    RelatorioVendas();
                    break;
                case "Clientes":
                    RelatorioClientes();
                    break;
                case "Fornecedores":
                    RelatorioFornecedores();
                    break;
                case "Produtos":
                    RelatorioProdutos();
                    break;
                case "Usuarios":
                    RelatorioUsuarios();
                    break;
            }
        }
        public void CarregarListas()
        {
            ClienteModel clienteModel = new ClienteModel();
            clientes = clienteModel.BuscarClientes();

            ProdutoModel produtoModel = new ProdutoModel();
            produtos = produtoModel.BuscarProdutos();

            VendasModel vendasModel = new VendasModel();
            vendas = vendasModel.BuscarVendas();
            vendaProdutos = vendasModel.BuscarVendasProdutos();
        }
        public void RelatorioProdutos()
        {
            // Limpa todas as colunas e dados atuais
            tabelaRelatorio.Columns.Clear();
            tabelaRelatorio.Rows.Clear();

            // Define as colunas manualmente para o relatório de produtos
            DataGridViewColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id";  // O nome da propriedade no objeto que será exibida
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn colNome = new DataGridViewTextBoxColumn();
            colNome.HeaderText = "Nome";
            colNome.DataPropertyName = "Nome";  // Nome da propriedade
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn colUnidade = new DataGridViewTextBoxColumn();
            colUnidade.HeaderText = "Unidade Medida";
            colUnidade.DataPropertyName = "UnMedida";  // Nome da propriedade
            colUnidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DataGridViewColumn colPreco = new DataGridViewTextBoxColumn();
            colPreco.HeaderText = "Preço Un";
            colPreco.DataPropertyName = "PrecoUn";
            colPreco.DefaultCellStyle.Format = "C2";  
            colPreco.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            colPreco.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            // Adiciona as colunas na DataGridView
            tabelaRelatorio.Columns.Add(colId);
            tabelaRelatorio.Columns.Add(colNome);
            tabelaRelatorio.Columns.Add(colUnidade);
            tabelaRelatorio.Columns.Add(colPreco);

            // Exemplo de como buscar dados do banco de dados
            // Substitua este código com sua lógica de busca no banco de dados
            ProdutoModel produtoModel = new ProdutoModel();             
            List<ProdutoEnt> produtos = produtoModel.BuscarProdutos(); // Sua função que retorna a lista de produtos

            // Define o DataSource para a DataGridView
            tabelaRelatorio.DataSource = produtos;

            // Atualiza a tela
            tabelaRelatorio.Refresh();
        }
        public void RelatorioUsuarios()
        {
           
            tabelaRelatorio.Columns.Clear();
            tabelaRelatorio.Rows.Clear();

            
            DataGridViewColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id";  
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn colLogin = new DataGridViewTextBoxColumn();
            colLogin.HeaderText = "Login";
            colLogin.DataPropertyName = "Login";  
            colLogin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn colNome = new DataGridViewTextBoxColumn();
            colNome.HeaderText = "Nome";
            colNome.DataPropertyName = "Nome";  
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            

            DataGridViewColumn colCargo = new DataGridViewTextBoxColumn();
            colCargo.HeaderText = "Cargo";
            colCargo.DataPropertyName = "Cargo";            
            colCargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Adiciona as colunas na DataGridView
            tabelaRelatorio.Columns.Add(colId);
            tabelaRelatorio.Columns.Add(colLogin);
            tabelaRelatorio.Columns.Add(colNome);            
            tabelaRelatorio.Columns.Add(colCargo);

            // Exemplo de como buscar dados do banco de dados
            // Substitua este código com sua lógica de busca no banco de dados
            UsuarioModel usuarioModel = new UsuarioModel();
            List<UsuarioEnt> usuarios = usuarioModel.BuscarUsuarios(); // Sua função que retorna a lista de produtos

            // Define o DataSource para a DataGridView
            tabelaRelatorio.DataSource = usuarios;

            if (tabelaRelatorio.Columns.Contains("senha"))
            {
                tabelaRelatorio.Columns.Remove("senha");
            }

            // Atualiza a tela
            tabelaRelatorio.Refresh();
        }
        public void RelatorioFornecedores()
        {

            tabelaRelatorio.Columns.Clear();
            tabelaRelatorio.Rows.Clear();

            
            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "CNPJ";
            col1.DataPropertyName = "CNPJ";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Nome Fantasia";
            col2.DataPropertyName = "nomeFantasia";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Razão social";
            col3.DataPropertyName = "razaoSocial";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Telefone";
            col4.DataPropertyName = "telefone";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Email";
            col5.DataPropertyName = "Email";
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Adiciona as colunas na DataGridView
            tabelaRelatorio.Columns.Add(col1);
            tabelaRelatorio.Columns.Add(col2);
            tabelaRelatorio.Columns.Add(col3);
            tabelaRelatorio.Columns.Add(col4);
            tabelaRelatorio.Columns.Add(col5);
            
            
            FornecedorModel fornecedorModel = new FornecedorModel();
            List<FornecedorEnt> fornecedores = fornecedorModel.BuscarFornecedores();

            tabelaRelatorio.DataSource = fornecedores;            

            
            tabelaRelatorio.Refresh();
        }
        public void RelatorioClientes()
        {

            tabelaRelatorio.Columns.Clear();
            tabelaRelatorio.Rows.Clear();


            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "CPF";
            col1.DataPropertyName = "CPF";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Nome";
            col2.DataPropertyName = "nome";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Telefone";
            col3.DataPropertyName = "telefone";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Email";
            col4.DataPropertyName = "Email";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Nascimento";
            col5.DataPropertyName = "dataNasc";
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Genero";
            col6.DataPropertyName = "genero";
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Adiciona as colunas na DataGridView
            tabelaRelatorio.Columns.Add(col1);
            tabelaRelatorio.Columns.Add(col2);
            tabelaRelatorio.Columns.Add(col3);
            tabelaRelatorio.Columns.Add(col4);
            tabelaRelatorio.Columns.Add(col5);
            tabelaRelatorio.Columns.Add(col6);


            ClienteModel clienteModel = new ClienteModel();
            List<ClienteEnt> clientes = clienteModel.BuscarClientes();

            tabelaRelatorio.DataSource = clientes;


            tabelaRelatorio.Refresh();
        }
        public void RelatorioVendas()
        {            

            tabelaRelatorio.Columns.Clear();
            tabelaRelatorio.Rows.Clear();
            tabelaRelatorio.AutoGenerateColumns = false;

            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "CPF";
            col1.DataPropertyName = "cl_cpf";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Nome";
            col2.DataPropertyName = "nome"; //inserir com metodo externo
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Produtos";
            col3.DataPropertyName = "produtos"; //inserir com metodo externo
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Quant";
            col4.DataPropertyName = "Quant";  //inserir com metodo externo
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Subtotal";
            col5.DataPropertyName = "subtotal";
            col5.DefaultCellStyle.Format = "C2";
            col5.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Frete";
            col6.DataPropertyName = "frete";
            col6.DefaultCellStyle.Format = "C2";
            col6.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Desconto";
            col7.DataPropertyName = "desconto";
            col7.DefaultCellStyle.Format = "C2";
            col7.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            col7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col8 = new DataGridViewTextBoxColumn();
            col8.HeaderText = "Total";
            col8.DataPropertyName = "total";
            col8.DefaultCellStyle.Format = "C2";
            col8.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            col8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col9 = new DataGridViewTextBoxColumn();
            col9.HeaderText = "Cupom";
            col9.DataPropertyName = "cupom";
            col9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            DataGridViewColumn col10 = new DataGridViewTextBoxColumn();
            col10.HeaderText = "Mtd Pagto";
            col10.DataPropertyName = "mtdPagto";
            col10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            DataGridViewColumn col11 = new DataGridViewTextBoxColumn();
            col11.HeaderText = "Entrega";
            col11.DataPropertyName = "Entrega";
            col11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            DataGridViewColumn col12 = new DataGridViewTextBoxColumn();
            col12.HeaderText = "Data";
            col12.DataPropertyName = "dtVenda";
            col12.DefaultCellStyle.Format = "dd/MM/yyyy";
            col12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewColumn col13 = new DataGridViewTextBoxColumn();
            col13.DataPropertyName = "usr_id";            
            col13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            col13.HeaderText = "Usuario";

            DataGridViewColumn col14 = new DataGridViewTextBoxColumn();
            col14.HeaderText = "ID";
            col14.DataPropertyName = "id";            
            col14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            // Adiciona as colunas na DataGridView
            tabelaRelatorio.Columns.Add(col1);
            tabelaRelatorio.Columns.Add(col2);
            tabelaRelatorio.Columns.Add(col3);
            tabelaRelatorio.Columns.Add(col4);
            tabelaRelatorio.Columns.Add(col5);
            tabelaRelatorio.Columns.Add(col6);
            tabelaRelatorio.Columns.Add(col7);
            tabelaRelatorio.Columns.Add(col8);
            tabelaRelatorio.Columns.Add(col9);
            tabelaRelatorio.Columns.Add(col10);
            tabelaRelatorio.Columns.Add(col11);            
            tabelaRelatorio.Columns.Add(col12);            
            tabelaRelatorio.Columns.Add(col13);            
            tabelaRelatorio.Columns.Add(col14);            

            tabelaRelatorio.DataSource = vendas;


            tabelaRelatorio.Refresh();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            CarregarListas();
        }
    }
}
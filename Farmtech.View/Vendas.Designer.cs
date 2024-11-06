using System.Windows.Forms;
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
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.slcCliente = new System.Windows.Forms.ComboBox();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_FarmtechDataSet = new Farmtech_DESKTOP.Db_FarmtechDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slcPagto = new System.Windows.Forms.ComboBox();
            this.slcEntrega = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbListaProdutos = new System.Windows.Forms.GroupBox();
            this.tabelaVenda = new System.Windows.Forms.DataGridView();
            this.rowIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowPrecoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowPrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gbAddProd = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCupom = new System.Windows.Forms.Button();
            this.tb_clienteTableAdapter = new Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_clienteTableAdapter();
            this.tb_cupomTableAdapter1 = new Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_cupomTableAdapter();
            this.tb_produtoTableAdapter = new Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_produtoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FarmtechDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaVenda)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gbAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slcCliente
            // 
            this.slcCliente.DataSource = this.tbclienteBindingSource;
            this.slcCliente.DisplayMember = "nome";
            this.slcCliente.FormattingEnabled = true;
            this.slcCliente.Location = new System.Drawing.Point(6, 28);
            this.slcCliente.Name = "slcCliente";
            this.slcCliente.Size = new System.Drawing.Size(259, 21);
            this.slcCliente.TabIndex = 1;
            this.slcCliente.ValueMember = "cpf";
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "Tb_cliente";
            this.tbclienteBindingSource.DataSource = this.db_FarmtechDataSet;
            // 
            // db_FarmtechDataSet
            // 
            this.db_FarmtechDataSet.DataSetName = "Db_FarmtechDataSet";
            this.db_FarmtechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // txtCupom
            // 
            this.txtCupom.BackColor = System.Drawing.SystemColors.Window;
            this.txtCupom.Location = new System.Drawing.Point(69, 75);
            this.txtCupom.MaxLength = 10;
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(88, 20);
            this.txtCupom.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cupom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pagmento";
            // 
            // slcPagto
            // 
            this.slcPagto.Items.AddRange(new object[] {
            "Boleto",
            "Credito",
            "Debito",
            "Dinheiro",
            "PIX"});
            this.slcPagto.Location = new System.Drawing.Point(69, 41);
            this.slcPagto.Name = "slcPagto";
            this.slcPagto.Size = new System.Drawing.Size(88, 21);
            this.slcPagto.TabIndex = 1;
            // 
            // slcEntrega
            // 
            this.slcEntrega.Items.AddRange(new object[] {
            "Entrega",
            "Retirada"});
            this.slcEntrega.Location = new System.Drawing.Point(69, 10);
            this.slcEntrega.Name = "slcEntrega";
            this.slcEntrega.Size = new System.Drawing.Size(88, 21);
            this.slcEntrega.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(22, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(91, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuario.Location = new System.Drawing.Point(5, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Tag = "";
            this.lblUsuario.Text = "Antônio Carlos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblTotal.Location = new System.Drawing.Point(92, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "R$ 00,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblDesconto.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDesconto.Location = new System.Drawing.Point(92, 82);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 20);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "R$ 00,00";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblFrete.Location = new System.Drawing.Point(92, 52);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(65, 20);
            this.lblFrete.TabIndex = 3;
            this.lblFrete.Text = "R$ 00,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Frete";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(92, 19);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(65, 20);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "R$ 00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subtotal";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 77);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(48, 30);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Location = new System.Drawing.Point(60, 78);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 30);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(102, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.Location = new System.Drawing.Point(23, 267);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(55, 35);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbListaProdutos
            // 
            this.gbListaProdutos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbListaProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbListaProdutos.BackgroundImage")));
            this.gbListaProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbListaProdutos.Controls.Add(this.tabelaVenda);
            this.gbListaProdutos.Location = new System.Drawing.Point(2, 113);
            this.gbListaProdutos.Name = "gbListaProdutos";
            this.gbListaProdutos.Size = new System.Drawing.Size(651, 322);
            this.gbListaProdutos.TabIndex = 0;
            this.gbListaProdutos.TabStop = false;
            // 
            // tabelaVenda
            // 
            this.tabelaVenda.AllowUserToAddRows = false;
            this.tabelaVenda.AllowUserToDeleteRows = false;
            this.tabelaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowIdProduto,
            this.rowNomeProduto,
            this.rowPrecoUn,
            this.rowQuant,
            this.rowPrecoTotal});
            this.tabelaVenda.Location = new System.Drawing.Point(4, 10);
            this.tabelaVenda.Name = "tabelaVenda";
            this.tabelaVenda.ReadOnly = true;
            this.tabelaVenda.Size = new System.Drawing.Size(641, 300);
            this.tabelaVenda.TabIndex = 0;
            this.tabelaVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaVenda_CellContentClick);
            // 
            // rowIdProduto
            // 
            this.rowIdProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rowIdProduto.HeaderText = "ID";
            this.rowIdProduto.Name = "rowIdProduto";
            this.rowIdProduto.ReadOnly = true;
            this.rowIdProduto.Width = 43;
            // 
            // rowNomeProduto
            // 
            this.rowNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rowNomeProduto.HeaderText = "Produto";
            this.rowNomeProduto.Name = "rowNomeProduto";
            this.rowNomeProduto.ReadOnly = true;
            // 
            // rowPrecoUn
            // 
            this.rowPrecoUn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rowPrecoUn.HeaderText = "Preço Un";
            this.rowPrecoUn.Name = "rowPrecoUn";
            this.rowPrecoUn.ReadOnly = true;
            this.rowPrecoUn.Width = 77;
            // 
            // rowQuant
            // 
            this.rowQuant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rowQuant.HeaderText = "Quantidade";
            this.rowQuant.Name = "rowQuant";
            this.rowQuant.ReadOnly = true;
            this.rowQuant.Width = 87;
            // 
            // rowPrecoTotal
            // 
            this.rowPrecoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rowPrecoTotal.HeaderText = "Preco Total";
            this.rowPrecoTotal.Name = "rowPrecoTotal";
            this.rowPrecoTotal.ReadOnly = true;
            this.rowPrecoTotal.Width = 87;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gbAddProd);
            this.groupBox5.Controls.Add(this.slcCliente);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnExcluir);
            this.groupBox5.Controls.Add(this.btnAdicionar);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(653, 117);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // gbAddProd
            // 
            this.gbAddProd.Controls.Add(this.btnSalvar);
            this.gbAddProd.Controls.Add(this.txtQuant);
            this.gbAddProd.Controls.Add(this.label6);
            this.gbAddProd.Controls.Add(this.cbProduto);
            this.gbAddProd.Enabled = false;
            this.gbAddProd.Location = new System.Drawing.Point(472, 13);
            this.gbAddProd.Name = "gbAddProd";
            this.gbAddProd.Size = new System.Drawing.Size(175, 100);
            this.gbAddProd.TabIndex = 5;
            this.gbAddProd.TabStop = false;
            this.gbAddProd.Text = "Adicionar produto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(136, 57);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(33, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.DecimalPlaces = 2;
            this.txtQuant.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtQuant.Location = new System.Drawing.Point(6, 68);
            this.txtQuant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(84, 20);
            this.txtQuant.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantidade";
            // 
            // cbProduto
            // 
            this.cbProduto.DataSource = this.tbprodutoBindingSource;
            this.cbProduto.DisplayMember = "nome";
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(6, 17);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(163, 21);
            this.cbProduto.TabIndex = 0;
            this.cbProduto.ValueMember = "id";
            // 
            // tbprodutoBindingSource
            // 
            this.tbprodutoBindingSource.DataMember = "Tb_produto";
            this.tbprodutoBindingSource.DataSource = this.db_FarmtechDataSet;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(653, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCupom);
            this.splitContainer1.Panel1.Controls.Add(this.txtCupom);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.slcPagto);
            this.splitContainer1.Panel1.Controls.Add(this.slcEntrega);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnConfirmar);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lblDesconto);
            this.splitContainer1.Panel2.Controls.Add(this.lblFrete);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.lblSubtotal);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(169, 435);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnCupom
            // 
            this.btnCupom.BackColor = System.Drawing.SystemColors.Control;
            this.btnCupom.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Pesquisa;
            this.btnCupom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCupom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCupom.FlatAppearance.BorderSize = 0;
            this.btnCupom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCupom.Location = new System.Drawing.Point(140, 77);
            this.btnCupom.Margin = new System.Windows.Forms.Padding(0);
            this.btnCupom.Name = "btnCupom";
            this.btnCupom.Size = new System.Drawing.Size(15, 15);
            this.btnCupom.TabIndex = 10;
            this.btnCupom.UseMnemonic = false;
            this.btnCupom.UseVisualStyleBackColor = false;
            this.btnCupom.Click += new System.EventHandler(this.btnCupom_Click);
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tb_cupomTableAdapter1
            // 
            this.tb_cupomTableAdapter1.ClearBeforeFill = true;
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 435);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gbListaProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FarmtechDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbListaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaVenda)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbAddProd.ResumeLayout(false);
            this.gbAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox slcCliente;
        private Label label1;
        private Button btnAdicionar;
        private Button btnExcluir;
        private ComboBox comboBox4;
        private ComboBox slcEntrega;
        private ComboBox slcPagto;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private Label label9;
        private Label lblFrete;
        private Label label7;
        private Label lblSubtotal;
        private Label label5;
        private Label lblDesconto;
        private Label label13;
        private GroupBox groupBox2;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtCupom;
        private GroupBox gbListaProdutos;
        private GroupBox groupBox5;
        private SplitContainer splitContainer1;
        private Farmtech_DESKTOP.Db_FarmtechDataSet db_FarmtechDataSet;
        private BindingSource tbclienteBindingSource;
        private Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_clienteTableAdapter tb_clienteTableAdapter;
        private Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_cupomTableAdapter tb_cupomTableAdapter1;
        private DataGridView tabelaVenda;
        private GroupBox gbAddProd;
        private ComboBox cbProduto;
        private BindingSource tbprodutoBindingSource;
        private Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_produtoTableAdapter tb_produtoTableAdapter;
        private Button btnSalvar;
        private NumericUpDown txtQuant;
        private Label label6;
        private DataGridViewTextBoxColumn rowIdProduto;
        private DataGridViewTextBoxColumn rowNomeProduto;
        private DataGridViewTextBoxColumn rowPrecoUn;
        private DataGridViewTextBoxColumn rowQuant;
        private DataGridViewTextBoxColumn rowPrecoTotal;
        private Button btnCupom;
    }
}
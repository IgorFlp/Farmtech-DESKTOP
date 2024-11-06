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

namespace WinFormsApp1
{
    partial class Producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabelaProducao = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unMedidaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_FarmtechDataSet = new Farmtech_DESKTOP.Db_FarmtechDataSet();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbAddProd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_produtoTableAdapter = new Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_produtoTableAdapter();
            this.tb_clienteTableAdapter = new Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_clienteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FarmtechDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.tabelaProducao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabelaProducao
            // 
            this.tabelaProducao.AllowUserToAddRows = false;
            this.tabelaProducao.AllowUserToDeleteRows = false;
            this.tabelaProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.produtoColumn,
            this.unMedidaColumn,
            this.quantColumn});
            this.tabelaProducao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaProducao.Location = new System.Drawing.Point(3, 16);
            this.tabelaProducao.Name = "tabelaProducao";
            this.tabelaProducao.ReadOnly = true;
            this.tabelaProducao.Size = new System.Drawing.Size(584, 360);
            this.tabelaProducao.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 43;
            // 
            // produtoColumn
            // 
            this.produtoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produtoColumn.HeaderText = "Produto";
            this.produtoColumn.Name = "produtoColumn";
            this.produtoColumn.ReadOnly = true;
            // 
            // unMedidaColumn
            // 
            this.unMedidaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.unMedidaColumn.HeaderText = "Unidade de Medida";
            this.unMedidaColumn.Name = "unMedidaColumn";
            this.unMedidaColumn.ReadOnly = true;
            this.unMedidaColumn.Width = 83;
            // 
            // quantColumn
            // 
            this.quantColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantColumn.HeaderText = "Quant. Produzida";
            this.quantColumn.Name = "quantColumn";
            this.quantColumn.ReadOnly = true;
            this.quantColumn.Width = 105;
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
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(74, 83);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.Location = new System.Drawing.Point(6, 84);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(58, 37);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
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
            this.lblUsuario.Location = new System.Drawing.Point(5, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Antônio Carlos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(0, -20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(590, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExcluir);
            this.groupBox4.Controls.Add(this.btnIncluir);
            this.groupBox4.Controls.Add(this.gbAddProd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 129);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Lixeira;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(181, 84);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(30, 30);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Adicionar;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.Location = new System.Drawing.Point(181, 45);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(30, 30);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // gbAddProd
            // 
            this.gbAddProd.Controls.Add(this.label2);
            this.gbAddProd.Controls.Add(this.btnSalvar);
            this.gbAddProd.Controls.Add(this.txtQuant);
            this.gbAddProd.Controls.Add(this.label6);
            this.gbAddProd.Controls.Add(this.cbProduto);
            this.gbAddProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbAddProd.Enabled = false;
            this.gbAddProd.Location = new System.Drawing.Point(3, 16);
            this.gbAddProd.Name = "gbAddProd";
            this.gbAddProd.Size = new System.Drawing.Size(171, 110);
            this.gbAddProd.TabIndex = 9;
            this.gbAddProd.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(136, 67);
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
            this.txtQuant.Location = new System.Drawing.Point(6, 78);
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
            this.label6.Location = new System.Drawing.Point(6, 62);
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
            this.cbProduto.Location = new System.Drawing.Point(5, 30);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.btnConfirmar);
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(455, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 129);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Producao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produção";
            this.Load += new System.EventHandler(this.Producao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FarmtechDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbAddProd.ResumeLayout(false);
            this.gbAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox4;
        private GroupBox groupBox2;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox gbAddProd;
        private Button btnSalvar;
        private NumericUpDown txtQuant;
        private Label label6;
        private ComboBox cbProduto;
        private DataGridView tabelaProducao;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn produtoColumn;
        private DataGridViewTextBoxColumn unMedidaColumn;
        private DataGridViewTextBoxColumn quantColumn;
        private Label label2;
        private Db_FarmtechDataSet db_FarmtechDataSet;
        private BindingSource tbprodutoBindingSource;
        private Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_produtoTableAdapter tb_produtoTableAdapter;
        private BindingSource tbclienteBindingSource;
        private Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_clienteTableAdapter tb_clienteTableAdapter;
        private GroupBox groupBox4;
        private Button btnIncluir;
        private Button btnExcluir;
    }
}
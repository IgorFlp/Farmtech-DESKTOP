namespace Farmtech_DESKTOP
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfornecedorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.db_FarmtechDataSet = new Farmtech_DESKTOP.Db_FarmtechDataSet();
            this.tbfornecedorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorTableAdapter = new Farmtech_DESKTOP.Db_FarmtechDataSetTableAdapters.Tb_fornecedorTableAdapter();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbfornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FarmtechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncluir.Location = new System.Drawing.Point(13, 13);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(37, 35);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExluir.BackgroundImage")));
            this.btnExluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExluir.Location = new System.Drawing.Point(56, 13);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(39, 35);
            this.btnExluir.TabIndex = 1;
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.AllowUserToAddRows = false;
            this.dataGridFornecedores.AllowUserToDeleteRows = false;
            this.dataGridFornecedores.AutoGenerateColumns = false;
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpjDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridFornecedores.DataSource = this.tbfornecedorBindingSource3;
            this.dataGridFornecedores.Location = new System.Drawing.Point(13, 64);
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.ReadOnly = true;
            this.dataGridFornecedores.Size = new System.Drawing.Size(708, 300);
            this.dataGridFornecedores.TabIndex = 2;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "razaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "nomeFantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            this.nomeFantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tbfornecedorBindingSource3
            // 
            this.tbfornecedorBindingSource3.DataMember = "Tb_fornecedor";
            this.tbfornecedorBindingSource3.DataSource = this.db_FarmtechDataSet;
            // 
            // db_FarmtechDataSet
            // 
            this.db_FarmtechDataSet.DataSetName = "Db_FarmtechDataSet";
            this.db_FarmtechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfornecedorBindingSource2
            // 
            this.tbfornecedorBindingSource2.DataMember = "Tb_fornecedor";
            this.tbfornecedorBindingSource2.DataSource = this.db_FarmtechDataSet;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.Location = new System.Drawing.Point(101, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(39, 35);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbfornecedorBindingSource1
            // 
            this.tbfornecedorBindingSource1.DataMember = "Tb_fornecedor";
            // 
            // tbfornecedorBindingSource
            // 
            this.tbfornecedorBindingSource.DataMember = "Tb_fornecedor";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::Farmtech_DESKTOP.Properties.Resources.Atualizar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Location = new System.Drawing.Point(682, 13);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(39, 35);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 376);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dataGridFornecedores);
            this.Controls.Add(this.btnExluir);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FarmtechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.DataGridView dataGridFornecedores;
        
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource1;
        private Db_FarmtechDataSet db_FarmtechDataSet;
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource2;
        private Db_FarmtechDataSetTableAdapters.Tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource3;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
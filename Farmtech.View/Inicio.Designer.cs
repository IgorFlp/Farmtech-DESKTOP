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

namespace Farmtech.View
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vendas = new System.Windows.Forms.GroupBox();
            this.btnProducao = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Vendas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Vendas);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 61);
            this.panel1.TabIndex = 0;
            // 
            // Vendas
            // 
            this.Vendas.Controls.Add(this.btnProducao);
            this.Vendas.Controls.Add(this.btnVender);
            this.Vendas.Controls.Add(this.btnRelatorio);
            this.Vendas.Location = new System.Drawing.Point(3, 3);
            this.Vendas.Name = "Vendas";
            this.Vendas.Size = new System.Drawing.Size(127, 53);
            this.Vendas.TabIndex = 1;
            this.Vendas.TabStop = false;
            this.Vendas.Text = "Vendas";
            // 
            // btnProducao
            // 
            this.btnProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducao.Location = new System.Drawing.Point(84, 16);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(33, 32);
            this.btnProducao.TabIndex = 5;
            this.btnProducao.UseVisualStyleBackColor = true;
            this.btnProducao.Click += new System.EventHandler(this.btnProducao_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVender.BackgroundImage")));
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVender.Location = new System.Drawing.Point(5, 17);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(34, 31);
            this.btnVender.TabIndex = 4;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorio.Location = new System.Drawing.Point(45, 16);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(33, 32);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUsuarios);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Controls.Add(this.btnFornecedores);
            this.groupBox1.Controls.Add(this.btnProdutos);
            this.groupBox1.Location = new System.Drawing.Point(136, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUsuarios.Location = new System.Drawing.Point(123, 16);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(35, 31);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Location = new System.Drawing.Point(44, 16);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(33, 30);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFornecedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.BackgroundImage")));
            this.btnFornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFornecedores.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnFornecedores.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFornecedores.Location = new System.Drawing.Point(81, 16);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(36, 30);
            this.btnFornecedores.TabIndex = 0;
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.BackgroundImage")));
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProdutos.Location = new System.Drawing.Point(5, 16);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(33, 31);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(688, 468);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "IMWG - FarmTech";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.Vendas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnFornecedores;
        private Button btnVender;
        private Button btnRelatorio;
        private Button btnClientes;
        private Button btnProdutos;
        private GroupBox groupBox1;
        private GroupBox Vendas;
        private Button btnUsuarios;
        private Button btnProducao;
    }
}

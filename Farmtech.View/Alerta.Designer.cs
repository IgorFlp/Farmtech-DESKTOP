﻿using System.Windows.Forms;

namespace Farmtech_DESKTOP
{
    partial class Alerta
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
            this.lblAlerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlerta
            // 
            this.lblAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlerta.AutoEllipsis = true;
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.Location = new System.Drawing.Point(18, 46);
            this.lblAlerta.Margin = new System.Windows.Forms.Padding(0);
            this.lblAlerta.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(200, 64);
            this.lblAlerta.TabIndex = 0;
            this.lblAlerta.Text = "usadhausdhusahdsahdusahsauhdshadahdushsuahdasudshadusahsaiuhdasiuhsadisudhiouhwoi" +
    "udqwhojidqhoqfishqodfho";
            this.lblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alerta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(232, 158);
            this.Controls.Add(this.lblAlerta);
            this.Name = "Alerta";
            this.Text = "Alerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlerta;

        public Label LblAlerta { get => lblAlerta; set => lblAlerta = value; }
    }
}
namespace Farmtech.View
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.inputUser = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntLogin
            // 
            this.bntLogin.Location = new System.Drawing.Point(286, 165);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(75, 23);
            this.bntLogin.TabIndex = 0;
            this.bntLogin.Text = "Login";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(185, 65);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuário";
            
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(185, 108);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            
            // 
            // inputUser
            // 
            this.inputUser.Location = new System.Drawing.Point(188, 82);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(173, 20);
            this.inputUser.TabIndex = 3;
            
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(188, 124);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(173, 20);
            this.inputSenha.TabIndex = 4;
            
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(182, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Farmtech";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(185, 147);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(34, 13);
            this.lblAviso.TabIndex = 6;
            this.lblAviso.Text = "Teste";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 212);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bntLogin);
            this.Name = "Login";
            this.Text = "Login";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.Label lblAvisoGs{ get { return lblAviso; } private set { lblAviso = value; } }
        
    }
}


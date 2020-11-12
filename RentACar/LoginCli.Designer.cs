namespace RentACar
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Registro = new System.Windows.Forms.Button();
            this.iniciar = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.userpass = new System.Windows.Forms.Label();
            this.txtuser = new miscelanea.ErrorTextbox();
            this.txtpass = new miscelanea.ErrorTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(24, 208);
            // 
            // Registro
            // 
            this.Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Registro.Location = new System.Drawing.Point(195, 208);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(145, 39);
            this.Registro.TabIndex = 5;
            this.Registro.Text = "REGISTRARSE";
            this.Registro.UseVisualStyleBackColor = false;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iniciar.Location = new System.Drawing.Point(362, 208);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(145, 39);
            this.iniciar.TabIndex = 6;
            this.iniciar.Text = "INICIAR";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.username.Location = new System.Drawing.Point(22, 75);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 7;
            this.username.Text = "USUARIO";
            // 
            // userpass
            // 
            this.userpass.AutoSize = true;
            this.userpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userpass.Location = new System.Drawing.Point(22, 126);
            this.userpass.Name = "userpass";
            this.userpass.Size = new System.Drawing.Size(129, 20);
            this.userpass.TabIndex = 8;
            this.userpass.Text = "CONTRASEÑA";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(195, 75);
            this.txtuser.Name = "txtuser";
            this.txtuser.OnlyNumeric = false;
            this.txtuser.Size = new System.Drawing.Size(312, 20);
            this.txtuser.TabIndex = 11;
            this.txtuser.Validar = false;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(195, 126);
            this.txtpass.Name = "txtpass";
            this.txtpass.OnlyNumeric = false;
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(312, 20);
            this.txtpass.TabIndex = 12;
            this.txtpass.Validar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.iniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 290);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.userpass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.Registro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Registro, 0);
            this.Controls.SetChildIndex(this.iniciar, 0);
            this.Controls.SetChildIndex(this.username, 0);
            this.Controls.SetChildIndex(this.userpass, 0);
            this.Controls.SetChildIndex(this.txtuser, 0);
            this.Controls.SetChildIndex(this.txtpass, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label userpass;
        private miscelanea.ErrorTextbox txtuser;
        private miscelanea.ErrorTextbox txtpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
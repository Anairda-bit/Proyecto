namespace RentACar
{
    partial class LoginEmpl
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
            this.txtpass = new miscelanea.ErrorTextbox();
            this.txtuser = new miscelanea.ErrorTextbox();
            this.userpass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(37, 180);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(206, 104);
            this.txtpass.Name = "txtpass";
            this.txtpass.OnlyNumeric = false;
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(245, 20);
            this.txtpass.TabIndex = 16;
            this.txtpass.Validar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(206, 53);
            this.txtuser.Name = "txtuser";
            this.txtuser.OnlyNumeric = false;
            this.txtuser.Size = new System.Drawing.Size(245, 20);
            this.txtuser.TabIndex = 15;
            this.txtuser.Validar = true;
            // 
            // userpass
            // 
            this.userpass.AutoSize = true;
            this.userpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userpass.Location = new System.Drawing.Point(33, 104);
            this.userpass.Name = "userpass";
            this.userpass.Size = new System.Drawing.Size(129, 20);
            this.userpass.TabIndex = 14;
            this.userpass.Text = "CONTRASEÑA";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.username.Location = new System.Drawing.Point(33, 53);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 13;
            this.username.Text = "USUARIO";
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iniciar.Location = new System.Drawing.Point(306, 180);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(145, 39);
            this.iniciar.TabIndex = 17;
            this.iniciar.Text = "INICIAR";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 263);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.userpass);
            this.Controls.Add(this.username);
            this.Name = "LoginEmpl";
            this.Text = "Login Empleados";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.username, 0);
            this.Controls.SetChildIndex(this.userpass, 0);
            this.Controls.SetChildIndex(this.txtuser, 0);
            this.Controls.SetChildIndex(this.txtpass, 0);
            this.Controls.SetChildIndex(this.iniciar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private miscelanea.ErrorTextbox txtpass;
        private miscelanea.ErrorTextbox txtuser;
        private System.Windows.Forms.Label userpass;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
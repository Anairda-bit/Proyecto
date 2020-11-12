namespace RentACar
{
    partial class Registrarse
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
            this.Nombre = new System.Windows.Forms.Label();
            this.idacceso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new miscelanea.ErrorTextbox();
            this.txtacc = new miscelanea.ErrorTextbox();
            this.txtusuario = new miscelanea.ErrorTextbox();
            this.txtpass = new miscelanea.ErrorTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Visible = false;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(311, 241);
            this.Guardar.Size = new System.Drawing.Size(226, 39);
            // 
            // Eliminar
            // 
            this.Eliminar.Visible = false;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(36, 241);
            this.Salir.Size = new System.Drawing.Size(219, 39);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Nombre.Location = new System.Drawing.Point(32, 36);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(80, 20);
            this.Nombre.TabIndex = 31;
            this.Nombre.Text = "NOMBRE";
            // 
            // idacceso
            // 
            this.idacceso.AutoSize = true;
            this.idacceso.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idacceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.idacceso.Location = new System.Drawing.Point(32, 112);
            this.idacceso.Name = "idacceso";
            this.idacceso.Size = new System.Drawing.Size(96, 20);
            this.idacceso.TabIndex = 37;
            this.idacceso.Text = "ID ACCESO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "INTRODUZCA EL ID DE USUARIO, ESTE CONSISTE DE SU NIF SIN LETRA";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(176, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.OnlyNumeric = false;
            this.txtnombre.Size = new System.Drawing.Size(361, 25);
            this.txtnombre.TabIndex = 49;
            this.txtnombre.Validar = true;
            // 
            // txtacc
            // 
            this.txtacc.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtacc.Location = new System.Drawing.Point(176, 114);
            this.txtacc.Name = "txtacc";
            this.txtacc.OnlyNumeric = true;
            this.txtacc.Size = new System.Drawing.Size(361, 25);
            this.txtacc.TabIndex = 51;
            this.txtacc.Validar = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(176, 148);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.OnlyNumeric = false;
            this.txtusuario.Size = new System.Drawing.Size(361, 25);
            this.txtusuario.TabIndex = 52;
            this.txtusuario.Validar = true;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(176, 191);
            this.txtpass.Name = "txtpass";
            this.txtpass.OnlyNumeric = false;
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(361, 25);
            this.txtpass.TabIndex = 53;
            this.txtpass.Validar = true;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 305);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idacceso);
            this.Controls.Add(this.Nombre);
            this.Name = "Registrarse";
            this.Text = "Registro";
            this.Controls.SetChildIndex(this.Consultar, 0);
            this.Controls.SetChildIndex(this.Guardar, 0);
            this.Controls.SetChildIndex(this.Eliminar, 0);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Nombre, 0);
            this.Controls.SetChildIndex(this.idacceso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.txtacc, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            this.Controls.SetChildIndex(this.txtpass, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label idacceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private miscelanea.ErrorTextbox txtnombre;
        private miscelanea.ErrorTextbox txtacc;
        private miscelanea.ErrorTextbox txtusuario;
        private miscelanea.ErrorTextbox txtpass;
    }
}
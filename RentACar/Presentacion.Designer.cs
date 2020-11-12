namespace RentACar
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            this.RENTACAR = new System.Windows.Forms.Label();
            this.INICIAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(17, 339);
            this.Salir.Size = new System.Drawing.Size(355, 39);
            // 
            // RENTACAR
            // 
            this.RENTACAR.AutoSize = true;
            this.RENTACAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RENTACAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RENTACAR.Location = new System.Drawing.Point(131, 47);
            this.RENTACAR.Name = "RENTACAR";
            this.RENTACAR.Size = new System.Drawing.Size(149, 25);
            this.RENTACAR.TabIndex = 2;
            this.RENTACAR.Text = "RENT A CAR";
            // 
            // INICIAR
            // 
            this.INICIAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.INICIAR.Location = new System.Drawing.Point(17, 252);
            this.INICIAR.Name = "INICIAR";
            this.INICIAR.Size = new System.Drawing.Size(355, 39);
            this.INICIAR.TabIndex = 3;
            this.INICIAR.Text = "AREA CLIENTES";
            this.INICIAR.UseVisualStyleBackColor = false;
            this.INICIAR.Click += new System.EventHandler(this.INICIAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(17, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "AREA EMPLEADOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Presentacion
            // 
            this.AcceptButton = this.INICIAR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INICIAR);
            this.Controls.Add(this.RENTACAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Presentacion";
            this.Text = "Rent A Car";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.RENTACAR, 0);
            this.Controls.SetChildIndex(this.INICIAR, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RENTACAR;
        private System.Windows.Forms.Button INICIAR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}


namespace RentACar
{
    partial class Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento));
            this.Consultar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(659, 206);
            this.Salir.Size = new System.Drawing.Size(119, 39);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Consultar.Location = new System.Drawing.Point(659, 36);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(119, 39);
            this.Consultar.TabIndex = 14;
            this.Consultar.Text = "CONSULTAR";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Guardar.Location = new System.Drawing.Point(659, 92);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(119, 39);
            this.Guardar.TabIndex = 15;
            this.Guardar.Text = "GUARDAR";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Eliminar.Location = new System.Drawing.Point(659, 147);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(119, 39);
            this.Eliminar.TabIndex = 16;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            this.errorP.Icon = ((System.Drawing.Icon)(resources.GetObject("errorP.Icon")));
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Consultar);
            this.Name = "Mantenimiento";
            this.Text = "MANTENIMIENTO";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Consultar, 0);
            this.Controls.SetChildIndex(this.Guardar, 0);
            this.Controls.SetChildIndex(this.Eliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Consultar;
        public System.Windows.Forms.Button Guardar;
        public System.Windows.Forms.Button Eliminar;
        public System.Windows.Forms.ErrorProvider errorP;
    }
}
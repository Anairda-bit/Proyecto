namespace RentACar
{
    partial class AreaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaEmpleados));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAME = new System.Windows.Forms.Label();
            this.ContenPri = new System.Windows.Forms.Button();
            this.btnpresentacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(12, 264);
            this.Salir.Size = new System.Drawing.Size(360, 39);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NAME.Location = new System.Drawing.Point(148, 124);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(83, 28);
            this.NAME.TabIndex = 12;
            this.NAME.Text = "nombre";
            // 
            // ContenPri
            // 
            this.ContenPri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ContenPri.Location = new System.Drawing.Point(12, 175);
            this.ContenPri.Name = "ContenPri";
            this.ContenPri.Size = new System.Drawing.Size(360, 39);
            this.ContenPri.TabIndex = 17;
            this.ContenPri.Text = "GESTIONES";
            this.ContenPri.UseVisualStyleBackColor = false;
            this.ContenPri.Click += new System.EventHandler(this.ContenPri_Click);
            // 
            // btnpresentacion
            // 
            this.btnpresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnpresentacion.Location = new System.Drawing.Point(12, 219);
            this.btnpresentacion.Name = "btnpresentacion";
            this.btnpresentacion.Size = new System.Drawing.Size(360, 39);
            this.btnpresentacion.TabIndex = 18;
            this.btnpresentacion.Text = "VOLVER";
            this.btnpresentacion.UseVisualStyleBackColor = false;
            this.btnpresentacion.Click += new System.EventHandler(this.btnpresentacion_Click);
            // 
            // AreaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 315);
            this.Controls.Add(this.btnpresentacion);
            this.Controls.Add(this.ContenPri);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NAME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaEmpleados";
            this.Text = "Area Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AreaEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.AreaEmpleados_Load);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.NAME, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.ContenPri, 0);
            this.Controls.SetChildIndex(this.btnpresentacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button ContenPri;
        private System.Windows.Forms.Button btnpresentacion;
    }
}
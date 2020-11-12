namespace RentACar
{
    partial class MantVehiculo
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
            this.matr = new System.Windows.Forms.Label();
            this.MARC = new System.Windows.Forms.Label();
            this.TIPP = new System.Windows.Forms.Label();
            this.TRANSM = new System.Windows.Forms.Label();
            this.PASAJ = new System.Windows.Forms.Label();
            this.PREC = new System.Windows.Forms.Label();
            this.txtmarca = new miscelanea.ErrorTextbox();
            this.txtmatricula = new miscelanea.ErrorTextbox();
            this.txtpasajer = new System.Windows.Forms.ComboBox();
            this.txttrans = new System.Windows.Forms.ComboBox();
            this.txttipo = new System.Windows.Forms.ComboBox();
            this.txtprecio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(769, 392);
            this.Consultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Consultar.Size = new System.Drawing.Size(139, 51);
            this.Consultar.Visible = false;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(614, 36);
            this.Guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Guardar.Size = new System.Drawing.Size(139, 51);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(614, 118);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eliminar.Size = new System.Drawing.Size(139, 51);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(614, 282);
            this.Salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Salir.Size = new System.Drawing.Size(139, 51);
            // 
            // matr
            // 
            this.matr.AutoSize = true;
            this.matr.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.matr.Location = new System.Drawing.Point(19, 41);
            this.matr.Name = "matr";
            this.matr.Size = new System.Drawing.Size(105, 20);
            this.matr.TabIndex = 38;
            this.matr.Text = "MATRICULA";
            // 
            // MARC
            // 
            this.MARC.AutoSize = true;
            this.MARC.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MARC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MARC.Location = new System.Drawing.Point(19, 89);
            this.MARC.Name = "MARC";
            this.MARC.Size = new System.Drawing.Size(67, 20);
            this.MARC.TabIndex = 39;
            this.MARC.Text = "MARCA";
            // 
            // TIPP
            // 
            this.TIPP.AutoSize = true;
            this.TIPP.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TIPP.Location = new System.Drawing.Point(19, 140);
            this.TIPP.Name = "TIPP";
            this.TIPP.Size = new System.Drawing.Size(48, 20);
            this.TIPP.TabIndex = 40;
            this.TIPP.Text = "TIPO";
            // 
            // TRANSM
            // 
            this.TRANSM.AutoSize = true;
            this.TRANSM.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRANSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TRANSM.Location = new System.Drawing.Point(19, 188);
            this.TRANSM.Name = "TRANSM";
            this.TRANSM.Size = new System.Drawing.Size(125, 20);
            this.TRANSM.TabIndex = 41;
            this.TRANSM.Text = "TRANSMISION";
            // 
            // PASAJ
            // 
            this.PASAJ.AutoSize = true;
            this.PASAJ.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASAJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PASAJ.Location = new System.Drawing.Point(19, 241);
            this.PASAJ.Name = "PASAJ";
            this.PASAJ.Size = new System.Drawing.Size(106, 20);
            this.PASAJ.TabIndex = 42;
            this.PASAJ.Text = "PASAJEROS";
            // 
            // PREC
            // 
            this.PREC.AutoSize = true;
            this.PREC.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PREC.Location = new System.Drawing.Point(19, 297);
            this.PREC.Name = "PREC";
            this.PREC.Size = new System.Drawing.Size(153, 20);
            this.PREC.TabIndex = 43;
            this.PREC.Text = "PRECIO POR DIA ";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(255, 92);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.OnlyNumeric = false;
            this.txtmarca.Size = new System.Drawing.Size(272, 27);
            this.txtmarca.TabIndex = 69;
            this.txtmarca.Validar = true;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricula.Location = new System.Drawing.Point(255, 39);
            this.txtmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.OnlyNumeric = false;
            this.txtmatricula.Size = new System.Drawing.Size(147, 27);
            this.txtmatricula.TabIndex = 68;
            this.txtmatricula.Validar = true;
            // 
            // txtpasajer
            // 
            this.txtpasajer.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasajer.FormattingEnabled = true;
            this.txtpasajer.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.txtpasajer.Location = new System.Drawing.Point(255, 243);
            this.txtpasajer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpasajer.Name = "txtpasajer";
            this.txtpasajer.Size = new System.Drawing.Size(93, 25);
            this.txtpasajer.TabIndex = 74;
            this.txtpasajer.Text = "Seleccione";
            // 
            // txttrans
            // 
            this.txttrans.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrans.FormattingEnabled = true;
            this.txttrans.Items.AddRange(new object[] {
            "Manual",
            "Automatico"});
            this.txttrans.Location = new System.Drawing.Point(255, 192);
            this.txttrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttrans.Name = "txttrans";
            this.txttrans.Size = new System.Drawing.Size(191, 25);
            this.txttrans.TabIndex = 75;
            this.txttrans.Text = "Seleccione";
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.FormattingEnabled = true;
            this.txttipo.Items.AddRange(new object[] {
            "Lujo",
            "Monovolumen",
            "Todo Terreno",
            "Furgoneta",
            "Caravan",
            "Ejecutivo",
            "Ecológico",
            "Compacto",
            "Descapotable",
            "Movilidad Reducida"});
            this.txttipo.Location = new System.Drawing.Point(255, 144);
            this.txttipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(191, 25);
            this.txttipo.TabIndex = 76;
            this.txttipo.Text = "Seleccione";
            // 
            // txtprecio
            // 
            this.txtprecio.FormattingEnabled = true;
            this.txtprecio.Items.AddRange(new object[] {
            "14",
            "16",
            "17",
            "20",
            "21",
            "26",
            "31",
            "37",
            "44",
            "51",
            "61",
            "78"});
            this.txtprecio.Location = new System.Drawing.Point(255, 297);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(93, 25);
            this.txtprecio.TabIndex = 77;
            this.txtprecio.Text = "Seleccione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(357, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "€ ";
            // 
            // MantVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txttrans);
            this.Controls.Add(this.txtpasajer);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.PREC);
            this.Controls.Add(this.PASAJ);
            this.Controls.Add(this.TRANSM);
            this.Controls.Add(this.TIPP);
            this.Controls.Add(this.MARC);
            this.Controls.Add(this.matr);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MantVehiculo";
            this.Text = "Gestión Vehiculos";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Consultar, 0);
            this.Controls.SetChildIndex(this.Guardar, 0);
            this.Controls.SetChildIndex(this.Eliminar, 0);
            this.Controls.SetChildIndex(this.matr, 0);
            this.Controls.SetChildIndex(this.MARC, 0);
            this.Controls.SetChildIndex(this.TIPP, 0);
            this.Controls.SetChildIndex(this.TRANSM, 0);
            this.Controls.SetChildIndex(this.PASAJ, 0);
            this.Controls.SetChildIndex(this.PREC, 0);
            this.Controls.SetChildIndex(this.txtmatricula, 0);
            this.Controls.SetChildIndex(this.txtmarca, 0);
            this.Controls.SetChildIndex(this.txtpasajer, 0);
            this.Controls.SetChildIndex(this.txttrans, 0);
            this.Controls.SetChildIndex(this.txttipo, 0);
            this.Controls.SetChildIndex(this.txtprecio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label matr;
        private System.Windows.Forms.Label MARC;
        private System.Windows.Forms.Label TIPP;
        private System.Windows.Forms.Label TRANSM;
        private System.Windows.Forms.Label PASAJ;
        private System.Windows.Forms.Label PREC;
        private miscelanea.ErrorTextbox txtmarca;
        private miscelanea.ErrorTextbox txtmatricula;
        private System.Windows.Forms.ComboBox txtpasajer;
        private System.Windows.Forms.ComboBox txttrans;
        private System.Windows.Forms.ComboBox txttipo;
        private System.Windows.Forms.ComboBox txtprecio;
        private System.Windows.Forms.Label label1;
    }
}
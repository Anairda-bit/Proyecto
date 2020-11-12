namespace RentACar
{
    partial class MantReserv
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
            this.lblmatricula = new miscelanea.ErrorTextbox();
            this.coche = new System.Windows.Forms.Label();
            this.buscarcli = new miscelanea.ErrorTextbox();
            this.Cliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha1 = new System.Windows.Forms.Label();
            this.lbLTOTAL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidreserv = new miscelanea.ErrorTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechain = new miscelanea.ErrorTextbox();
            this.fechafin = new miscelanea.ErrorTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(659, 191);
            this.Guardar.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(659, 91);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(659, 136);
            // 
            // lblmatricula
            // 
            this.lblmatricula.BackColor = System.Drawing.Color.Gray;
            this.lblmatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmatricula.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblmatricula.Location = new System.Drawing.Point(181, 144);
            this.lblmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.OnlyNumeric = false;
            this.lblmatricula.Size = new System.Drawing.Size(116, 32);
            this.lblmatricula.TabIndex = 94;
            this.lblmatricula.Text = "MATRICULA";
            this.lblmatricula.Validar = true;
            // 
            // coche
            // 
            this.coche.AutoSize = true;
            this.coche.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coche.Location = new System.Drawing.Point(12, 144);
            this.coche.Name = "coche";
            this.coche.Size = new System.Drawing.Size(105, 20);
            this.coche.TabIndex = 91;
            this.coche.Text = "MATRICULA";
            // 
            // buscarcli
            // 
            this.buscarcli.BackColor = System.Drawing.Color.Gray;
            this.buscarcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscarcli.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarcli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buscarcli.Location = new System.Drawing.Point(181, 91);
            this.buscarcli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarcli.Name = "buscarcli";
            this.buscarcli.OnlyNumeric = false;
            this.buscarcli.Size = new System.Drawing.Size(116, 32);
            this.buscarcli.TabIndex = 96;
            this.buscarcli.Text = "ID CLIENTE";
            this.buscarcli.Validar = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.Location = new System.Drawing.Point(22, 91);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(102, 20);
            this.Cliente.TabIndex = 95;
            this.Cliente.Text = "ID CLIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(22, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "FECHA FINAL";
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecha1.Location = new System.Drawing.Point(13, 204);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(128, 20);
            this.fecha1.TabIndex = 99;
            this.fecha1.Text = "FECHA INICIAL";
            // 
            // lbLTOTAL
            // 
            this.lbLTOTAL.AutoSize = true;
            this.lbLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLTOTAL.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLTOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbLTOTAL.Location = new System.Drawing.Point(181, 313);
            this.lbLTOTAL.Name = "lbLTOTAL";
            this.lbLTOTAL.Size = new System.Drawing.Size(66, 22);
            this.lbLTOTAL.TabIndex = 102;
            this.lbLTOTAL.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(22, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 101;
            this.label3.Text = "TOTAL";
            // 
            // lblidreserv
            // 
            this.lblidreserv.BackColor = System.Drawing.Color.Gray;
            this.lblidreserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblidreserv.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidreserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblidreserv.Location = new System.Drawing.Point(181, 44);
            this.lblidreserv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblidreserv.Name = "lblidreserv";
            this.lblidreserv.OnlyNumeric = false;
            this.lblidreserv.Size = new System.Drawing.Size(179, 32);
            this.lblidreserv.TabIndex = 104;
            this.lblidreserv.Text = "ID RESERVA";
            this.lblidreserv.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "ID RESERVA";
            // 
            // fechain
            // 
            this.fechain.BackColor = System.Drawing.Color.Gray;
            this.fechain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechain.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fechain.Location = new System.Drawing.Point(181, 204);
            this.fechain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechain.Name = "fechain";
            this.fechain.OnlyNumeric = false;
            this.fechain.Size = new System.Drawing.Size(116, 32);
            this.fechain.TabIndex = 105;
            this.fechain.Text = "Fecha inicial";
            this.fechain.Validar = true;
            // 
            // fechafin
            // 
            this.fechafin.BackColor = System.Drawing.Color.Gray;
            this.fechafin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechafin.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechafin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fechafin.Location = new System.Drawing.Point(181, 262);
            this.fechafin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechafin.Name = "fechafin";
            this.fechafin.OnlyNumeric = false;
            this.fechafin.Size = new System.Drawing.Size(116, 32);
            this.fechafin.TabIndex = 106;
            this.fechafin.Text = "Fecha inicial";
            this.fechafin.Validar = true;
            // 
            // MantReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechain);
            this.Controls.Add(this.lblidreserv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLTOTAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.buscarcli);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.coche);
            this.Name = "MantReserv";
            this.Text = "Mantenimiento Reservas";
            this.Load += new System.EventHandler(this.MantReserv_Load);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Consultar, 0);
            this.Controls.SetChildIndex(this.Guardar, 0);
            this.Controls.SetChildIndex(this.Eliminar, 0);
            this.Controls.SetChildIndex(this.coche, 0);
            this.Controls.SetChildIndex(this.lblmatricula, 0);
            this.Controls.SetChildIndex(this.Cliente, 0);
            this.Controls.SetChildIndex(this.buscarcli, 0);
            this.Controls.SetChildIndex(this.fecha1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbLTOTAL, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblidreserv, 0);
            this.Controls.SetChildIndex(this.fechain, 0);
            this.Controls.SetChildIndex(this.fechafin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private miscelanea.ErrorTextbox lblmatricula;
        private System.Windows.Forms.Label coche;
        private miscelanea.ErrorTextbox buscarcli;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.Label lbLTOTAL;
        private System.Windows.Forms.Label label3;
        private miscelanea.ErrorTextbox lblidreserv;
        private System.Windows.Forms.Label label2;
        private miscelanea.ErrorTextbox fechain;
        private miscelanea.ErrorTextbox fechafin;
    }
}
namespace RentACar
{
    partial class ConsultarAutosCli
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
            this.DTW = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.bilatu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconsultare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttipo = new miscelanea.ErrorTextbox();
            this.txttrans = new miscelanea.ErrorTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DTW)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(461, 470);
            // 
            // DTW
            // 
            this.DTW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTW.Location = new System.Drawing.Point(16, 156);
            this.DTW.Name = "DTW";
            this.DTW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTW.Size = new System.Drawing.Size(590, 289);
            this.DTW.TabIndex = 2;
            // 
            // Seleccionar
            // 
            this.Seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Seleccionar.Location = new System.Drawing.Point(16, 470);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(175, 40);
            this.Seleccionar.TabIndex = 13;
            this.Seleccionar.Text = "SELECCIONAR";
            this.Seleccionar.UseVisualStyleBackColor = false;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // bilatu
            // 
            this.bilatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bilatu.Location = new System.Drawing.Point(431, 37);
            this.bilatu.Name = "bilatu";
            this.bilatu.Size = new System.Drawing.Size(175, 39);
            this.bilatu.TabIndex = 33;
            this.bilatu.Text = "BUSCAR";
            this.bilatu.UseVisualStyleBackColor = false;
            this.bilatu.Click += new System.EventHandler(this.bilatu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "TIPO COCHE";
            // 
            // btnconsultare
            // 
            this.btnconsultare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnconsultare.Location = new System.Drawing.Point(431, 86);
            this.btnconsultare.Name = "btnconsultare";
            this.btnconsultare.Size = new System.Drawing.Size(175, 39);
            this.btnconsultare.TabIndex = 36;
            this.btnconsultare.Text = "BUSCAR";
            this.btnconsultare.UseVisualStyleBackColor = false;
            this.btnconsultare.Click += new System.EventHandler(this.btnconsultare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "TRANSMISION";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(165, 44);
            this.txttipo.Name = "txttipo";
            this.txttipo.OnlyNumeric = false;
            this.txttipo.Size = new System.Drawing.Size(231, 20);
            this.txttipo.TabIndex = 81;
            this.txttipo.Validar = false;
            // 
            // txttrans
            // 
            this.txttrans.Location = new System.Drawing.Point(165, 94);
            this.txttrans.Name = "txttrans";
            this.txttrans.OnlyNumeric = false;
            this.txttrans.Size = new System.Drawing.Size(231, 20);
            this.txttrans.TabIndex = 82;
            this.txttrans.Validar = false;
            // 
            // ConsultarAutosCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 544);
            this.Controls.Add(this.txttrans);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsultare);
            this.Controls.Add(this.bilatu);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.DTW);
            this.Name = "ConsultarAutosCli";
            this.Text = "ConsultarAutosCli";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.DTW, 0);
            this.Controls.SetChildIndex(this.Seleccionar, 0);
            this.Controls.SetChildIndex(this.bilatu, 0);
            this.Controls.SetChildIndex(this.btnconsultare, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txttipo, 0);
            this.Controls.SetChildIndex(this.txttrans, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DTW;
        public System.Windows.Forms.Button Seleccionar;
        public System.Windows.Forms.Button bilatu;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnconsultare;
        public System.Windows.Forms.Label label2;
        private miscelanea.ErrorTextbox txttipo;
        private miscelanea.ErrorTextbox txttrans;
    }
}
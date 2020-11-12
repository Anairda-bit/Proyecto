namespace RentACar
{
    partial class ConsultarReservasCli
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
            this.lbel = new System.Windows.Forms.Label();
            this.bilatu = new System.Windows.Forms.Button();
            this.txtbuscar = new miscelanea.ErrorTextbox();
            this.DTW = new System.Windows.Forms.DataGridView();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.Volver = new System.Windows.Forms.Button();
            this.reservasTableAdapter = new RentACar.RentACarDataSetTableAdapters.ReservasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DTW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(620, 387);
            // 
            // lbel
            // 
            this.lbel.AutoSize = true;
            this.lbel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbel.Location = new System.Drawing.Point(63, 38);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(102, 20);
            this.lbel.TabIndex = 35;
            this.lbel.Text = "ID CLIENTE";
            // 
            // bilatu
            // 
            this.bilatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bilatu.Location = new System.Drawing.Point(590, 28);
            this.bilatu.Name = "bilatu";
            this.bilatu.Size = new System.Drawing.Size(175, 39);
            this.bilatu.TabIndex = 34;
            this.bilatu.Text = "BUSCAR";
            this.bilatu.UseVisualStyleBackColor = false;
            this.bilatu.Click += new System.EventHandler(this.bilatu_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(196, 38);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.OnlyNumeric = false;
            this.txtbuscar.Size = new System.Drawing.Size(341, 20);
            this.txtbuscar.TabIndex = 33;
            this.txtbuscar.Validar = false;
            // 
            // DTW
            // 
            this.DTW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTW.Location = new System.Drawing.Point(25, 77);
            this.DTW.Name = "DTW";
            this.DTW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTW.Size = new System.Drawing.Size(740, 289);
            this.DTW.TabIndex = 32;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Volver.Location = new System.Drawing.Point(25, 387);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(145, 39);
            this.Volver.TabIndex = 36;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultarReservasCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.lbel);
            this.Controls.Add(this.bilatu);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.DTW);
            this.Name = "ConsultarReservasCli";
            this.Text = "Mis Reservas";
            this.Load += new System.EventHandler(this.ConsultarReservasCli_Load);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.DTW, 0);
            this.Controls.SetChildIndex(this.txtbuscar, 0);
            this.Controls.SetChildIndex(this.bilatu, 0);
            this.Controls.SetChildIndex(this.lbel, 0);
            this.Controls.SetChildIndex(this.Volver, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbel;
        public System.Windows.Forms.Button bilatu;
        public miscelanea.ErrorTextbox txtbuscar;
        public System.Windows.Forms.DataGridView DTW;
        public System.Windows.Forms.Button Volver;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private RentACarDataSetTableAdapters.ReservasTableAdapter reservasTableAdapter;
    }
}
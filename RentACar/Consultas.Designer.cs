namespace RentACar
{
    partial class Consultas
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
            this.DTW = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new miscelanea.ErrorTextbox();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.bilatu = new System.Windows.Forms.Button();
            this.lbel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DTW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(595, 431);
            this.Salir.Size = new System.Drawing.Size(175, 39);
            // 
            // DTW
            // 
            this.DTW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTW.Location = new System.Drawing.Point(30, 127);
            this.DTW.Name = "DTW";
            this.DTW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTW.Size = new System.Drawing.Size(740, 289);
            this.DTW.TabIndex = 1;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(201, 39);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.OnlyNumeric = false;
            this.txtbuscar.Size = new System.Drawing.Size(341, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.Validar = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Seleccionar.Location = new System.Drawing.Point(30, 431);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(175, 39);
            this.Seleccionar.TabIndex = 12;
            this.Seleccionar.Text = "SELECCIONAR";
            this.Seleccionar.UseVisualStyleBackColor = false;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // bilatu
            // 
            this.bilatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bilatu.Location = new System.Drawing.Point(595, 29);
            this.bilatu.Name = "bilatu";
            this.bilatu.Size = new System.Drawing.Size(175, 39);
            this.bilatu.TabIndex = 14;
            this.bilatu.Text = "BUSCAR";
            this.bilatu.UseVisualStyleBackColor = false;
            // 
            // lbel
            // 
            this.lbel.AutoSize = true;
            this.lbel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbel.Location = new System.Drawing.Point(68, 39);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(44, 20);
            this.lbel.TabIndex = 31;
            this.lbel.Text = "label";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.lbel);
            this.Controls.Add(this.bilatu);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.DTW);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.DTW, 0);
            this.Controls.SetChildIndex(this.txtbuscar, 0);
            this.Controls.SetChildIndex(this.Seleccionar, 0);
            this.Controls.SetChildIndex(this.bilatu, 0);
            this.Controls.SetChildIndex(this.lbel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DTW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView DTW;
        public System.Windows.Forms.Label lbel;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public miscelanea.ErrorTextbox txtbuscar;
        public System.Windows.Forms.Button Seleccionar;
        public System.Windows.Forms.Button bilatu;
    }
}
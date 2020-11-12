namespace RentACar
{
    partial class ReservasCli
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
            this.buscarcli = new miscelanea.ErrorTextbox();
            this.nomcli = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbldias = new miscelanea.ErrorTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha1 = new System.Windows.Forms.Label();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.fechain = new System.Windows.Forms.DateTimePicker();
            this.lblmatricula = new miscelanea.ErrorTextbox();
            this.transm = new miscelanea.ErrorTextbox();
            this.tipc = new miscelanea.ErrorTextbox();
            this.capaci = new miscelanea.ErrorTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coche = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarmarca = new miscelanea.ErrorTextbox();
            this.lbLTOTAL = new miscelanea.ErrorTextbox();
            this.Btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(415, 30);
            this.Consultar.Size = new System.Drawing.Size(345, 38);
            this.Consultar.Text = "CONSULTAR AUTOS";
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(415, 369);
            this.Guardar.Size = new System.Drawing.Size(345, 39);
            this.Guardar.Text = "RESERVAR";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(1153, 152);
            this.Eliminar.Visible = false;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(24, 463);
            this.Salir.Size = new System.Drawing.Size(261, 30);
            // 
            // buscarcli
            // 
            this.buscarcli.BackColor = System.Drawing.Color.Gray;
            this.buscarcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscarcli.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarcli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buscarcli.Location = new System.Drawing.Point(183, 36);
            this.buscarcli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarcli.Name = "buscarcli";
            this.buscarcli.OnlyNumeric = false;
            this.buscarcli.Size = new System.Drawing.Size(116, 32);
            this.buscarcli.TabIndex = 91;
            this.buscarcli.Text = "ID CLIENTE";
            this.buscarcli.Validar = true;
            // 
            // nomcli
            // 
            this.nomcli.AutoSize = true;
            this.nomcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomcli.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomcli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nomcli.Location = new System.Drawing.Point(183, 81);
            this.nomcli.Name = "nomcli";
            this.nomcli.Size = new System.Drawing.Size(80, 22);
            this.nomcli.TabIndex = 90;
            this.nomcli.Text = "CLIENTE";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nombre.Location = new System.Drawing.Point(24, 84);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(78, 20);
            this.nombre.TabIndex = 89;
            this.nombre.Text = "CLIENTE";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.Location = new System.Drawing.Point(24, 36);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(102, 20);
            this.Cliente.TabIndex = 88;
            this.Cliente.Text = "ID CLIENTE";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncalcular.Location = new System.Drawing.Point(24, 335);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(261, 30);
            this.btncalcular.TabIndex = 102;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbldias
            // 
            this.lbldias.Location = new System.Drawing.Point(179, 243);
            this.lbldias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbldias.Name = "lbldias";
            this.lbldias.OnlyNumeric = true;
            this.lbldias.Size = new System.Drawing.Size(57, 20);
            this.lbldias.TabIndex = 101;
            this.lbldias.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "TOTAL DIAS";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprecio.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblprecio.Location = new System.Drawing.Point(179, 295);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(70, 22);
            this.lblprecio.TabIndex = 99;
            this.lblprecio.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "TOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(24, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 96;
            this.label10.Text = "ALQUILER DIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(26, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "FECHA FIN";
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecha1.Location = new System.Drawing.Point(26, 131);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(128, 20);
            this.fecha1.TabIndex = 94;
            this.fecha1.Text = "FECHA INICIAL";
            // 
            // fechafin
            // 
            this.fechafin.CalendarFont = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechafin.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.fechafin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fechafin.CustomFormat = "yyyy-MM-dd";
            this.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechafin.Location = new System.Drawing.Point(179, 190);
            this.fechafin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(111, 20);
            this.fechafin.TabIndex = 93;
            // 
            // fechain
            // 
            this.fechain.CalendarFont = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechain.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.fechain.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fechain.CustomFormat = "yyyy-MM-dd";
            this.fechain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechain.Location = new System.Drawing.Point(179, 131);
            this.fechain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechain.Name = "fechain";
            this.fechain.Size = new System.Drawing.Size(115, 20);
            this.fechain.TabIndex = 92;
            // 
            // lblmatricula
            // 
            this.lblmatricula.BackColor = System.Drawing.Color.Gray;
            this.lblmatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmatricula.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblmatricula.Location = new System.Drawing.Point(580, 150);
            this.lblmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.OnlyNumeric = false;
            this.lblmatricula.Size = new System.Drawing.Size(116, 32);
            this.lblmatricula.TabIndex = 110;
            this.lblmatricula.Text = "MATRICULA";
            this.lblmatricula.Validar = true;
            // 
            // transm
            // 
            this.transm.BackColor = System.Drawing.Color.Gray;
            this.transm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transm.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.transm.Location = new System.Drawing.Point(584, 279);
            this.transm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transm.Name = "transm";
            this.transm.OnlyNumeric = false;
            this.transm.Size = new System.Drawing.Size(116, 27);
            this.transm.TabIndex = 109;
            this.transm.Text = "TRANSMISION";
            this.transm.Validar = true;
            // 
            // tipc
            // 
            this.tipc.BackColor = System.Drawing.Color.Gray;
            this.tipc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipc.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tipc.Location = new System.Drawing.Point(584, 216);
            this.tipc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipc.Name = "tipc";
            this.tipc.OnlyNumeric = false;
            this.tipc.Size = new System.Drawing.Size(116, 27);
            this.tipc.TabIndex = 108;
            this.tipc.Text = "TIPO";
            this.tipc.Validar = true;
            // 
            // capaci
            // 
            this.capaci.BackColor = System.Drawing.Color.Gray;
            this.capaci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capaci.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.capaci.Location = new System.Drawing.Point(589, 331);
            this.capaci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capaci.Name = "capaci";
            this.capaci.OnlyNumeric = false;
            this.capaci.Size = new System.Drawing.Size(36, 27);
            this.capaci.TabIndex = 107;
            this.capaci.Text = "2";
            this.capaci.Validar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(416, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "TRANSMISION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(411, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "TIPO COCHE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(416, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "CAPACIDAD";
            // 
            // coche
            // 
            this.coche.AutoSize = true;
            this.coche.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coche.Location = new System.Drawing.Point(411, 150);
            this.coche.Name = "coche";
            this.coche.Size = new System.Drawing.Size(105, 20);
            this.coche.TabIndex = 103;
            this.coche.Text = "MATRICULA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(411, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "MARCA COCHE";
            // 
            // buscarmarca
            // 
            this.buscarmarca.BackColor = System.Drawing.Color.Gray;
            this.buscarmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscarmarca.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarmarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buscarmarca.Location = new System.Drawing.Point(580, 83);
            this.buscarmarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarmarca.Name = "buscarmarca";
            this.buscarmarca.OnlyNumeric = false;
            this.buscarmarca.Size = new System.Drawing.Size(116, 27);
            this.buscarmarca.TabIndex = 112;
            this.buscarmarca.Text = "TIPO";
            this.buscarmarca.Validar = true;
            // 
            // lbLTOTAL
            // 
            this.lbLTOTAL.BackColor = System.Drawing.Color.Gray;
            this.lbLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLTOTAL.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLTOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbLTOTAL.Location = new System.Drawing.Point(179, 381);
            this.lbLTOTAL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbLTOTAL.Name = "lbLTOTAL";
            this.lbLTOTAL.OnlyNumeric = false;
            this.lbLTOTAL.Size = new System.Drawing.Size(70, 32);
            this.lbLTOTAL.TabIndex = 113;
            this.lbLTOTAL.Text = "TOTAL";
            this.lbLTOTAL.Validar = true;
            // 
            // Btnvolver
            // 
            this.Btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btnvolver.Location = new System.Drawing.Point(415, 463);
            this.Btnvolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnvolver.Name = "Btnvolver";
            this.Btnvolver.Size = new System.Drawing.Size(345, 30);
            this.Btnvolver.TabIndex = 114;
            this.Btnvolver.Text = "VOLVER";
            this.Btnvolver.UseVisualStyleBackColor = false;
            this.Btnvolver.Click += new System.EventHandler(this.Btnvolver_Click);
            // 
            // ReservasCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 514);
            this.Controls.Add(this.Btnvolver);
            this.Controls.Add(this.lbLTOTAL);
            this.Controls.Add(this.buscarmarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.transm);
            this.Controls.Add(this.tipc);
            this.Controls.Add(this.capaci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coche);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechain);
            this.Controls.Add(this.buscarcli);
            this.Controls.Add(this.nomcli);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Cliente);
            this.Name = "ReservasCli";
            this.Text = "ReservasCli";
            this.Load += new System.EventHandler(this.ReservasCli_Load);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Consultar, 0);
            this.Controls.SetChildIndex(this.Guardar, 0);
            this.Controls.SetChildIndex(this.Eliminar, 0);
            this.Controls.SetChildIndex(this.Cliente, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.nomcli, 0);
            this.Controls.SetChildIndex(this.buscarcli, 0);
            this.Controls.SetChildIndex(this.fechain, 0);
            this.Controls.SetChildIndex(this.fechafin, 0);
            this.Controls.SetChildIndex(this.fecha1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblprecio, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lbldias, 0);
            this.Controls.SetChildIndex(this.btncalcular, 0);
            this.Controls.SetChildIndex(this.coche, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.capaci, 0);
            this.Controls.SetChildIndex(this.tipc, 0);
            this.Controls.SetChildIndex(this.transm, 0);
            this.Controls.SetChildIndex(this.lblmatricula, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buscarmarca, 0);
            this.Controls.SetChildIndex(this.lbLTOTAL, 0);
            this.Controls.SetChildIndex(this.Btnvolver, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private miscelanea.ErrorTextbox buscarcli;
        private System.Windows.Forms.Label nomcli;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Button btncalcular;
        private miscelanea.ErrorTextbox lbldias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.DateTimePicker fechain;
        private miscelanea.ErrorTextbox lblmatricula;
        private miscelanea.ErrorTextbox transm;
        private miscelanea.ErrorTextbox tipc;
        private miscelanea.ErrorTextbox capaci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label coche;
        private System.Windows.Forms.Label label1;
        private miscelanea.ErrorTextbox buscarmarca;
        private miscelanea.ErrorTextbox lbLTOTAL;
        private System.Windows.Forms.Button Btnvolver;
    }
}
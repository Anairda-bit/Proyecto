namespace RentACar
{
    partial class Reservas
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
            this.Cliente = new System.Windows.Forms.Label();
            this.coche = new System.Windows.Forms.Label();
            this.fechain = new System.Windows.Forms.DateTimePicker();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConsuAut = new System.Windows.Forms.Button();
            this.ConsuCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarmarca = new miscelanea.ErrorTextbox();
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLTOTAL = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.nomcli = new System.Windows.Forms.Label();
            this.capaci = new miscelanea.ErrorTextbox();
            this.tipc = new miscelanea.ErrorTextbox();
            this.transm = new miscelanea.ErrorTextbox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbldias = new miscelanea.ErrorTextbox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.buscarcli = new miscelanea.ErrorTextbox();
            this.lblmatricula = new miscelanea.ErrorTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(621, 637);
            this.Consultar.Visible = false;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(537, 357);
            this.Guardar.Size = new System.Drawing.Size(447, 48);
            this.Guardar.Text = "RESERVAR";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(621, 595);
            this.Eliminar.Visible = false;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(1028, 205);
            this.Salir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Salir.Size = new System.Drawing.Size(133, 29);
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.Location = new System.Drawing.Point(14, 42);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(102, 20);
            this.Cliente.TabIndex = 40;
            this.Cliente.Text = "ID CLIENTE";
            // 
            // coche
            // 
            this.coche.AutoSize = true;
            this.coche.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coche.Location = new System.Drawing.Point(526, 127);
            this.coche.Name = "coche";
            this.coche.Size = new System.Drawing.Size(105, 20);
            this.coche.TabIndex = 42;
            this.coche.Text = "MATRICULA";
            // 
            // fechain
            // 
            this.fechain.CalendarFont = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechain.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.fechain.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fechain.CustomFormat = "yyyy-MM-dd";
            this.fechain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechain.Location = new System.Drawing.Point(167, 161);
            this.fechain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechain.Name = "fechain";
            this.fechain.Size = new System.Drawing.Size(115, 27);
            this.fechain.TabIndex = 44;
            // 
            // fechafin
            // 
            this.fechafin.CalendarFont = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechafin.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.fechafin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fechafin.CustomFormat = "yyyy-MM-dd";
            this.fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechafin.Location = new System.Drawing.Point(167, 220);
            this.fechafin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(111, 27);
            this.fechafin.TabIndex = 45;
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecha1.Location = new System.Drawing.Point(14, 161);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(128, 20);
            this.fecha1.TabIndex = 46;
            this.fecha1.Text = "FECHA INICIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(14, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "FECHA FIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(531, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "CAPACIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(526, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "TIPO COCHE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(531, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "TRANSMISION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(12, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "ALQUILER DIA";
            // 
            // ConsuAut
            // 
            this.ConsuAut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ConsuAut.Location = new System.Drawing.Point(1028, 54);
            this.ConsuAut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsuAut.Name = "ConsuAut";
            this.ConsuAut.Size = new System.Drawing.Size(133, 31);
            this.ConsuAut.TabIndex = 59;
            this.ConsuAut.Text = "AUTOS";
            this.ConsuAut.UseVisualStyleBackColor = false;
            this.ConsuAut.Click += new System.EventHandler(this.ConsuAut_Click);
            // 
            // ConsuCli
            // 
            this.ConsuCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ConsuCli.Location = new System.Drawing.Point(333, 42);
            this.ConsuCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsuCli.Name = "ConsuCli";
            this.ConsuCli.Size = new System.Drawing.Size(129, 32);
            this.ConsuCli.TabIndex = 60;
            this.ConsuCli.Text = "CLIENTES";
            this.ConsuCli.UseVisualStyleBackColor = false;
            this.ConsuCli.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(526, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "MARCA COCHE";
            // 
            // buscarmarca
            // 
            this.buscarmarca.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarmarca.Location = new System.Drawing.Point(695, 54);
            this.buscarmarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarmarca.Name = "buscarmarca";
            this.buscarmarca.OnlyNumeric = false;
            this.buscarmarca.Size = new System.Drawing.Size(289, 27);
            this.buscarmarca.TabIndex = 65;
            this.buscarmarca.Validar = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nombre.Location = new System.Drawing.Point(14, 106);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(78, 20);
            this.nombre.TabIndex = 67;
            this.nombre.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "TOTAL";
            // 
            // lbLTOTAL
            // 
            this.lbLTOTAL.AutoSize = true;
            this.lbLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLTOTAL.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLTOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbLTOTAL.Location = new System.Drawing.Point(167, 416);
            this.lbLTOTAL.Name = "lbLTOTAL";
            this.lbLTOTAL.Size = new System.Drawing.Size(66, 22);
            this.lbLTOTAL.TabIndex = 75;
            this.lbLTOTAL.Text = "TOTAL";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprecio.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblprecio.Location = new System.Drawing.Point(167, 325);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(70, 22);
            this.lblprecio.TabIndex = 76;
            this.lblprecio.Text = "PRECIO";
            // 
            // nomcli
            // 
            this.nomcli.AutoSize = true;
            this.nomcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomcli.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomcli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nomcli.Location = new System.Drawing.Point(173, 103);
            this.nomcli.Name = "nomcli";
            this.nomcli.Size = new System.Drawing.Size(80, 22);
            this.nomcli.TabIndex = 78;
            this.nomcli.Text = "CLIENTE";
            // 
            // capaci
            // 
            this.capaci.BackColor = System.Drawing.Color.Gray;
            this.capaci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capaci.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.capaci.Location = new System.Drawing.Point(704, 308);
            this.capaci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capaci.Name = "capaci";
            this.capaci.OnlyNumeric = false;
            this.capaci.Size = new System.Drawing.Size(36, 27);
            this.capaci.TabIndex = 79;
            this.capaci.Text = "2";
            this.capaci.Validar = false;
            // 
            // tipc
            // 
            this.tipc.BackColor = System.Drawing.Color.Gray;
            this.tipc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipc.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tipc.Location = new System.Drawing.Point(699, 193);
            this.tipc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipc.Name = "tipc";
            this.tipc.OnlyNumeric = false;
            this.tipc.Size = new System.Drawing.Size(116, 27);
            this.tipc.TabIndex = 80;
            this.tipc.Text = "TIPO";
            this.tipc.Validar = false;
            // 
            // transm
            // 
            this.transm.BackColor = System.Drawing.Color.Gray;
            this.transm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transm.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.transm.Location = new System.Drawing.Point(699, 256);
            this.transm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transm.Name = "transm";
            this.transm.OnlyNumeric = false;
            this.transm.Size = new System.Drawing.Size(116, 27);
            this.transm.TabIndex = 81;
            this.transm.Text = "TRANSMISION";
            this.transm.Validar = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnuevo.Location = new System.Drawing.Point(1028, 93);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(133, 30);
            this.btnnuevo.TabIndex = 82;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(14, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "TOTAL DIAS";
            // 
            // lbldias
            // 
            this.lbldias.Location = new System.Drawing.Point(167, 273);
            this.lbldias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbldias.Name = "lbldias";
            this.lbldias.OnlyNumeric = true;
            this.lbldias.Size = new System.Drawing.Size(57, 27);
            this.lbldias.TabIndex = 84;
            this.lbldias.Validar = true;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncalcular.Location = new System.Drawing.Point(12, 365);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(261, 30);
            this.btncalcular.TabIndex = 85;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // buscarcli
            // 
            this.buscarcli.BackColor = System.Drawing.Color.Gray;
            this.buscarcli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscarcli.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarcli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buscarcli.Location = new System.Drawing.Point(173, 42);
            this.buscarcli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarcli.Name = "buscarcli";
            this.buscarcli.OnlyNumeric = false;
            this.buscarcli.Size = new System.Drawing.Size(116, 32);
            this.buscarcli.TabIndex = 87;
            this.buscarcli.Text = "ID CLIENTE";
            this.buscarcli.Validar = true;
            // 
            // lblmatricula
            // 
            this.lblmatricula.BackColor = System.Drawing.Color.Gray;
            this.lblmatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmatricula.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblmatricula.Location = new System.Drawing.Point(695, 127);
            this.lblmatricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.OnlyNumeric = false;
            this.lblmatricula.Size = new System.Drawing.Size(116, 32);
            this.lblmatricula.TabIndex = 88;
            this.lblmatricula.Text = "MATRICULA";
            this.lblmatricula.Validar = true;
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 464);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.buscarcli);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.transm);
            this.Controls.Add(this.tipc);
            this.Controls.Add(this.capaci);
            this.Controls.Add(this.nomcli);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbLTOTAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.buscarmarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsuCli);
            this.Controls.Add(this.ConsuAut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechain);
            this.Controls.Add(this.coche);
            this.Controls.Add(this.Cliente);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Controls.SetChildIndex(this.Eliminar, 0);
            this.Controls.SetChildIndex(this.Consultar, 0);
            this.Controls.SetChildIndex(this.Guardar, 0);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Cliente, 0);
            this.Controls.SetChildIndex(this.coche, 0);
            this.Controls.SetChildIndex(this.fechain, 0);
            this.Controls.SetChildIndex(this.fechafin, 0);
            this.Controls.SetChildIndex(this.fecha1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.ConsuAut, 0);
            this.Controls.SetChildIndex(this.ConsuCli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buscarmarca, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbLTOTAL, 0);
            this.Controls.SetChildIndex(this.lblprecio, 0);
            this.Controls.SetChildIndex(this.nomcli, 0);
            this.Controls.SetChildIndex(this.capaci, 0);
            this.Controls.SetChildIndex(this.tipc, 0);
            this.Controls.SetChildIndex(this.transm, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lbldias, 0);
            this.Controls.SetChildIndex(this.btncalcular, 0);
            this.Controls.SetChildIndex(this.buscarcli, 0);
            this.Controls.SetChildIndex(this.lblmatricula, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label coche;
        private System.Windows.Forms.DateTimePicker fechain;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ConsuAut;
        private System.Windows.Forms.Button ConsuCli;
        private System.Windows.Forms.Label label1;
        private miscelanea.ErrorTextbox buscarmarca;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomcli;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lbLTOTAL;
        private miscelanea.ErrorTextbox transm;
        private miscelanea.ErrorTextbox tipc;
        private miscelanea.ErrorTextbox capaci;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private miscelanea.ErrorTextbox lbldias;
        private System.Windows.Forms.Label label6;
        private miscelanea.ErrorTextbox lblmatricula;
        private miscelanea.ErrorTextbox buscarcli;
    }
}
﻿namespace ProyectoBDII
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.docum = new System.Windows.Forms.TextBox();
            this.nomu = new System.Windows.Forms.TextBox();
            this.apu = new System.Windows.Forms.TextBox();
            this.numfactu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telu = new System.Windows.Forms.TextBox();
            this.edu = new System.Windows.Forms.TextBox();
            this.diru = new System.Windows.Forms.TextBox();
            this.fechafactu = new System.Windows.Forms.TextBox();
            this.Imprimir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.fact = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.idemedfact = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.totalfact = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cantidadfactme = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numcita = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.epsu = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tdou = new System.Windows.Forms.TextBox();
            this.tsau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NºDocumento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // docum
            // 
            this.docum.Location = new System.Drawing.Point(21, 161);
            this.docum.Name = "docum";
            this.docum.Size = new System.Drawing.Size(121, 20);
            this.docum.TabIndex = 7;
            this.docum.TextChanged += new System.EventHandler(this.docum_TextChanged);
            this.docum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.docum_KeyPress);
            // 
            // nomu
            // 
            this.nomu.Location = new System.Drawing.Point(198, 161);
            this.nomu.Name = "nomu";
            this.nomu.Size = new System.Drawing.Size(176, 20);
            this.nomu.TabIndex = 8;
            // 
            // apu
            // 
            this.apu.Location = new System.Drawing.Point(422, 161);
            this.apu.Name = "apu";
            this.apu.Size = new System.Drawing.Size(167, 20);
            this.apu.TabIndex = 9;
            // 
            // numfactu
            // 
            this.numfactu.Location = new System.Drawing.Point(645, 64);
            this.numfactu.Name = "numfactu";
            this.numfactu.Size = new System.Drawing.Size(111, 20);
            this.numfactu.TabIndex = 10;
            this.numfactu.TextChanged += new System.EventHandler(this.numfactu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Informacion del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Edad";
            // 
            // telu
            // 
            this.telu.Location = new System.Drawing.Point(512, 215);
            this.telu.Name = "telu";
            this.telu.Size = new System.Drawing.Size(111, 20);
            this.telu.TabIndex = 15;
            // 
            // edu
            // 
            this.edu.Location = new System.Drawing.Point(649, 215);
            this.edu.Name = "edu";
            this.edu.Size = new System.Drawing.Size(60, 20);
            this.edu.TabIndex = 16;
            // 
            // diru
            // 
            this.diru.Location = new System.Drawing.Point(649, 161);
            this.diru.Name = "diru";
            this.diru.Size = new System.Drawing.Size(136, 20);
            this.diru.TabIndex = 17;
            // 
            // fechafactu
            // 
            this.fechafactu.Location = new System.Drawing.Point(776, 64);
            this.fechafactu.Name = "fechafactu";
            this.fechafactu.Size = new System.Drawing.Size(111, 20);
            this.fechafactu.TabIndex = 18;
            // 
            // Imprimir
            // 
            this.Imprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimir.Location = new System.Drawing.Point(513, 608);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(176, 41);
            this.Imprimir.TabIndex = 20;
            this.Imprimir.Text = "Generar Factura";
            this.Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(722, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(652, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nº";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(781, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(353, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 39);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fact
            // 
            this.fact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Timplemento,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Fecha,
            this.Total});
            this.fact.Location = new System.Drawing.Point(21, 340);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(865, 257);
            this.fact.TabIndex = 33;
            this.fact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fact_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Implemento";
            this.ID.Name = "ID";
            // 
            // Timplemento
            // 
            this.Timplemento.HeaderText = "Tipo de Implemento";
            this.Timplemento.Name = "Timplemento";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Implemento";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha De Vencimiento";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(300, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 30);
            this.label11.TabIndex = 34;
            this.label11.Text = "Lista De La Factura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 19);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ingrese el IDE Del Implemento";
            // 
            // idemedfact
            // 
            this.idemedfact.Location = new System.Drawing.Point(284, 288);
            this.idemedfact.Name = "idemedfact";
            this.idemedfact.Size = new System.Drawing.Size(95, 20);
            this.idemedfact.TabIndex = 36;
            this.idemedfact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idemedfact_KeyPress);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(394, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 43);
            this.button4.TabIndex = 37;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 611);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Total Factura:";
            // 
            // totalfact
            // 
            this.totalfact.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfact.Location = new System.Drawing.Point(193, 608);
            this.totalfact.Multiline = true;
            this.totalfact.Name = "totalfact";
            this.totalfact.Size = new System.Drawing.Size(155, 37);
            this.totalfact.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(129, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 19);
            this.label14.TabIndex = 40;
            this.label14.Text = "Ingrese La Cantidad";
            // 
            // cantidadfactme
            // 
            this.cantidadfactme.Location = new System.Drawing.Point(284, 314);
            this.cantidadfactme.Name = "cantidadfactme";
            this.cantidadfactme.Size = new System.Drawing.Size(95, 20);
            this.cantidadfactme.TabIndex = 41;
            this.cantidadfactme.Text = "1";
            this.cantidadfactme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadfactme_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 19);
            this.label15.TabIndex = 43;
            this.label15.Text = "Tipo de Documento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(194, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 19);
            this.label17.TabIndex = 46;
            this.label17.Text = "Tipo de Sangre";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // numcita
            // 
            this.numcita.Location = new System.Drawing.Point(236, 56);
            this.numcita.Name = "numcita";
            this.numcita.Size = new System.Drawing.Size(111, 20);
            this.numcita.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(175, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 19);
            this.label16.TabIndex = 48;
            this.label16.Text = "ID Cita";
            // 
            // epsu
            // 
            this.epsu.Location = new System.Drawing.Point(353, 214);
            this.epsu.Name = "epsu";
            this.epsu.Size = new System.Drawing.Size(111, 20);
            this.epsu.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(349, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 19);
            this.label18.TabIndex = 50;
            this.label18.Text = "EPS";
            // 
            // tdou
            // 
            this.tdou.Location = new System.Drawing.Point(21, 215);
            this.tdou.Name = "tdou";
            this.tdou.Size = new System.Drawing.Size(121, 20);
            this.tdou.TabIndex = 52;
            // 
            // tsau
            // 
            this.tsau.Location = new System.Drawing.Point(198, 215);
            this.tsau.Name = "tsau";
            this.tsau.Size = new System.Drawing.Size(121, 20);
            this.tsau.TabIndex = 53;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 657);
            this.Controls.Add(this.tsau);
            this.Controls.Add(this.tdou);
            this.Controls.Add(this.epsu);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numcita);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cantidadfactme);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totalfact);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.idemedfact);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fact);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.fechafactu);
            this.Controls.Add(this.diru);
            this.Controls.Add(this.edu);
            this.Controls.Add(this.telu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numfactu);
            this.Controls.Add(this.apu);
            this.Controls.Add(this.nomu);
            this.Controls.Add(this.docum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox docum;
        private System.Windows.Forms.TextBox nomu;
        private System.Windows.Forms.TextBox apu;
        private System.Windows.Forms.TextBox numfactu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telu;
        private System.Windows.Forms.TextBox edu;
        private System.Windows.Forms.TextBox diru;
        private System.Windows.Forms.TextBox fechafactu;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView fact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox idemedfact;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalfact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cantidadfactme;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox numcita;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox epsu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tdou;
        private System.Windows.Forms.TextBox tsau;
    }
}
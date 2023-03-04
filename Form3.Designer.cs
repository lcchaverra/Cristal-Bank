namespace ProyectoBDII
{
    partial class FormularioAdministracionMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAdministracionMedicamentos));
            this.idi = new System.Windows.Forms.TextBox();
            this.nim = new System.Windows.Forms.TextBox();
            this.pre = new System.Windows.Forms.TextBox();
            this.canti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.Label();
            this.feven = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nuevo1 = new System.Windows.Forms.Button();
            this.Buscar1 = new System.Windows.Forms.Button();
            this.Guardar1 = new System.Windows.Forms.Button();
            this.Cancelar1 = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idi
            // 
            this.idi.Location = new System.Drawing.Point(199, 49);
            this.idi.Name = "idi";
            this.idi.Size = new System.Drawing.Size(100, 20);
            this.idi.TabIndex = 0;
            this.idi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id1_KeyPress);
            // 
            // nim
            // 
            this.nim.Location = new System.Drawing.Point(199, 116);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(299, 20);
            this.nim.TabIndex = 1;
            this.nim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomed_KeyPress);
            // 
            // pre
            // 
            this.pre.Location = new System.Drawing.Point(199, 297);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(100, 20);
            this.pre.TabIndex = 2;
            this.pre.Text = "0";
            this.pre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pre_KeyPress);
            // 
            // canti
            // 
            this.canti.Location = new System.Drawing.Point(357, 297);
            this.canti.Name = "canti";
            this.canti.Size = new System.Drawing.Size(100, 20);
            this.canti.TabIndex = 4;
            this.canti.Text = "0";
            this.canti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canti_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Implemento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Implemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.Location = new System.Drawing.Point(357, 273);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(87, 21);
            this.cant.TabIndex = 10;
            this.cant.Text = "Cantidad";
            // 
            // feven
            // 
            this.feven.AutoSize = true;
            this.feven.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feven.Location = new System.Drawing.Point(205, 218);
            this.feven.Name = "feven";
            this.feven.Size = new System.Drawing.Size(187, 21);
            this.feven.TabIndex = 11;
            this.feven.Text = "Fecha de Vencimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBDII.Properties.Resources.data_search;
            this.pictureBox1.Location = new System.Drawing.Point(26, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 147);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Nuevo1
            // 
            this.Nuevo1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo1.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo1.Image")));
            this.Nuevo1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo1.Location = new System.Drawing.Point(575, 80);
            this.Nuevo1.Name = "Nuevo1";
            this.Nuevo1.Size = new System.Drawing.Size(91, 37);
            this.Nuevo1.TabIndex = 13;
            this.Nuevo1.Text = "Nuevo";
            this.Nuevo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo1.UseVisualStyleBackColor = true;
            this.Nuevo1.Click += new System.EventHandler(this.Nuevo1_Click);
            // 
            // Buscar1
            // 
            this.Buscar1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar1.Image = ((System.Drawing.Image)(resources.GetObject("Buscar1.Image")));
            this.Buscar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar1.Location = new System.Drawing.Point(575, 138);
            this.Buscar1.Name = "Buscar1";
            this.Buscar1.Size = new System.Drawing.Size(88, 37);
            this.Buscar1.TabIndex = 14;
            this.Buscar1.Text = "Buscar";
            this.Buscar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar1.UseVisualStyleBackColor = true;
            this.Buscar1.Click += new System.EventHandler(this.Buscar1_Click);
            // 
            // Guardar1
            // 
            this.Guardar1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar1.Image = ((System.Drawing.Image)(resources.GetObject("Guardar1.Image")));
            this.Guardar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar1.Location = new System.Drawing.Point(575, 199);
            this.Guardar1.Name = "Guardar1";
            this.Guardar1.Size = new System.Drawing.Size(91, 37);
            this.Guardar1.TabIndex = 16;
            this.Guardar1.Text = "Guardar";
            this.Guardar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar1.UseVisualStyleBackColor = true;
            this.Guardar1.Click += new System.EventHandler(this.Guardar1_Click);
            // 
            // Cancelar1
            // 
            this.Cancelar1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar1.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar1.Image")));
            this.Cancelar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar1.Location = new System.Drawing.Point(575, 257);
            this.Cancelar1.Name = "Cancelar1";
            this.Cancelar1.Size = new System.Drawing.Size(91, 37);
            this.Cancelar1.TabIndex = 18;
            this.Cancelar1.Text = "Cancelar";
            this.Cancelar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar1.UseVisualStyleBackColor = true;
            this.Cancelar1.Click += new System.EventHandler(this.Cancelar1_Click);
            // 
            // tim
            // 
            this.tim.FormattingEnabled = true;
            this.tim.Items.AddRange(new object[] {
            "Vacuna",
            "Sangre"});
            this.tim.Location = new System.Drawing.Point(391, 49);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(121, 21);
            this.tim.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tipo de Implemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 242);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // FormularioAdministracionMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 354);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.Cancelar1);
            this.Controls.Add(this.Guardar1);
            this.Controls.Add(this.Buscar1);
            this.Controls.Add(this.Nuevo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.feven);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canti);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.idi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioAdministracionMedicamentos";
            this.Text = "Administrador de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idi;
        private System.Windows.Forms.TextBox nim;
        private System.Windows.Forms.TextBox pre;
        private System.Windows.Forms.TextBox canti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.Label feven;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Nuevo1;
        private System.Windows.Forms.Button Buscar1;
        private System.Windows.Forms.Button Guardar1;
        private System.Windows.Forms.Button Cancelar1;
        private System.Windows.Forms.ComboBox tim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
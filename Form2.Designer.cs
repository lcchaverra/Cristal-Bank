namespace ProyectoBDII
{
    partial class FormularioAdministracionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAdministracionCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.cedula = new System.Windows.Forms.TextBox();
            this.nombres = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tipodocu = new System.Windows.Forms.ComboBox();
            this.tsang = new System.Windows.Forms.ComboBox();
            this.eps = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edad";
            // 
            // Nuevo
            // 
            this.Nuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo.Location = new System.Drawing.Point(128, 399);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(91, 37);
            this.Nuevo.TabIndex = 6;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar.Location = new System.Drawing.Point(128, 458);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(91, 37);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Enabled = false;
            this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar.Location = new System.Drawing.Point(384, 399);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(86, 37);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar.Location = new System.Drawing.Point(259, 399);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(88, 37);
            this.Buscar.TabIndex = 9;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Enabled = false;
            this.Actualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar.Image")));
            this.Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Actualizar.Location = new System.Drawing.Point(259, 458);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(88, 37);
            this.Actualizar.TabIndex = 10;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar.Location = new System.Drawing.Point(384, 458);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(86, 37);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // cedula
            // 
            this.cedula.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(138, 99);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(187, 21);
            this.cedula.TabIndex = 12;
            this.cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedula_KeyPress);
            // 
            // nombres
            // 
            this.nombres.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres.Location = new System.Drawing.Point(138, 149);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(305, 21);
            this.nombres.TabIndex = 13;
            this.nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombres_KeyPress);
            // 
            // apellidos
            // 
            this.apellidos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos.Location = new System.Drawing.Point(138, 202);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(305, 21);
            this.apellidos.TabIndex = 14;
            this.apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidos_KeyPress);
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(137, 354);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(135, 21);
            this.telefono.TabIndex = 15;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // edad
            // 
            this.edad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(314, 354);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(53, 21);
            this.edad.TabIndex = 17;
            this.edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edad_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBDII.Properties.Resources.data;
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo de Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo de Sangre";
            // 
            // tipodocu
            // 
            this.tipodocu.FormattingEnabled = true;
            this.tipodocu.Items.AddRange(new object[] {
            "Registro Civil",
            "Tarjeta De Identidad",
            "Cedula de Ciudadania"});
            this.tipodocu.Location = new System.Drawing.Point(142, 44);
            this.tipodocu.Name = "tipodocu";
            this.tipodocu.Size = new System.Drawing.Size(183, 21);
            this.tipodocu.TabIndex = 21;
            // 
            // tsang
            // 
            this.tsang.FormattingEnabled = true;
            this.tsang.Items.AddRange(new object[] {
            "A positivo (A +)",
            "A negativo (A-)",
            "B positivo (B +)",
            "B negativo (B-)",
            "AB positivo (AB+)",
            "AB negativo (AB-)",
            "O positivo (O+)",
            "O negativo (O-)"});
            this.tsang.Location = new System.Drawing.Point(344, 264);
            this.tsang.Name = "tsang";
            this.tsang.Size = new System.Drawing.Size(183, 21);
            this.tsang.TabIndex = 22;
            // 
            // eps
            // 
            this.eps.FormattingEnabled = true;
            this.eps.Items.AddRange(new object[] {
            "Confachocó",
            "Coomeva",
            "Cuidar Es Salud",
            "FunVida",
            "Nueva EPS"});
            this.eps.Location = new System.Drawing.Point(137, 264);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(183, 21);
            this.eps.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "EPS";
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(137, 309);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(135, 20);
            this.dir.TabIndex = 25;
            // 
            // FormularioAdministracionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 516);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.eps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tsang);
            this.Controls.Add(this.tipodocu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioAdministracionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración de Clientes";
            this.Load += new System.EventHandler(this.FormularioAdministracionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tipodocu;
        private System.Windows.Forms.ComboBox tsang;
        private System.Windows.Forms.ComboBox eps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dir;
    }
}
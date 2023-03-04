namespace ProyectoBDII
{
    partial class FormCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
            this.button3 = new System.Windows.Forms.Button();
            this.docum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numcita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.DaU = new System.Windows.Forms.DataGridView();
            this.TD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DaU)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(261, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 26);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // docum
            // 
            this.docum.Location = new System.Drawing.Point(144, 82);
            this.docum.Name = "docum";
            this.docum.Size = new System.Drawing.Size(111, 20);
            this.docum.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "NºDocumento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Generar Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de Separacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha Asignada Para la Cita";
            // 
            // numcita
            // 
            this.numcita.Location = new System.Drawing.Point(496, 83);
            this.numcita.Name = "numcita";
            this.numcita.Size = new System.Drawing.Size(111, 20);
            this.numcita.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Id Cita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Datos de Usuario";
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar.Location = new System.Drawing.Point(612, 317);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(86, 37);
            this.Cancelar.TabIndex = 52;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar.Location = new System.Drawing.Point(612, 253);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(88, 37);
            this.Buscar.TabIndex = 50;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Enabled = false;
            this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar.Location = new System.Drawing.Point(496, 317);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(91, 37);
            this.Eliminar.TabIndex = 49;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar.Location = new System.Drawing.Point(496, 253);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(91, 37);
            this.Guardar.TabIndex = 48;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // DaU
            // 
            this.DaU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TD,
            this.N,
            this.A,
            this.Ep,
            this.TS,
            this.D,
            this.T,
            this.ED});
            this.DaU.Location = new System.Drawing.Point(36, 162);
            this.DaU.Name = "DaU";
            this.DaU.Size = new System.Drawing.Size(411, 192);
            this.DaU.TabIndex = 53;
            // 
            // TD
            // 
            this.TD.HeaderText = "Tipo de Documento";
            this.TD.Name = "TD";
            // 
            // N
            // 
            this.N.HeaderText = "Nombres";
            this.N.Name = "N";
            // 
            // A
            // 
            this.A.HeaderText = "Apellidos";
            this.A.Name = "A";
            // 
            // Ep
            // 
            this.Ep.HeaderText = "EPS";
            this.Ep.Name = "Ep";
            // 
            // TS
            // 
            this.TS.HeaderText = "Tipo de Sangre";
            this.TS.Name = "TS";
            // 
            // D
            // 
            this.D.HeaderText = "Direccion";
            this.D.Name = "D";
            // 
            // T
            // 
            this.T.HeaderText = "Telefono";
            this.T.Name = "T";
            // 
            // ED
            // 
            this.ED.HeaderText = "Edad";
            this.ED.Name = "ED";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(496, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(496, 204);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DaU);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numcita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.docum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCitas";
            ((System.ComponentModel.ISupportInitialize)(this.DaU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox docum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numcita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView DaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TD;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TS;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn ED;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
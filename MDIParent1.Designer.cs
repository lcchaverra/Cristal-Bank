namespace ProyectoBDII
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AdmonInventario = new System.Windows.Forms.Button();
            this.Factura = new System.Windows.Forms.Button();
            this.Adminclient = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(920, 70);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(920, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenid@";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(687, 519);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProyectoBDII.Properties.Resources.Sin_título;
            this.pictureBox2.Location = new System.Drawing.Point(188, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(572, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(265, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agendar Citas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdmonInventario
            // 
            this.AdmonInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdmonInventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmonInventario.Image = ((System.Drawing.Image)(resources.GetObject("AdmonInventario.Image")));
            this.AdmonInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdmonInventario.Location = new System.Drawing.Point(460, 12);
            this.AdmonInventario.Name = "AdmonInventario";
            this.AdmonInventario.Size = new System.Drawing.Size(131, 48);
            this.AdmonInventario.TabIndex = 12;
            this.AdmonInventario.Text = "Inventario";
            this.AdmonInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdmonInventario.UseVisualStyleBackColor = true;
            this.AdmonInventario.Click += new System.EventHandler(this.AdmonMedi_Click);
            // 
            // Factura
            // 
            this.Factura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factura.Image = ((System.Drawing.Image)(resources.GetObject("Factura.Image")));
            this.Factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Factura.Location = new System.Drawing.Point(619, 12);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(109, 48);
            this.Factura.TabIndex = 10;
            this.Factura.Text = "Factura";
            this.Factura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Factura.UseVisualStyleBackColor = true;
            this.Factura.Click += new System.EventHandler(this.Factura_Click);
            // 
            // Adminclient
            // 
            this.Adminclient.BackColor = System.Drawing.SystemColors.Control;
            this.Adminclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Adminclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminclient.Image = ((System.Drawing.Image)(resources.GetObject("Adminclient.Image")));
            this.Adminclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminclient.Location = new System.Drawing.Point(124, 12);
            this.Adminclient.Name = "Adminclient";
            this.Adminclient.Size = new System.Drawing.Size(113, 48);
            this.Adminclient.TabIndex = 4;
            this.Adminclient.Text = "Usuarios";
            this.Adminclient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Adminclient.UseVisualStyleBackColor = false;
            this.Adminclient.Click += new System.EventHandler(this.Adminclient_Click);
            // 
            // mas
            // 
            this.mas.BackColor = System.Drawing.Color.Transparent;
            this.mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mas.Image = ((System.Drawing.Image)(resources.GetObject("mas.Image")));
            this.mas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mas.Location = new System.Drawing.Point(783, 477);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(137, 37);
            this.mas.TabIndex = 21;
            this.mas.Text = "Acerca de";
            this.mas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mas.UseVisualStyleBackColor = false;
            this.mas.Click += new System.EventHandler(this.mas_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 539);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AdmonInventario);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adminclient);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormularioPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button Adminclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Factura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button AdmonInventario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button mas;
    }
}




namespace CiudadesApp
{
    partial class Form1
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPoblacion = new System.Windows.Forms.Label();
            this.lbFundacion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.dtpFundacion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(57, 49);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre: ";
            // 
            // lbPoblacion
            // 
            this.lbPoblacion.AutoSize = true;
            this.lbPoblacion.Location = new System.Drawing.Point(57, 97);
            this.lbPoblacion.Name = "lbPoblacion";
            this.lbPoblacion.Size = new System.Drawing.Size(82, 20);
            this.lbPoblacion.TabIndex = 1;
            this.lbPoblacion.Text = "Población:";
            this.lbPoblacion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbFundacion
            // 
            this.lbFundacion.AutoSize = true;
            this.lbFundacion.Location = new System.Drawing.Point(57, 143);
            this.lbFundacion.Name = "lbFundacion";
            this.lbFundacion.Size = new System.Drawing.Size(88, 20);
            this.lbFundacion.TabIndex = 2;
            this.lbFundacion.Text = "Fundación:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(163, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(310, 26);
            this.tbNombre.TabIndex = 3;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(163, 90);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(178, 26);
            this.tbPoblacion.TabIndex = 4;
            // 
            // dtpFundacion
            // 
            this.dtpFundacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFundacion.Location = new System.Drawing.Point(163, 143);
            this.dtpFundacion.Name = "dtpFundacion";
            this.dtpFundacion.Size = new System.Drawing.Size(126, 26);
            this.dtpFundacion.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(182, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 53);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(43, 295);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 62;
            this.dgvRegistros.RowTemplate.Height = 28;
            this.dgvRegistros.Size = new System.Drawing.Size(430, 223);
            this.dgvRegistros.TabIndex = 7;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 547);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFundacion);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbFundacion);
            this.Controls.Add(this.lbPoblacion);
            this.Controls.Add(this.lbNombre);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbPoblacion;
        private System.Windows.Forms.Label lbFundacion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.DateTimePicker dtpFundacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvRegistros;
    }
}


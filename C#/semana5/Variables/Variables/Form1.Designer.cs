namespace Variables
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lbVariableLocal = new System.Windows.Forms.Label();
            this.lbVariableGlobal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(50, 46);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre: ";
            this.lbNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(54, 84);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(46, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(118, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(185, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(118, 81);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(118, 128);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(185, 49);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lbVariableLocal
            // 
            this.lbVariableLocal.AutoSize = true;
            this.lbVariableLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVariableLocal.Location = new System.Drawing.Point(115, 201);
            this.lbVariableLocal.Name = "lbVariableLocal";
            this.lbVariableLocal.Size = new System.Drawing.Size(94, 16);
            this.lbVariableLocal.TabIndex = 5;
            this.lbVariableLocal.Text = "Variable Local";
            // 
            // lbVariableGlobal
            // 
            this.lbVariableGlobal.AutoSize = true;
            this.lbVariableGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVariableGlobal.Location = new System.Drawing.Point(115, 233);
            this.lbVariableGlobal.Name = "lbVariableGlobal";
            this.lbVariableGlobal.Size = new System.Drawing.Size(101, 16);
            this.lbVariableGlobal.TabIndex = 6;
            this.lbVariableGlobal.Text = "Variable Global";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 416);
            this.Controls.Add(this.lbVariableGlobal);
            this.Controls.Add(this.lbVariableLocal);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lbVariableLocal;
        private System.Windows.Forms.Label lbVariableGlobal;
    }
}


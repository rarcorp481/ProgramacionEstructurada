namespace Monto
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
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbMonto = new System.Windows.Forms.Label();
            this.btncalcularRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(44, 48);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(61, 20);
            this.lbPrecio.TabIndex = 0;
            this.lbPrecio.Text = "Precio: ";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(131, 48);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(242, 26);
            this.tbPrecio.TabIndex = 1;
            this.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(141, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(232, 48);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Monto con IVA";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbMonto
            // 
            this.lbMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMonto.Location = new System.Drawing.Point(48, 255);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(325, 124);
            this.lbMonto.TabIndex = 3;
            this.lbMonto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbMonto.Click += new System.EventHandler(this.lbMonto_Click);
            // 
            // btncalcularRef
            // 
            this.btncalcularRef.Location = new System.Drawing.Point(131, 185);
            this.btncalcularRef.Name = "btncalcularRef";
            this.btncalcularRef.Size = new System.Drawing.Size(242, 48);
            this.btncalcularRef.TabIndex = 4;
            this.btncalcularRef.Text = "Calcular Monto con IVA - REF\r\n";
            this.btncalcularRef.UseVisualStyleBackColor = true;
            this.btncalcularRef.Click += new System.EventHandler(this.btncalcularRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 431);
            this.Controls.Add(this.btncalcularRef);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Monto IVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Button btncalcularRef;
    }
}


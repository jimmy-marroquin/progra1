namespace primer_proyecto
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnSALUDAR = new System.Windows.Forms.Button();
            this.lblSALUDO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(165, 118);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NOMBRE";
            // 
            // btnSALUDAR
            // 
            this.btnSALUDAR.Location = new System.Drawing.Point(195, 182);
            this.btnSALUDAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSALUDAR.Name = "btnSALUDAR";
            this.btnSALUDAR.Size = new System.Drawing.Size(217, 95);
            this.btnSALUDAR.TabIndex = 1;
            this.btnSALUDAR.Text = "SALUDAR";
            this.btnSALUDAR.UseVisualStyleBackColor = true;
            this.btnSALUDAR.Click += new System.EventHandler(this.btnSALUDAR_Click);
            // 
            // lblSALUDO
            // 
            this.lblSALUDO.AutoSize = true;
            this.lblSALUDO.Location = new System.Drawing.Point(191, 340);
            this.lblSALUDO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSALUDO.Name = "lblSALUDO";
            this.lblSALUDO.Size = new System.Drawing.Size(43, 16);
            this.lblSALUDO.TabIndex = 2;
            this.lblSALUDO.Text = "HOLA";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(248, 118);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(188, 22);
            this.txtNOMBRE.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.lblSALUDO);
            this.Controls.Add(this.btnSALUDAR);
            this.Controls.Add(this.lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "HOLA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnSALUDAR;
        private System.Windows.Forms.Label lblSALUDO;
        private System.Windows.Forms.TextBox txtNOMBRE;
    }
}


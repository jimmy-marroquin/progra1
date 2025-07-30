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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(124, 96);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(54, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "NOMBRE";
            // 
            // btnSALUDAR
            // 
            this.btnSALUDAR.Location = new System.Drawing.Point(146, 148);
            this.btnSALUDAR.Name = "btnSALUDAR";
            this.btnSALUDAR.Size = new System.Drawing.Size(163, 77);
            this.btnSALUDAR.TabIndex = 1;
            this.btnSALUDAR.Text = "SALUDAR";
            this.btnSALUDAR.UseVisualStyleBackColor = true;
            this.btnSALUDAR.Click += new System.EventHandler(this.btnSALUDAR_Click);
            // 
            // lblSALUDO
            // 
            this.lblSALUDO.AutoSize = true;
            this.lblSALUDO.Location = new System.Drawing.Point(143, 276);
            this.lblSALUDO.Name = "lblSALUDO";
            this.lblSALUDO.Size = new System.Drawing.Size(36, 13);
            this.lblSALUDO.TabIndex = 2;
            this.lblSALUDO.Text = "HOLA";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(186, 96);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(142, 20);
            this.txtNOMBRE.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.lblSALUDO);
            this.Controls.Add(this.btnSALUDAR);
            this.Controls.Add(this.lbl);
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
        private System.Windows.Forms.Button button1;
    }
}


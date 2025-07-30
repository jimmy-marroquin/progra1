
namespace WindowsFormsApp1
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(286, 92);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(36, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "num 1";
            this.lblnum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(328, 85);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(328, 211);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 58);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(328, 130);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 4;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(286, 137);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(36, 13);
            this.lblnum2.TabIndex = 3;
            this.lblnum2.Text = "num 2";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(286, 163);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(59, 13);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "respuesta?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
    }
}


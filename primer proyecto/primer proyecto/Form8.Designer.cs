namespace primer_proyecto
{
    partial class Form8
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
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.lblCantidadCoversor = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboAConversor
            // 
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(119, 217);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(170, 24);
            this.cboAConversor.TabIndex = 35;
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(138, 174);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(167, 24);
            this.cboDeConversor.TabIndex = 34;
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo",
            "Area"});
            this.cboTipoConversor.Location = new System.Drawing.Point(157, 124);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(200, 24);
            this.cboTipoConversor.TabIndex = 33;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(76, 120);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(72, 31);
            this.lblTipoConversor.TabIndex = 32;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.Location = new System.Drawing.Point(76, 170);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(52, 31);
            this.lblDE.TabIndex = 31;
            this.lblDE.Text = "DE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "A:";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(206, 260);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(198, 22);
            this.txtCantidadConversor.TabIndex = 29;
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(76, 301);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(147, 31);
            this.lblRespuestaConversor.TabIndex = 28;
            this.lblRespuestaConversor.Text = "Resultado:?";
            // 
            // lblCantidadCoversor
            // 
            this.lblCantidadCoversor.AutoSize = true;
            this.lblCantidadCoversor.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCoversor.Location = new System.Drawing.Point(76, 260);
            this.lblCantidadCoversor.Name = "lblCantidadCoversor";
            this.lblCantidadCoversor.Size = new System.Drawing.Size(124, 31);
            this.lblCantidadCoversor.TabIndex = 27;
            this.lblCantidadCoversor.Text = "Cantidad:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.Control;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(500, 205);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(225, 84);
            this.btnConvertir.TabIndex = 26;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.lblCantidadCoversor);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.Label lblCantidadCoversor;
        private System.Windows.Forms.Button btnConvertir;
    }
}
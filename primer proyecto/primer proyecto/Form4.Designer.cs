﻿namespace primer_proyecto
{
    partial class Form4
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
            this.btnCalcularOpciones = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.optPrimo = new System.Windows.Forms.RadioButton();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.optPorcentaje = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivisión = new System.Windows.Forms.RadioButton();
            this.optMultiplicación = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcularOpciones
            // 
            this.btnCalcularOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularOpciones.Location = new System.Drawing.Point(554, 112);
            this.btnCalcularOpciones.Name = "btnCalcularOpciones";
            this.btnCalcularOpciones.Size = new System.Drawing.Size(177, 90);
            this.btnCalcularOpciones.TabIndex = 32;
            this.btnCalcularOpciones.Text = "Calcular Opciones";
            this.btnCalcularOpciones.UseVisualStyleBackColor = true;
            this.btnCalcularOpciones.Click += new System.EventHandler(this.btnCalcularOpciones_Click);
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cboOpciones.Location = new System.Drawing.Point(514, 54);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(261, 24);
            this.cboOpciones.TabIndex = 31;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.optPrimo);
            this.gbOpciones.Controls.Add(this.optFactorial);
            this.gbOpciones.Controls.Add(this.optPorcentaje);
            this.gbOpciones.Controls.Add(this.optExponente);
            this.gbOpciones.Controls.Add(this.optDivisión);
            this.gbOpciones.Controls.Add(this.optMultiplicación);
            this.gbOpciones.Controls.Add(this.optResta);
            this.gbOpciones.Controls.Add(this.optSuma);
            this.gbOpciones.Location = new System.Drawing.Point(358, 54);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(150, 343);
            this.gbOpciones.TabIndex = 30;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // optPrimo
            // 
            this.optPrimo.AutoSize = true;
            this.optPrimo.Location = new System.Drawing.Point(7, 221);
            this.optPrimo.Name = "optPrimo";
            this.optPrimo.Size = new System.Drawing.Size(63, 20);
            this.optPrimo.TabIndex = 7;
            this.optPrimo.TabStop = true;
            this.optPrimo.Text = "Primo";
            this.optPrimo.UseVisualStyleBackColor = true;
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(7, 194);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(80, 20);
            this.optFactorial.TabIndex = 6;
            this.optFactorial.TabStop = true;
            this.optFactorial.Text = "Factorial";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // optPorcentaje
            // 
            this.optPorcentaje.AutoSize = true;
            this.optPorcentaje.Location = new System.Drawing.Point(7, 167);
            this.optPorcentaje.Name = "optPorcentaje";
            this.optPorcentaje.Size = new System.Drawing.Size(93, 20);
            this.optPorcentaje.TabIndex = 5;
            this.optPorcentaje.TabStop = true;
            this.optPorcentaje.Text = "Porcentaje";
            this.optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(7, 140);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(92, 20);
            this.optExponente.TabIndex = 4;
            this.optExponente.TabStop = true;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivisión
            // 
            this.optDivisión.AutoSize = true;
            this.optDivisión.Location = new System.Drawing.Point(7, 112);
            this.optDivisión.Name = "optDivisión";
            this.optDivisión.Size = new System.Drawing.Size(76, 20);
            this.optDivisión.TabIndex = 3;
            this.optDivisión.TabStop = true;
            this.optDivisión.Text = "División";
            this.optDivisión.UseVisualStyleBackColor = true;
            // 
            // optMultiplicación
            // 
            this.optMultiplicación.AutoSize = true;
            this.optMultiplicación.Location = new System.Drawing.Point(7, 85);
            this.optMultiplicación.Name = "optMultiplicación";
            this.optMultiplicación.Size = new System.Drawing.Size(109, 20);
            this.optMultiplicación.TabIndex = 2;
            this.optMultiplicación.TabStop = true;
            this.optMultiplicación.Text = "Multiplicación";
            this.optMultiplicación.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(7, 58);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(64, 20);
            this.optResta.TabIndex = 1;
            this.optResta.TabStop = true;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Location = new System.Drawing.Point(7, 31);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(63, 20);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(78, 276);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(177, 90);
            this.btncalcular.TabIndex = 29;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(29, 187);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(79, 16);
            this.lblresultado.TabIndex = 28;
            this.lblresultado.Text = "Resultado ?";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(97, 110);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(220, 22);
            this.txtnum2.TabIndex = 27;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(97, 51);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(223, 22);
            this.txtnum1.TabIndex = 26;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(29, 120);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(65, 16);
            this.lblnum2.TabIndex = 25;
            this.lblnum2.Text = "Numero 2";
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(26, 54);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(65, 16);
            this.lblnum1.TabIndex = 24;
            this.lblnum1.Text = "Numero 1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularOpciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularOpciones;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.RadioButton optPrimo;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.RadioButton optPorcentaje;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optDivisión;
        private System.Windows.Forms.RadioButton optMultiplicación;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum1;
    }
}
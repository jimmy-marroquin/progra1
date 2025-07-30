using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta;
            num1 = double.Parse( txtnum1.Text);

            num2 = double.Parse(txtnum2.Text);

            respuesta = num1 + num2;

            lblrespuesta.Text = "Respuesta" + respuesta;

        }
    }
}

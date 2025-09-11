using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta;
            num1 = Double.Parse(txtnum1.Text);

            num2 = double.Parse(txtnum2.Text);

            respuesta = num1 + num2;

            lblresultado.Text = "respuesta: " + respuesta;
        }
    
    }
}

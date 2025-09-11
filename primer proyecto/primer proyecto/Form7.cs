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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            String[][] etiquetas = new String[][]
         {
            new String[] { "Manzanas", "mz²" },
            new String[] { "pie cuadrado", "pie²" },
            new String[] { "vara cuadrada", "vara²" },
            new String[] { "Yardas cuadrada", "yd²" },
            new String[] { "metros cuadrados", "mt²" },
            new String[] { "tareas ", "Tr" },
            new String[] { "hectareas", "Ht" }
         };
            double[][] valores = new double[][]
            {
                new double[] { 1, 75347.9, 10024.6, 8370.7, 7000, 16, 0.7 },
                new double[] { 0.000013276, 1, 0.1337, 0.1111, 0.092903, 0.0002125, 0.0000092903 },
                new double[] { 0.00009982, 7.481, 1, 0.835, 0.698737, 0.001597, 0.00006987 },
                new double[] { 0.00011957, 9, 1.197, 1, 0.836127, 0.001911, 0.00008361 },
                new double[] { 0.000142857, 10.7639, 1.4308, 1.196, 1, 0.002286, 0.0001  },
                new double[] { 0.0625, 4719.64, 624.6, 523.5, 437.5, 1, 0.04375 },
                new double[] { 1.42857, 107639, 14317.8, 11960, 10000, 22.857, 1 }
            };
            {
                double cantidad = double.Parse(txtCantidad.Text);
                int de = cboDe.SelectedIndex;
                int a = cboA.SelectedIndex;

                double resultado = cantidad * valores[de][a];
                lblResultado.Text = cantidad + " " + etiquetas[de][1] + " son " + resultado + " " + etiquetas[a][1];
            }
        }
    }
}

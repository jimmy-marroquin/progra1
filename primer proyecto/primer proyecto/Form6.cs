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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private double[][] tabla = {
            new Double[] {0.01, 500, 1.5, 0},
            new Double[] {500.01, 1000, 1.5, 3},
            new Double[] {1000.01, 2000, 3, 3},
            new Double[] {2000.01, 3000, 6, 3},
            new Double[] {3000.01, 6000, 9, 2 },
            new Double[] {8000.01, 18000, 15, 2},
            new Double[] {18000.01, 30000, 39, 2 },
            new Double[] {30000.01, 60000, 63, 1 },
            new Double[] {60000.01, 100000, 93, 0.8 },
            new Double[] {100000.01, 200000, 125, 0.7 },
            new Double[] {200000.01, 300000, 195, 0.6 },
            new Double[] {300000.01, 400000, 255, 0.45 },
            new Double[] {400000.01, 500000, 300, 0.4 },
            new Double[] {500000.01, 1000000, 340, 0.30 },
            new Double[] {1000000.01, 99999999, 490, 0.18 },

        };

        private double calcularImpuestoalasActividades(double Monto, double Desde, double Adicional, double Precio)
        {
            return (Monto - Desde) / 1000 * Adicional + Precio;
        }

        private double CalcularImpuesto(double Monto)
        {
            double Impuesto = 0;
            for (int i = 0; i < tabla.Length; i++)
            {
                if (Monto >= tabla[i][0] && Monto <= tabla[i][1])
                {
                    Impuesto = (Monto - tabla[i][0]) / 1000 * tabla[i][3] + tabla[i][2];

                }
            }
            return Impuesto;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Monto = 0, Totalapagar = 0;
            Monto = double.Parse(txtMonto.Text);

            for (int i = 0; i < tabla.Length; i++)
            {
                if (Monto >= tabla[i][0] && Monto <= tabla[i][1])
                {
                    Totalapagar = (Monto - tabla[i][0]) / 1000 * tabla[i][3] + tabla[i][2];


                }
            }

            lblResultado.Text = "Total de Impuesto por actividad económica a pagar: " + Totalapagar.ToString("C2");
        }
    }
    }

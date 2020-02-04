using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double porcent1, porcent2, porcent3, calcular= Convert.ToDouble(txtInversionista1.Text)+Convert.ToDouble(txtInversionista2.Text)+Convert.ToDouble(txtInversionista3.Text);
            txtTotal.Text = string.Format("{0:N2}",calcular);
            porcent1 = (Convert.ToDouble(txtInversionista1.Text) / calcular) * 100;
            txtPorcentaje1.Text = string.Format("{0:N2}%", porcent1);
            porcent2 = (Convert.ToDouble(txtInversionista2.Text) / calcular) * 100;
            txtPorcentaje2.Text = string.Format("{0:N2}%", porcent2);
            porcent3 = (Convert.ToDouble(txtInversionista3.Text) / calcular) * 100;
            txtPorcentaje3.Text = string.Format("{0:N2}%", porcent3);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInversionista1.Clear();
            txtInversionista2.Clear();
            txtInversionista3.Clear();
            txtPorcentaje1.Clear();
            txtPorcentaje2.Clear();
            txtPorcentaje3.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

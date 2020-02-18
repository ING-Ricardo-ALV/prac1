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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double exa1, exa2, exa3, prom;
            exa1 = double.Parse(txtExam1.Text);
            exa2 = Convert.ToDouble(txtExam2.Text);
            exa3 = Convert.ToDouble(txtExam3.Text);
            prom = (exa1 + exa2 + exa3) / 3.0;
            txtprom.Text= prom.ToString("N2");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExam1.Clear();
            txtExam2.Clear();
            txtExam3.Clear();
        }

        private void txtExam1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


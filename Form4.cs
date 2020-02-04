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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibros.SelectedItem.Equals("Baldor"))
            {
                txtPrecio.Text = "40.50";
            }
            else if (cboLibros.SelectedItem.Equals("SQL Server(ricardo edition)"))
            {
                txtPrecio.Text = "95.85";
            }
            else if (cboLibros.SelectedItem.Equals("La ultima ginda"))
            {
                txtPrecio.Text = "25.00";
            }
            else if (cboLibros.SelectedItem.Equals("El compendio"))
            {
                txtPrecio.Text = "10.15";
            }
            else
            {
                txtPrecio.Text = "12.99";
            }
        }

        private void txtSub_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sub = Convert.ToDouble(txtPrecio.Text);
            int cant = Convert.ToInt32(txtCantidad.Text);
            double mm = sub * cant;
            txtSub.Text = Convert.ToString(mm);

            double imp = mm * 0.13;
            double tot = mm + imp;
            txtImpuesto.Text = Convert.ToString(imp);
            txtPagar.Text = Convert.ToString(tot);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtImpuesto.Clear();
            txtPagar.Clear();
            txtPrecio.Clear();
            txtSub.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}

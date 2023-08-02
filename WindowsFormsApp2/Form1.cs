using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) 
            {
                e.Handled = true;
            }
                
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }
            else if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }
            else if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
            else
            {
                txtResultado.Text = @"Nombre y Apellido: " + txtNombre.Text + ", " + txtApellido.Text + 
                    "Direccion: " + txtDireccion.Text + 
                    "Edad: " + txtEdad.Text;
                
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

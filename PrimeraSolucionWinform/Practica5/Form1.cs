using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Practica5 : Form
    {
        public Practica5()
        {
            InitializeComponent();
        }

        private void txtbApellido_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void txtboxEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtboxEdad.Text == "")           
                txtboxEdad.BackColor = Color.Red;
            else
                txtbApellido.BackColor = System.Drawing.SystemColors.Control;
            
        }

        private void txtboxNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtboxDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtboxDireccion.Text == "")
                txtboxDireccion.BackColor = Color.Red;
            else
                txtboxDireccion.BackColor= System.Drawing.SystemColors.Control;
        }

        private void txtboxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57 &&  e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbApellido.Text == "") 
            { 
                txtbApellido.BackColor = Color.Red;
                MessageBox.Show("El campo 'Apellido' está sin completar. Ingrese los datos, por favor.", "Atención");
            }             
            else
                txtbApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtboxNombre.Text == "") 
            { 
                txtboxNombre.BackColor = Color.Red;
                MessageBox.Show("El campo 'Nombre' está sin completar. Ingrese los datos, por favor.", "Atención");
            }
            else
                txtboxNombre.BackColor = System.Drawing.SystemColors.Control;
            if (txtboxEdad.Text == "")
            {
                txtboxEdad.BackColor = Color.Red;
                MessageBox.Show("El campo 'Edad' está sin completar. Ingrese los datos, por favor.", "Atención");
            }
            else
                txtboxEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtboxDireccion.Text == "")
            {
                txtboxDireccion.BackColor = Color.Red;
                MessageBox.Show("El campo 'Dirección' está sin completar. Ingrese los datos, por favor.", "Atención");
            }
            else
                txtboxDireccion.BackColor= System.Drawing.SystemColors.Control;

            string apellido = txtbApellido.Text;
            string nombre = txtboxNombre.Text;
            string edad = txtboxEdad.Text;
            string direccion = txtboxDireccion.Text;

            richTextBox1.Text = "Apellido y nombre: " + apellido + " " + nombre + "\n" + "Edad: " + edad + "\n" + "Dirección: " + direccion;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

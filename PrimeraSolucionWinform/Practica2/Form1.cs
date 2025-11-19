using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pulsado el botón", "Atención");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPrueba_Click(object sender, EventArgs e)
        {

        }

        private void lblPrueba_MouseMove(object sender, MouseEventArgs e)
        {
            lblPrueba.BackColor = Color.DarkCyan;
            lblPrueba.Cursor = Cursors.Hand;
        }

        private void lblPrueba_MouseLeave(object sender, EventArgs e)
        {
            lblPrueba.BackColor = System.Drawing.SystemColors.Control;
            lblPrueba.Cursor = Cursors.Arrow;
        }

        
    }
}

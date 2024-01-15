using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Prac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realizarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarPrestamo ventana = new RealizarPrestamo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void libroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsLibro ventana2 = new ConsLibro();
            ventana2.MdiParent = this;
            ventana2.Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsPersona ventana3 = new ConsPersona();
            ventana3.MdiParent = this;
            ventana3.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsPrestamo ventana4 = new ConsPrestamo();
            ventana4.MdiParent = this;
            ventana4.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgLibro ventana5 = new AgLibro();
            ventana5.MdiParent = this;
            ventana5.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgPersona ventana6 = new AgPersona();
            ventana6.MdiParent = this;
            ventana6.Show();
        }
    }
}

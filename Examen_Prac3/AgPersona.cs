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
    public partial class AgPersona : Form
    {
        Consultas objeto = new Consultas();
        public AgPersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string direccion = textBox3.Text;

            string sql = "insert into Lector values (" + "'" + nombre + "'," + "'" + apellido + "'," + "'" + direccion + "'" + ")";

            objeto.ejecutarComando(sql);

            limpiar();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

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
    public partial class AgLibro : Form
    {
        Consultas objeto = new Consultas();
        public AgLibro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            string titulo = textBox2.Text;
            string autor = textBox3.Text;
            string fechaPubli = dateTimePicker1.Value.Date.ToShortDateString();
            string editorial = textBox4.Text;

            string sql = "insert into Libro VALUES (" + "'" + codigo + "', " + "'" + titulo + "', " + "'" + autor + "', " + "'" + fechaPubli + "', " + "'" + editorial + "'," + "'Disponible')";

            objeto.ejecutarComando(sql);

            limpiar();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}

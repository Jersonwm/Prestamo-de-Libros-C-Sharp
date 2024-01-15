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
    public partial class ConsLibro : Form
    {
        Consultas objeto = new Consultas();
        public ConsLibro()
        {
            InitializeComponent();
        }

        private void ConsLibro_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Libro";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = textBox1.Text;

            if (radioButton1.Checked)
            {
                string sql1 = "select * from Libro where Titulo like '%" + busqueda + "%'";
                dataGridView1.DataSource = objeto.consulta(sql1);
                dataGridView1.Refresh();
            }
            else if (radioButton2.Checked)
            {
                string sql1 = "select * from Libro where Autor like '%" + busqueda + "%'";
                dataGridView1.DataSource = objeto.consulta(sql1);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion de busqueda","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Libro";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }
    }
}

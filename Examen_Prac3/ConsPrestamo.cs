using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen_Prac3
{
    public partial class ConsPrestamo : Form
    {
        Consultas objeto = new Consultas();
        public ConsPrestamo()
        {
            InitializeComponent();
        }

        private void ConsPrestamo_Load(object sender, EventArgs e)
        {
            string sql = "Select P.cod_prestamo, P.fecha_prestamo, P.fecha_entrega, L.Titulo, Lec.Nombre +"+" "+ "+ Lec.Apellido as nombreLector, L.Estado as 'Estado del prestamo' " +
                        " from prestamo P, Libro L, Lector Lec" +
                        " where cod_libro = id_libro and cod_lector = id_Lector";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from Libro L " +
                "where L.id_libro = (select top 1 pr.cod_libro from prestamo pr group by pr.cod_libro order by count(pr.cod_libro) DESC) ";

            dataGridView1.DataSource = objeto.consulta(sql1);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Select P.cod_prestamo, P.fecha_prestamo, P.fecha_entrega, L.Titulo, Lec.Nombre +" + " " + "+ Lec.Apellido as nombreLector, L.Estado as 'Estado del prestamo'" +
                        " from prestamo P, Libro L, Lector Lec" +
                        " where cod_libro = id_libro and cod_lector = id_Lector";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fechaEnt = dateTimePicker1.Value.Date.ToShortDateString();

            string sql = "Select P.cod_prestamo, P.fecha_prestamo, P.fecha_entrega, L.Titulo, Lec.Nombre +" + " " + "+ Lec.Apellido as nombreLector, L.Estado as 'Estado del prestamo' " +
                        " from prestamo P, Libro L, Lector Lec" +
                        " where cod_libro = id_libro and cod_lector = id_Lector and fecha_entrega = '"+fechaEnt+"'";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            string sql = "update Libro set Estado = 'Disponible' where id_libro = (select cod_libro from prestamo where cod_prestamo = '" + codigo + "')";
            objeto.consulta(sql);
        }
    }
}

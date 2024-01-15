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
    public partial class RealizarPrestamo : Form
    {
        Consultas objeto = new Consultas();
        public RealizarPrestamo()
        {
            InitializeComponent();
        }

        private void RealizarPrestamo_Load(object sender, EventArgs e)
        {
            ConsultaLibro();
            ConsultaLector();
        }

        public void ConsultaLibro()
        {
            string sql = "select id_libro,Titulo from libro";
            comboBox2.DisplayMember = "Titulo";
            comboBox2.ValueMember = "id_libro";
            comboBox2.DataSource = objeto.consulta(sql);
        }

        public void ConsultaLector()
        {
            string sql = "select id_Lector, Nombre+Apellido as NombreCompleto from lector";
            comboBox1.DisplayMember = "NombreCompleto";
            comboBox1.ValueMember = "id_Lector";
            comboBox1.DataSource = objeto.consulta(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lector = comboBox1.SelectedValue.ToString();
            string libro = comboBox2.SelectedValue.ToString();
            string fechaPre = dateTimePicker1.Value.Date.ToShortDateString();
            string fechaDev = dateTimePicker2.Value.Date.ToShortDateString();

            string sql = "insert into prestamo values (" + "'" + fechaPre + "',"+ "'" + fechaDev+"'," + "'" + libro +"'," + lector +")";
            objeto.ejecutarComando(sql);

            string sql2 = "update Libro set Estado = 'Prestado' where id_libro = '" + libro + "'";
            objeto.ejecutarComando(sql2);

            limpiar();
        }

        private void limpiar()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

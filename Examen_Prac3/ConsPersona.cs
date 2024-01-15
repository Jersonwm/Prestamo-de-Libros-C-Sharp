using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Prac3
{
    public partial class ConsPersona : Form
    {
        Consultas objeto = new Consultas();
        public ConsPersona()
        {
            InitializeComponent();
        }

        private void ConsPersona_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Lector";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lectorM = DateTime.Now.Month.ToString();
            int lectorM2 = Convert.ToInt32( lectorM )+ 1;

            string sql1 = "select distinct L.* " +
                        "from Lector L " +
                        "where L.id_Lector = (select top 1 pr.cod_lector " +
                        "from prestamo pr where pr.fecha_prestamo between '01-"+lectorM+"-2022' and '30-"+Convert.ToString(lectorM2)+"-2022' group by pr.cod_lector order by count(pr.cod_lector) DESC)";

            dataGridView1.DataSource = objeto.consulta(sql1);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Lector";
            dataGridView1.DataSource = objeto.consulta(sql);
            dataGridView1.Refresh();
        }
    }
}

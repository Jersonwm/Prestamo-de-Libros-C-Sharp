using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Prac3
{
    internal class Consultas
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string servidor = "Data source=DESKTOP-68S5K9J\\SQLEXPRESS;";
        string base_de_datos = "Initial Catalog=DOMG_BIBLIOTECA;";
        string usuario = "User ID=sa;Password=123456789;";

        public Consultas()
        {
            con.ConnectionString = servidor + base_de_datos + usuario;
        }
       
        public DataTable consulta(string sql)
        {
            DataTable mitabla = new DataTable();
            adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(mitabla);
            return mitabla;
        }

        public bool ejecutarComando(string sql)
        {
            cmd.CommandText = sql;
            cmd.Connection = this.con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return true;
        }
    }
}
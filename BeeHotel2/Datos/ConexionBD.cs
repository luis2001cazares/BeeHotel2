using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BeeHotel2.Datos
{
    internal class ConexionBD
    {
        SqlConnection SqlCon;



        public void Open()
        {
            try
            {
                string nombre_servidor = Dns.GetHostName();
                SqlCon = new SqlConnection("Data Source=" + nombre_servidor + ";Initial Catalog=HOTEL_LETY;Integrated Security=True");
                SqlCon.Open();
                MessageBox.Show("conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo conectar a la base de datos");
            }
        }

        public void Close()
        {
            SqlCon.Close();
            MessageBox.Show("conexion cerrada");
        }

        public string Cadena()
        {
            return SqlCon.ConnectionString;
        }
    }
}

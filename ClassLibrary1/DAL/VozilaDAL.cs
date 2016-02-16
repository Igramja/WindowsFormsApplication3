using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ClassLibrary1.Model;

namespace ClassLibrary1.DAL
{
    public class VozilaDAL
    {
        public void WriteVozilo(string naziv, decimal cijena, string reg)
        {

            var model = new VoziloModel();
            model.naziv = naziv;
            model.cijenaposatu = cijena;
            model.registracija = reg;
            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO VOZILA ( naziv, cijena, registracija) VALUES (  @naziv, @cijena, @registracija)"); //treba dodati id možda

                /*
                cmd.Parameters.Add("id", SqlDbType.Int);
                cmd.Parameters["id"].Value = model.id ;
                */
                cmd.Connection = connection;

                cmd.Parameters.Add("naziv", SqlDbType.VarChar);
                cmd.Parameters["naziv"].Value = model.naziv;

                cmd.Parameters.Add("cijena", SqlDbType.Decimal);
                cmd.Parameters["cijena"].Value = model.cijenaposatu;

                cmd.Parameters.Add("registracija", SqlDbType.VarChar);
                cmd.Parameters["registracija"].Value = model.registracija;

                if (connection.State != ConnectionState.Open)
                { connection.Open(); }
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static DataTable ReadVozila()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable ds = new DataTable();
                SqlDataAdapter adapter = null;
                adapter = new SqlDataAdapter("SELECT * FROM VOZILA ", connection);

                adapter.Fill(ds);

                return ds;
            }
        }

        public static VoziloModel Read1Vozilo(string a,string b)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var model = new VoziloModel();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = null;
                adapter = new SqlDataAdapter("SELECT * FROM VOZILA WHERE " + a + " = " + b + ";", connection);

                adapter.Fill(dt);

                DataRow row = dt.Rows[0];

                model.id = Convert.ToInt32(row[0]);
                model.naziv = Convert.ToString(row[1]);
                model.cijenaposatu = Convert.ToDecimal(row[2]);
                model.registracija = Convert.ToString(row[3]);              
                
                return model;
            }
        }
    }
}

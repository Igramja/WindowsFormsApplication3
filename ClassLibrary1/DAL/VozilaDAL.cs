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

        public static VoziloModel Read1Vozilo(string a)  //return jedan objekt VoziloModel-a
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var model = new VoziloModel();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = null;
                adapter = new SqlDataAdapter("SELECT * FROM VOZILA WHERE naziv = '" + a + "';", connection);

                adapter.Fill(dt);

                DataRow row = dt.Rows[0];

                model.id = int.Parse(row[0].ToString());
                model.naziv = row[1].ToString();
                model.cijenaposatu = Convert.ToDecimal(row[2].ToString());
                model.registracija = row[3].ToString();              
                
                return model;
            }
        }
    }
}

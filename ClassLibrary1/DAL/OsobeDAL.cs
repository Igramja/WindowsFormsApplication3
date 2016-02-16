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
    public class OsobeDAL
    {

        public void WriteOsoba(string ime, string prezime, string oib)
        {
            
            var model = new OsobaModel();
            model.ime = ime;
            model.prezime = prezime;
            model.oib = oib;
            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO OSOBA ( ime, prezime, oib) VALUES (  @ime, @prezime, @oib)"); //treba dodati id možda

                /*
                cmd.Parameters.Add("id", SqlDbType.Int);
                cmd.Parameters["id"].Value = model.id ;
                */
                    cmd.Connection = connection;

                    cmd.Parameters.Add("ime", SqlDbType.VarChar);
                    cmd.Parameters["ime"].Value = model.ime;

                    cmd.Parameters.Add("prezime", SqlDbType.VarChar);
                    cmd.Parameters["prezime"].Value = model.prezime;

                    cmd.Parameters.Add("oib", SqlDbType.NVarChar);
                    cmd.Parameters["oib"].Value = model.oib;

                    if (connection.State != ConnectionState.Open)
                    { connection.Open(); }
                    cmd.ExecuteNonQuery();
                    connection.Close();
                
            }
        }

        public static DataTable ReadOsobe()
        {   
            
            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                    DataTable ds = new DataTable();
                    SqlDataAdapter adapter = null;
                    adapter = new SqlDataAdapter("SELECT * FROM OSOBA ", connection);

                    adapter.Fill(ds);                           
                        
                    return ds;
            }

        }
        public static OsobaModel Read1Osoba(string a)  //return jedan objekt OsobaModel-a
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var model = new OsobaModel();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = null;
                adapter = new SqlDataAdapter("SELECT * FROM OSOBA WHERE oib = " + a + ";", connection);

                adapter.Fill(dt);

                DataRow row = dt.Rows[0];

                model.id = int.Parse(row[0].ToString());
                model.ime = row[1].ToString();
                model.prezime = row[2].ToString();
                model.oib = row[3].ToString();

                return model;
            }
        }





    }
}

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
    public class EvidencijaDAL
    {
        public void WriteIzn(int osoba, int vozilo, DateTime vrijemeizn)
        {

            var model = new EvidencijaModel();
            model.osoba = osoba;
            model.vozilo = vozilo;
            model.vrijemeizn = vrijemeizn;

            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO EVID ( osoba, vozilo, vrijemeizn ) VALUES (  @osoba, @vozilo, @vrijemeizn )"); 

                
                cmd.Connection = connection;

                cmd.Parameters.Add("osoba", SqlDbType.Int);
                cmd.Parameters["osoba"].Value = model.osoba;

                cmd.Parameters.Add("vozilo", SqlDbType.Int);
                cmd.Parameters["vozilo"].Value = model.vozilo;

                cmd.Parameters.Add("vrijemeizn", SqlDbType.DateTime2);
                cmd.Parameters["vrijemeizn"].Value = model.vrijemeizn;



                if (connection.State != ConnectionState.Open)
                { connection.Open(); }
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }


        public void WriteVr(string id, DateTime vrijemevr, decimal cijena)
        {

            var model = new EvidencijaModel();
            
            
            model.vrijemevr = vrijemevr ;
            model.cijena = cijena;

            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("UPDATE EVID SET vrijemevr=@vrijemevr , cijena=@cijena WHERE id = " + id);


                cmd.Connection = connection;

                cmd.Parameters.Add("vrijemevr", SqlDbType.DateTime2);
                cmd.Parameters["vrijemevr"].Value = model.vrijemevr;

                cmd.Parameters.Add("cijena", SqlDbType.Decimal);
                cmd.Parameters["cijena"].Value = model.cijena;
                



                if (connection.State != ConnectionState.Open)
                { connection.Open(); }
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static DataTable ReadEvid()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["Name"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                DataTable ds = new DataTable();
                SqlDataAdapter adapter = null;
                adapter = new SqlDataAdapter("SELECT EVID.id AS 'id', OSOBA.ime AS 'ime', OSOBA.prezime AS 'prezime' ,OSOBA.oib AS 'oib', VOZILA.naziv AS 'naziv', VOZILA.registracija AS 'registracija', EVID.vrijemeizn AS 'vrijemeizn', EVID.vrijemevr AS 'vrijemevr', EVID.cijena AS 'cijena' FROM EVID INNER JOIN OSOBA ON EVID.osoba = OSOBA.id INNER JOIN VOZILA ON EVID.vozilo = VOZILA.id; ", connection);
                adapter.Fill(ds);

                //ovdje treba izmjeniti SQL naredbu tako da evid_osoba bude ime i prezime osoba i evid_vozila bude naziv vozila

                return ds;
            }

        }


    }
}

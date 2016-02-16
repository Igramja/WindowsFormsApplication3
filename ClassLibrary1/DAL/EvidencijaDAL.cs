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
        public void WriteOsoba(string ime, string prezime)
        {

            var model = new EvidencijaModel();
            model.ime = ime;
            model.prezime = prezime;
            
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

                

                if (connection.State != ConnectionState.Open)
                { connection.Open(); }
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL;
using System.Data;
using System.Windows.Forms;

namespace ClassLibrary1.ViewModel
{
     public class EvidencijaViewModel
    {
        public static string izracunnajma(string a, string b) // a je unos u textbox, b je iz comboboxa
        {
            decimal sati = Convert.ToDecimal(a);
            decimal cijena = VozilaDAL.Read1Vozilo(b).cijenaposatu;
            return Convert.ToString(sati * cijena);

        }

        public void unosIzn(int osoba, int vozilo, DateTime vrijemeizn)
        {
            var novi = new EvidencijaDAL();
            novi.WriteIzn(osoba, vozilo, vrijemeizn);           

        }
        public void unosVr(string id, DateTime vrijemevr, decimal cijena)
        {
            var novi = new EvidencijaDAL();
            novi.WriteVr(id, vrijemevr, cijena);
        }
        public static DataTable ispisEvid()
        {
            return EvidencijaDAL.ReadEvid();
        }
    }
        
}

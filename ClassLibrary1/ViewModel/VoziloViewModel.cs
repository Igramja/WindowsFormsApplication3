using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL;
using ClassLibrary1.Model;
using System.Data;
using System.Windows.Forms;

namespace ClassLibrary1.ViewModel
{
    public class VoziloViewModel
    {
        public void unesiVozilo(string naziv, decimal cijena, string reg)
        {
            var vozilo = new VozilaDAL();

            vozilo.WriteVozilo(naziv, cijena, reg);


        }
        public static DataTable ispisVozila()
        {
            return VozilaDAL.ReadVozila();
        }
        public static decimal cijenaauta(string a)
        {
            decimal cijena = VozilaDAL.Read1Vozilo(a).cijenaposatu;
            return cijena;           

        }

    }
}

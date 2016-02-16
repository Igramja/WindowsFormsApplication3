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
    public class OsobaViewModel
    {
        public void unesiOsobu(string ime, string prezime, string oib)
        {
            
            var osoba = new OsobeDAL();
            osoba.WriteOsoba(ime, prezime, oib);
            
             
        }
        public static DataTable ispisOsoba()
        {
            return OsobeDAL.ReadOsobe();
        }
        
    }
}

public class oib
{
    public static bool CheckOIB(string oib)
    {
        if (oib.Length != 11) return false;

        long b;
        if (!long.TryParse(oib, out b)) return false;

        int a = 10;
        for (int i = 0; i < 10; i++)
        {
            a = a + Convert.ToInt32(oib.Substring(i, 1));
            a = a % 10;
            if (a == 0) a = 10;
            a *= 2;
            a = a % 11;
        }
        int kontrolni = 11 - a;
        if (kontrolni == 10) kontrolni = 0;

        return kontrolni == Convert.ToInt32(oib.Substring(10, 1));
    }
}
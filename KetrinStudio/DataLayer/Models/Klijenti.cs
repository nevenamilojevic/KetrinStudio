using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Klijenti
    {
        public int Id_Klijent { get; set; }
        public String ImeK { get; set; }
        public String PrezimeK { get; set; }
        public  String BrojTelefonaK { get; set; }
        public String Email { get; set; }
        public DateTime DatumTretaman { get; set; }

    }
}

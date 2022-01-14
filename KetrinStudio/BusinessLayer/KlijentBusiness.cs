using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KlijentBusiness
    {
        readonly KlijentRepository klijentRepositoriy = new KlijentRepository();
        public List<Klijenti> GetAllKlijenti()
        {

            return klijentRepositoriy.GetAllKlijenti();

        }
        public bool InsertKlijent(Klijenti k)
        {
            return klijentRepositoriy.InsertKlijent(k) != 0;
        }
    }
}

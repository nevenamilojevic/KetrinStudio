using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FrizerBusiness
    {
        readonly FrizerRepository frizerRepositoriy = new FrizerRepository();
        public List<Frizeri> GetAllFrizeri()
        {

            return frizerRepositoriy.GetAllFrizeri();

        }
    }
}

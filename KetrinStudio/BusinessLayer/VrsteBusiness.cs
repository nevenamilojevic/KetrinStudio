using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     public class VrsteBusiness
    {
        readonly VrstaRepository vrstaRepositoriy = new VrstaRepository();
        public List<Vrste> GetAllVrste()
        {

            return vrstaRepositoriy.GetAllVrste();

        }
        
    }
}

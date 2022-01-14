using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class VrstaRepository
    {
        public List<Vrste> GetAllVrste()
        {
            List<Vrste> listToReturn = new List<Vrste>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Vrsta";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                   Vrste vrsta = new Vrste();

                    vrsta.Id_Vrsta = dataReader.GetInt32(0);
                    vrsta.Naziv = dataReader.GetString(1);
                    vrsta.Cena = dataReader.GetDecimal(2);

                    

                    listToReturn.Add(vrsta);
                }


            }

            return listToReturn;
        }

    }
}

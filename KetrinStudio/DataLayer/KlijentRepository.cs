using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KlijentRepository
    {
        public List<Klijenti> GetAllKlijenti()
        {
            List<Klijenti> listToReturn = new List<Klijenti>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Klijent";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Klijenti klijent = new Klijenti();

                    klijent.Id_Klijent = dataReader.GetInt32(0);
                    klijent.ImeK = dataReader.GetString(1);
                    klijent.PrezimeK= dataReader.GetString(2);
                    klijent.BrojTelefonaK = dataReader.GetString(3);
                    klijent.Email = dataReader.GetString(4);
                    klijent.DatumTretaman = dataReader.GetDateTime(5);


                    listToReturn.Add(klijent);
                }


            }

            return listToReturn;
        }
        public int InsertKlijent(Klijenti klijent)
        {
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = String.Format( "INSERT INTO Klijent VALUES ('{0}','{1}','{2}','{3}','{4}')", klijent.ImeK, klijent.PrezimeK, klijent.BrojTelefonaK, klijent.Email, klijent.DatumTretaman );

                return command.ExecuteNonQuery();
            }
        }

    }
}

using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FrizerRepository
    {
        public List<Frizeri> GetAllFrizeri()
        {
            List<Frizeri> listToReturn = new List<Frizeri>();
            using (SqlConnection dataConnection = new SqlConnection(GlobalVariables.connString))
            {
                dataConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM Frizer";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Frizeri frizer = new Frizeri();

                    frizer.Id_Frizer = dataReader.GetInt32(0);
                    frizer.BrojOsiguranja = dataReader.GetString(1);
                    frizer.ImeF = dataReader.GetString(2);
                    frizer.PrezimeF = dataReader.GetString(3);
                    frizer.Adresa = dataReader.GetString(4);
                    frizer.BrojTelefonaF = dataReader.GetString(5);


                    listToReturn.Add(frizer);
                }


            }
            return listToReturn;
        }
    }
}


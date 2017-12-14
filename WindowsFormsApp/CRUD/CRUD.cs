using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTapi;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUD
{
    public class Crud
    {
        public List<Country> ImportCountries()
        {
            List<Country> lCountry = new List<Country>();
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM countries_country_list";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lCountry.Add(new Country()
                        {
                            sCode = (string)oReader["alpha2Code"],
                            sName = (string)oReader["name"],
                            sCapital = (string)oReader["capital"],
                            nPopulation = (int)oReader["population"],
                            fArea = (float)oReader["area"],
                            fLatLng = (float)oReader["latlng"],
                            sRegion = (string)oReader["region"]
                        });
                    }
                }
            }
            return lCountry;
        }
        //public void UpdateUsers(User oUser)
        //{
        //    String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        //    using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
        //    using (DbCommand oCommand = oConnection.CreateCommand()) //zbog memorije se piše unutar using naredbe
        //    {
        //        //string ime = "IME JE " + oUser.sUserFirstName ===> IME JE PERICA
        //        oCommand.CommandText = "UPDATE USERS SET NAME = '" + oUser.sUserFirstName + "', SURNAME = '" + oUser.sUserLastName + "', PASSWORD = '" + oUser.sUserPassword + "' WHERE USER_ID = " + oUser.nUserID;
        //        oConnection.Open();
        //        using (DbDataReader oReader = oCommand.ExecuteReader())
        //        {

        //        }
        //    }
        //}
    }
}

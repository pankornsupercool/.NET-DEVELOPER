using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace Implementation
{
    public class DataAccess
    {

        public List<Person> GetPeopleByLastname(string text, string selectedTable)
        {
            if (selectedTable == "Person")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from Person where Lastname = '{text}'").ToList();
                    return output;
                }
            }
            else if (selectedTable == "LolUniverse")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from LolUniverse where Lastname = '{text}'").ToList();
                    return output;
                }
            }
            else
            {
                return null;
            }

        }

        public List<Person> GetPeopleByCity(string text, string selectedTable)
        {
            if (selectedTable == "Person")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from Person where City = '{text}'").ToList();
                    return output;
                }
            }
            else if (selectedTable == "LolUniverse")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from LolUniverse where City = '{text}'").ToList();
                    return output;
                }
            }
            else
            {
                return null;
            }
        }

        public List<Person> GetPeopleById(string text, string selectedTable)
        {
            Convert.ToInt32(text);
            if (selectedTable == "Person")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from Person where Id = '{text}'").ToList();
                    return output;
                }
            }
            else if (selectedTable == "LolUniverse")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from LolUniverse where Id = '{text}'").ToList();
                    return output;
                }
            }
            else
            {
                return null;
            }
        }

        public List<Person> GetAllPeople(string selectedTable)
        {
            if (selectedTable == "Person")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from Person").ToList();
                    return output;
                }
            }
            else if (selectedTable == "LolUniverse")
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
                {
                    var output = connection.Query<Person>($"select * from LolUniverse").ToList();
                    return output;
                }
            }
            else
            {
                return null;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PhanMemDatVeXeBus
{
    public static class DataAccess
    {
        public static void Push()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("BookerDB")))
            {
                //foreach (GuestModel g in GlobalConfig.Guests)
                //{
                //    string fields = $"{g.Id}, '{g.Name}', '{g.PhoneNumber}', '{g.Username}', '{g.Password}'";
                //    string query = $"insert into GuestTable (Id, Name, Phone, Username, Password) values ({fields})";
                //    connection.Query(query);
                //}
                //foreach (OwnerModel g in GlobalConfig.Owners)
                //{
                //    string fields = $"{g.Id}, '{g.Name}', '{g.PhoneNumber}', '{g.Username}', '{g.Password}'";
                //    string query = $"insert into OwnerTable (Id, Name, Phone, Username, Password) values ({fields})";
                //    connection.Query(query);
                //}
                //foreach (BusModel g in GlobalConfig.Owners)
                //{
                //    string fields = $"{g.Id}, '{g.Name}', '{g.PhoneNumber}', '{g.Username}', '{g.Password}'";
                //    string query = $"insert into OwnerTable (Id, Name, Phone, Username, Password) values ({fields})";
                //    connection.Query(query);
                //}

            }
        }
        /*
        public static List<OwnerModel> Owner_byId(int id)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnVal("BookerDB")))
            {
                //string query = $"select * from People where Name = '{id}'";
                string query = $"select * from OwnerTable where Id = '{id}'";
                var alist = connection.Query<OwnerModel>(query);
                return alist.ToList();
            }
        }
        */
        public static string CnnVal(string name)
        {
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return "Server=(localdb)\\MSSQLLocalDB;Database=Booker;Trusted_Connection=True;";
        }
    }
}

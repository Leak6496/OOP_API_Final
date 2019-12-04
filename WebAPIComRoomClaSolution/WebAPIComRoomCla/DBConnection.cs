using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;
using System.Data.SqlClient;
namespace WebAPIComRoomCla
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string ConnString = @"Server=civapi.database.windows.net;Database=civapi;User Id=civ_user;Password=Monday1330;";
            return new SqlConnection(ConnString);
        }
    }
}
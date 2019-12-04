using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Http;
using WebAPIComRoomCla.Models;
using System.Linq;
using System.Net;
using System.Net.Http;


namespace WebAPIComRoomCla.Controllers
{
    public class RoomsController : ApiController
    {
        // GET: api/Allrooms
        public IEnumerable<Rooms> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Rooms> output = new List<Rooms>();
            try
            {
                conn.Open();


                query = "select Building,RoomNo,Capacity from Room";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new Rooms(rdr.GetValue(0).ToString()
                        ,Int32.Parse(rdr.GetValue(1).ToString())
                        ,Int32.Parse(rdr.GetValue(2).ToString())
                        ));


                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }


            return output;
        }

        // GET: api/Allrooms/5
        public string Get(int id)
        {
            return "value";
        }

       
    }
}

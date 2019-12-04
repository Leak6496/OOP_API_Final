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
    public class RoomwithcomController : ApiController
    {
        // GET: api/Roomwithcom
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


               // query = "Select r.building,r.RoomNo,r.Capacity,c.Number,c.AssembledYear,c.Building,c.RoomNo from Room r INNER JOIN Computer c ON r.RoomNo=c.RoomNo AND r.Building=c.Building";
                query= "select * from Room r where concat(r.building, r.roomno) in (select concat(building, roomno) from computer)";
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

        // POST: api/Allrooms
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Allrooms/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Allrooms/5
        public void Delete(int id)
        {
        }
    }
}

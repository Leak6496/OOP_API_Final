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
    public class UsedroomController : ApiController
    {
        // GET: api/Usedroom
        public IEnumerable<Usedroom> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Usedroom> output = new List<Usedroom>();
            try
            {
                conn.Open();


                query = "Select r.Building,r.RoomNo,r.Capacity,c.ClassCode,c.Name,c.Building,c.RoomNo from Room r INNER JOIN Class c ON r.RoomNo=c.RoomNo AND r.Building=c.Building";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new Usedroom(rdr.GetValue(0).ToString()
                        ,Int32.Parse(rdr.GetValue(1).ToString())
                        ,Int32.Parse(rdr.GetValue(2).ToString())
                        ,(new Classes(rdr.GetValue(3).ToString(),rdr.GetValue(4).ToString()
                        ,rdr.GetValue(5).ToString(),Int32.Parse(rdr.GetValue(6).ToString()))
                        )));


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

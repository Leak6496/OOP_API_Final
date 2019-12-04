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
    public class ComputersController : ApiController
    {
        // GET: api/Allcomputers
        public IEnumerable<Computers> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Computers> output = new List<Computers>();
            try
            {
                conn.Open();


                query = "select * from Computer";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new Computers(
                        Int32.Parse(rdr.GetValue(0).ToString())
                        ,Int32.Parse(rdr.GetValue(1).ToString())
                        , rdr.GetValue(2).ToString()
                        ,Int32.Parse(rdr.GetValue(3).ToString())
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

    }
}

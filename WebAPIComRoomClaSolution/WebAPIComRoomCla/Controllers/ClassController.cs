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
    public class ClassController : ApiController
    {
        // GET: api/AllClasses
        public IEnumerable<Classes> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Classes> output = new List<Classes>();
            try
            {
                conn.Open();


                query = "select * from Class";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new Classes(
                        rdr.GetValue(0).ToString()
                        ,rdr.GetValue(1).ToString()
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
        public IEnumerable<Classes> Get(string id)
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Classes> output = new List<Classes>();
            try
            {
                conn.Open();


                query = "select ClassCode,Name,Building,RoomNo from Class Where Classcode='"+id+"'" ;
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    output.Add(new Classes(
                        rdr.GetValue(0).ToString()
                        , rdr.GetValue(1).ToString()
                        , rdr.GetValue(2).ToString()
                        , Int32.Parse(rdr.GetValue(3).ToString())
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

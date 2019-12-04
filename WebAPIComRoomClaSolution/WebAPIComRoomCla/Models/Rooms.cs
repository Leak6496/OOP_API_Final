using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComRoomCla.Models
{
    public class Rooms
    {
        public string Building { get; set; }

        public int RoomNo { get; set; }
        public int Capacity { get; set; }
       // public virtual Computers Computers { get; set; }
        public Rooms() { }
        public Rooms(string building,int roomno,int capacity)
        {
            Building = building;
            RoomNo = roomno;
            Capacity = capacity;
   
        }

        
        /*
        public Rooms(string building,int roomno, int capacity,Computers computers)
        {
            Building = building;
            RoomNo = roomno;
            Capacity = capacity;
            Computers = computers;

        }
        */
    }
}
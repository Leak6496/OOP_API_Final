using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComRoomCla.Models
{
    public class Usedroom
    {
        public string Building { get; set; }

        public int RoomNo { get; set; }
        public int Capacity { get; set; }
        public virtual Classes Classes { get; set; }
        public Usedroom() { }
        public Usedroom(string building,int roomno, int capacity, Classes classes)
        {
            Building = building;
            RoomNo = roomno;
            Capacity = capacity;
            Classes = classes;
   
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComRoomCla.Models
{
    public class Computers
    {
        public int Number { get; set; }
        public int AssembledYear { get; set; }
        public string Building { get; set; }

        public int RoomNo{get;set;}
        public Computers() { }
        public Computers(int number,int assembledy,string building, int roomno)
        {
            Number = number;
            AssembledYear = assembledy;
            Building = building;
            RoomNo = roomno;
        }
        public Computers(int number, int assembledy)
        {
            Number = number;
            AssembledYear = assembledy;
            
        }
    }
}
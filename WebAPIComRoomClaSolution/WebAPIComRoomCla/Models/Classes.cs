using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComRoomCla.Models
{
    public class Classes
    {
        public string ClassCode { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public int RoomNo{get;set;}
        public Classes() { }
        public Classes(string classcode, string name)
        {
            ClassCode = classcode;
            Name = name;
        }
        public Classes(string classcode,string name,string building, int roomno)
        {
            ClassCode = classcode;
            Name = name;
            Building = building;
            RoomNo = roomno;


        }

       

    }
}
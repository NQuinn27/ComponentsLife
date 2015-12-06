using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentsLife.Models
{
    public class Brakes
    {
        public int ID { get; set; }
        public string notes { get; set; } 
        public int maxKilometers { get; set; }

        public string idString
        {
            get
            {
                return ID.ToString("000");
            }
        }
    }
}
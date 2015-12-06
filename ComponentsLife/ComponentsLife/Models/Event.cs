using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentsLife.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int kilometers { get; set; }
        public int engineId { get; set; }
        public int drivetrainId { get; set; }
        public int suspensionId { get; set; }
        public int brakesId { get; set; }
    }
}
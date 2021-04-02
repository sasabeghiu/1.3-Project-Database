using System;

namespace SomerenModel
{
    public class Activity
    {
        public int ID { get; set; }               //activity ID
        public string Description { get; set; }   //activity description
        public DateTime StartTime { get; set; }   //StartDateTime
        public DateTime EndTime { get; set; }     //EndDateTime
    }
}

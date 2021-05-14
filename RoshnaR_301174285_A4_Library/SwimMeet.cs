using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class SwimMeet
    {
        public PoolType Course { get; set; }
        public DateTime EndDate { get; set; }
        public List<Event> Events { get; }
        public string Name { get; set; }
        public byte NoOfLanes { get; set; }
        public DateTime StartDate { get; set; }
        public void AddEvent(Event anEvent)
        {
            Events.Add(anEvent);
        }
        public void Seed()
        {
            foreach(Event e in Events)
            {
                e.Seed(NoOfLanes);
            }
        }
        public SwimMeet()
        {
            Events=new List<Event>();
            Name = default;
            StartDate = default;
            EndDate = default;
            Course = PoolType.SCM;
            NoOfLanes = 8;
        }
        public SwimMeet(string name, DateTime start, DateTime end, PoolType course, byte noOfLanes)
        {
            Events = new List<Event>();
            Name = name;
            StartDate = start;
            EndDate = end;
            Course = course;
            NoOfLanes = noOfLanes;
        }
        public override string ToString()
        {
            string s = null;
            foreach(Event e in Events)
            {
                s = s + e + "\n";
            }
            return $"Swim Meet Name: {Name}\nFrom-to: {StartDate} to {EndDate}\nPool Type: {Course}\nNo Lanes: {NoOfLanes}\nEvents:" + s;
        }
    }
}

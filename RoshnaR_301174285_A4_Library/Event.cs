using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class Event
    {
        class RegistrantSwims
        {
            public List<Registrant> swimmers;
            public List<Swim> swims;
            public Swim Swim { get; set; }
            public void AddOrUpdate(Registrant swimmer, Swim swim)
            {
                if (swimmers.Contains(swimmer))
                {
                    swims.Insert(swimmers.IndexOf(swimmer), swim);
                }
                else
                {
                    swimmers.Add(swimmer);
                    swims.Add(swim);
                }
            }
            public bool Contains(Registrant swimmer)
            {
                if(swimmers.Contains(swimmer))
                    return true;
                return false;
            }
            public Swim GetSwimmersSwim(Registrant swimmer)
            {
                if (swimmers.Contains(swimmer))
                    return swims[swimmers.IndexOf(swimmer)];
                else
                    throw new Exception("Swimmer has not entered event");
            }
        }
        private RegistrantSwims swimmingEvents;
        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers {
            get
            {
                return swimmingEvents.swimmers;
            }
        }
        public void AddSwimmer(Registrant aSwimmer)
        {
            if (swimmingEvents.Contains(aSwimmer))
                throw new Exception($"{aSwimmer.Name}, {aSwimmer.Id} is already entered");
            else { 
                swimmingEvents.AddOrUpdate(aSwimmer, new Swim());
            }
        }
        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {

            try
            {
                swimmingEvents.swims[swimmingEvents.swimmers.IndexOf(aSwimmer)].Time = DateTime.ParseExact(time, "mm:ss.ff", CultureInfo.InvariantCulture);

            }
            catch (Exception e)
            {

                Console.Out.WriteLine("Swimmer has not entered the event");
            }
        }
        public Event()
        {
            swimmingEvents = new RegistrantSwims();
            swimmingEvents.swimmers = new List<Registrant>();
            swimmingEvents.swims = new List<Swim>();
        }
        public Event(EventDistance distance, Stroke stroke):this()
        {
            Distance = distance;
            Stroke = stroke;
        }
        public void Seed(byte maxLanes)
        {
            for(int i = 0; i < swimmingEvents.swimmers.Count; i++)
            {
                swimmingEvents.swims[i].Heat = (ushort)((i/maxLanes)+1);
                swimmingEvents.swims[i].Lane = (byte)(i % maxLanes+1);
            }
        }
        public override string ToString()
        {
            string s = null; ;
            for (int i = 0; i < swimmingEvents.swimmers.Count; i++) {
                s = s + $"\n\t{swimmingEvents.swimmers[i].Name}";
                if (swimmingEvents.swims[i] == null)
                    s += "No Swims";
                else
                    s += $"{swimmingEvents.swims[i]}";
            }
            return $"\n\t{Distance} {Stroke}\n\tSwimmers:\n" + s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class Swim
    {
        public ushort Heat { get; set; }
        public byte Lane { get; set; }
        public DateTime Time { get; set; }
        public Swim()
        {

        }
        public Swim(ushort heat, byte lane)
        {
            Heat = heat;
            Lane = lane;
        }
        public override string ToString()
        {
            string time;
            string ht;
            if (Time.ToString().Substring(14, 5) == "00:00")
                time = "no time";
            else
                time = Time.ToString().Substring(14,5);

            if (Heat == 0 && Lane == 0)
                ht = "Not seeded/no swim";
            else
                ht = $"H{Heat}L{Lane}";
            return $"\n\t\t{ht}  Time: " + time;
        }
    }
}

using System;
using System.Collections.Generic;

namespace RoshnaR_301174285_A4_Library
{
    public class Club
    {
        Coach coach;
        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; private set; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public List<Registrant> Swimmers { get; } = new List<Registrant>();
        public Coach Coach{ 
            get
            {
                return coach;
            }
            set
            {
                if (value.Club == null) {
                    if (coach != null)
                        coach.Club = null;
                    this.coach = value;
                    coach.Club = this;
                }
                else
                    Console.Out.WriteLine("Coach is assigned to another club");
            }
        }
        public Club()
        {
            ClubNumber = RegistrationNumberGenerator.GetNext();
        }
        public Club(string name, Address anAddress, ulong phoneNumber):this()
        {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
        }
        internal Club(uint regNumber, string name, Address anAddress, ulong phoneNumber): this(name, anAddress, phoneNumber)
        {
            ClubNumber = regNumber;
        }
        public void AddSwimmer(Swimmer aSwimmer)
        {
            if (aSwimmer.Club == null)
            {
                aSwimmer.Club = this;
                
            }
            else
                throw new Exception($"{aSwimmer.Name} already assigned to {aSwimmer.Club.Name}");
        }
        public override string ToString()
        {
            string regList=null;
            string coachName;
            if (Coach == null)
                coachName = "Not assigned";
            else
                coachName = Coach.Name;
                foreach (Swimmer r in Swimmers)
                    regList = regList + "\n\t" + r.Name;
            return $"Name: {this.Name}\n{this.ClubAddress}\nPhone: {this.PhoneNumber}\nReg Number: {this.ClubNumber}\nSwimmers:" + regList+ $"\nCoach: {coachName}";
        }
    }
}
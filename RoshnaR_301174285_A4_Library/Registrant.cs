using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public abstract class Registrant
    {
        protected Club club;
        public Address Address { get; set; }
        public Club Club
        {

            get
            {

                return this.club;
            }
            set
            {
                this.club = value;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public Registrant() {
            Id = RegistrationNumberGenerator.GetNext();
        }
        public Registrant(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber):this()
        {
            this.Address = anAddress;
            this.DateOfBirth = dateOfBirth;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
        internal Registrant(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber):this(name,dateOfBirth,anAddress,phoneNumber)
        {
            
            this.Id = regNumber;
        }
        public override string ToString()
        {
            string club = null;
            if (Club == null)
                club = "Not assigned";
            else
                club = Club.Name;
            return $"Name: {this.Name}\n{this.Address}\nPhone: {this.PhoneNumber}\nDOB: {this.DateOfBirth}\nId: {Id}\nClub: {club}";
        }
    }
}

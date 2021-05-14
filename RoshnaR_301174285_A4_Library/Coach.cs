using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class Coach:Registrant
    {
        public string Credentials { get; set; }
        public Coach(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber, string credentials) : base(name, dateOfBirth, anAddress, phoneNumber)
        {
            Credentials = credentials;
        }
        public override string ToString()
        {
            string club = null;
            if (Club == null)
                club = "Not assigned";
            else
                club = Club.Name;
            return $"Name: {this.Name}\n{this.Address}\nPhone: {this.PhoneNumber}\nDOB: {this.DateOfBirth}\nId: {Id}\nClub: {club}\nCredentials: {Credentials}";
        }
    }
}

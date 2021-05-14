using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class Swimmer:Registrant
    {
        public new Club Club
        {

            get
            {

                return this.club;
            }
            set
            {
                if (club == null)
                {
                    this.club = value;
                    if (!this.club.Swimmers.Contains(this))
                        this.club.Swimmers.Add(this);
                }
                else
                {
                    throw new Exception("Swimmer is registered with a different club");
                }
            }
        }
        public Swimmer():base()
        {

        }
        public Swimmer(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) :base(name, dateOfBirth, anAddress, phoneNumber)
        {

        }
        internal Swimmer(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) :base(regNumber, name, dateOfBirth, anAddress, phoneNumber)
        {

        }
    }
}

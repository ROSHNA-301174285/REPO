using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public struct Address
    {
        public string City;
        public string PostalCode;
        public string Province;
        public string Street;
        public Address(string street, string city, string province, string postalcode)
        {
            City = city;
            PostalCode = postalcode;
            Province = province;
            Street = street;
        }
        public override string ToString()
        {
            return $"Address:\n\t{this.Street}\n\t{this.City}\n\t{this.Province}\n\t{this.PostalCode}";
        }
    }
}

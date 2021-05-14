using System.Collections.Generic;

namespace RoshnaR_301174285_A4_Library
{
    public interface IClubsRepository
    {
        List<Club> Clubs{get;}
        void AddClub(Club aClub);
        Club GetClub(uint regNumber);
        void LoadClubs(string fileName, string delimiter);
        void SaveClubs(string fileName, string delimiter);
    }
}
using System.Collections.Generic;

namespace RoshnaR_301174285_A4_Library
{
    public interface ISwimmersRepository
    {
        IClubsRepository ClubsManager { get; set; }
        List<Swimmer> Swimmers { get; }
        void AddSwimmer(Swimmer aSwimmer);
        Swimmer GetSwimmer(uint regNumber);
        void LoadSwimmers(string fileName, string delimiter);
        void SaveSwimmers(string fileName, string delimiter);
    }
}
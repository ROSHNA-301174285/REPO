using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class ClubsManager : IClubsRepository
    {
        public List<Club> Clubs { get; } = new List<Club>();
        public void AddClub(Club aClub)
        {
            Clubs.Add(aClub);
        }
        private string formatRecord(Club aClub,string delimiter)
        {
            return $"{aClub.ClubNumber}{delimiter}{aClub.Name}{delimiter}{aClub.ClubAddress.Street}{delimiter}{aClub.ClubAddress.City}{delimiter}{aClub.ClubAddress.Province}{delimiter}{aClub.ClubAddress.PostalCode}{delimiter}{aClub.PhoneNumber}";
        }
        public Club GetClub(uint regNumber)
        {
            foreach(Club c in Clubs)
            {
                if (c.ClubNumber == regNumber)
                    return c;
            }
            return null;
        }
        public void LoadClubs(string fileName, string delimiter)
        {
            string line = null;
            FileStream file=null;
            StreamReader reader = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);
                line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        Clubs.Add(processClubRecord(line, delimiter));
                    }
                    catch (Exception ex)
                    {
                        Console.Out.WriteLine(ex.Message);
                    }
                    line = reader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (file != null)
                    file.Close();
            }
        }
        private Club processClubRecord(string aRecord, string delimiter)
        {
            Address addr;
            string[] values;
            values = aRecord.Split(delimiter[0]);
            addr = new Address(values[2], values[3], values[4], values[5]);
            uint regNumber=0;
            if(!uint.TryParse(values[0],out regNumber) || regNumber==0)
                throw new Exception("Invalid club record. Club number is not valid:\n\t" + aRecord);
            ulong phNumber=0;
            if (!ulong.TryParse(values[6], out phNumber) || phNumber==0)
                throw new Exception("Invalid club record. Phone number wrong format:\n\t" + aRecord);

            if (values.Length < 7)
                throw new Exception("Invalid club record. Not enough club fields:\n\t" + aRecord);
            if(values[1]=="")
                throw new Exception("Invalid club record. Invalid club name:\n\t" + aRecord);
            
            foreach(Club c in Clubs)
                if (c.ClubNumber==regNumber)
                    throw new Exception("Invalid club record. Club with the registration number already exists:\n\t" + aRecord);
            return new Club(Convert.ToUInt16(values[0]), values[1], addr, Convert.ToUInt32(values[6]));
        }
        public void SaveClubs(string fileName, string delimiter)
        {
            FileStream file = null;
            StreamWriter writer = null;

            try
            {
                file = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                writer = new StreamWriter(file);
                foreach (Club club in Clubs)
                {
                    writer.WriteLine(formatRecord(club, delimiter));
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                if (file != null)
                    file.Close();
            }
            
        }
    }
}

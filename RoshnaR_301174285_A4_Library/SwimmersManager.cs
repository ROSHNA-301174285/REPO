using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshnaR_301174285_A4_Library
{
    public class SwimmersManager:ISwimmersRepository
    {
        public IClubsRepository ClubsManager { get; set; }
        public List<Swimmer> Swimmers { get; }
        public SwimmersManager(IClubsRepository manager)
        {
            ClubsManager = manager;
            Swimmers=new List<Swimmer>();
        }
        public void AddSwimmer(Swimmer aSwimmer)
        {
            Swimmers.Add(aSwimmer);
            if (ClubsManager.Clubs.Contains(aSwimmer.Club) || aSwimmer.Club == null)
            {

            }
            else
                ClubsManager.Clubs.Add(aSwimmer.Club);
        }
        private string formatRecord(Registrant aSwimmer, string delimiter)
        {
            string s = null;
            if (aSwimmer.Club == null)
                s = "";
            else
                s = aSwimmer.Club.ClubNumber.ToString();
            return $"{aSwimmer.Id}{delimiter}{aSwimmer.Name}{delimiter}{aSwimmer.DateOfBirth}{delimiter}{aSwimmer.Address.Street}{delimiter}{aSwimmer.Address.City}{delimiter}{aSwimmer.Address.Province}{delimiter}{aSwimmer.Address.PostalCode}{delimiter}{aSwimmer.PhoneNumber}{delimiter}{s}";
        }
        public Swimmer GetSwimmer(uint regNumber)
        {
            foreach (Swimmer s in Swimmers)
            {
                if (s.Id == regNumber)
                    return s;
            }
            return null;
        }
        public void LoadSwimmers(string fileName, string delimiter)
        {
            string line = null;
            FileStream file = null;
            StreamReader reader = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);
                try
                {
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            Swimmers.Add(processSwimmerRecord(line, delimiter));
                        }
                        catch (Exception ex)
                        {

                            Console.Out.WriteLine(ex.Message);
                        }
                        line = reader.ReadLine();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            finally
            {
                if(reader != null)
                    reader.Close();
                if (file != null)
                    file.Close();
            }
        }
        private Swimmer processSwimmerRecord(string aRecord, string delimiter)
        {
            
            Address addr;
            string[] values;
            values = aRecord.Split(delimiter[0]);
            addr = new Address(values[3], values[4], values[5], values[6]);
            DateTime dob;
            if(!DateTime.TryParse(values[2], out dob))
                throw new Exception("Invalid Swimmer record. Birth date is invalid:\n\t" + aRecord);
            uint sid;
            if(!uint.TryParse(values[0], out sid))
                throw new Exception("Invalid Swimmer record. Invalid registration number:\n\t" + aRecord);
            ulong phn;
            if(!ulong.TryParse(values[7],out phn))
                throw new Exception("Invalid Swimmer record. Phone number wrong format:\n\t" + aRecord);

            if (values.Length < 9)
                throw new Exception("Invalid Swimmer record. Not enough swimmer fields:\n\t" + aRecord);
            if (values[1] == "")
                throw new Exception("Invalid Swimmer record. Invalid swimmer name:\n\t" + aRecord);
            
            foreach (Swimmer c in Swimmers)
                if (c.Id == sid)
                    throw new Exception("Invalid Swimmer record. Swimmer with the registration number already exists:\n\t" + aRecord);
            Swimmer swimmer;
            swimmer = new Swimmer(sid, values[1], dob, addr, phn);
          //  Club toAssign;
            uint clbnum=0;
            if (uint.TryParse(values[8], out clbnum) && clbnum != 0)
            {
                foreach (Club clb in ClubsManager.Clubs)
                {
                    if (clbnum == clb.ClubNumber)
                        swimmer.Club = clb;
                }
            }
            
            return swimmer;
        }
        public void SaveSwimmers(string fileName, string delimiter)
        {
            FileStream file=null;
            StreamWriter writer = null;
            try
            {
                file = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                writer = new StreamWriter(file);
                foreach (Swimmer swimmer in Swimmers)
                {
                    writer.WriteLine(formatRecord(swimmer, delimiter));
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            finally
            {
                if(writer != null)
                    writer.Close();
                if (file != null)
                    file.Close();
            }
        }
    }
}

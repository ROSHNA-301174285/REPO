using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoshnaR_301174285_A4_Library;

namespace RoshnaR_301174285_A4
{
    public partial class Form1 : Form
    {
        IClubsRepository clbMngr = new ClubsManager();
        ISwimmersRepository swmMngr;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLoadClubs_Click(object sender, EventArgs e)
        {
            try
            {
                clbMngr.LoadClubs(clubsFilePath.Text, ",");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < clbMngr.Clubs.Count; i++)
            {
                listClubs.Items.Add(clbMngr.Clubs[i].Name);
            }
        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {
            clbMngr.SaveClubs(clubsFilePath.Text, "|");
        }

        private void btnLoadSwimmers_Click(object sender, EventArgs e)
        {
            swmMngr = new SwimmersManager(clbMngr);
            swmMngr.LoadSwimmers(swimmersFilePath.Text, ",");

            for (int i = 0; i < swmMngr.Swimmers.Count; i++)
            {
                listSwimmers.Items.Add(swmMngr.Swimmers[i].Name);
            }
        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {
            if(null == swmMngr)
            {
                swmMngr = new SwimmersManager(clbMngr);
            }
            swmMngr.SaveSwimmers(swimmersFilePath.Text, "|");
        }
    }
}

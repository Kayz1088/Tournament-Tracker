using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            teamSelectDropDown.DataSource = null;
            teamSelectDropDown.DataSource = availableTeams;
            teamSelectDropDown.DisplayMember = "TeamName";

            tournamentTeamsListbox.DataSource = null;
            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizeListBox.DataSource = null;
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "PlaceName";


        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamSelectDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //validate Data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if(!feeAcceptable)
            {
                MessageBox.Show("You Need To enter avalid fee",
                    "Invalid Fee", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            //Create Tournament Model
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            //Create Tournament entry
            //Ceate all the Prizes entry
            //create all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the Create Prize Form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

            
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get a PrizeModel back from the form
            //The the PrizeModel and put it into the list of prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();


        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListbox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);                
                WireUpLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizeListBox.SelectedItem;
            if(p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }

        }
    }
}

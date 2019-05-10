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
    public partial class CreateTeamForm : Form
    {
        ITeamRequester callingForm;
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            //CreateSampleData();

            WireUpList();
        }

        

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "jones" });
        }

        private void WireUpList()
        {
            memberSelectDropDown.DataSource = null;

            memberSelectDropDown.DataSource = availableTeamMembers;
            memberSelectDropDown.DisplayMember = "FullName";

            teamMemberListbox.DataSource = null;

            teamMemberListbox.DataSource = selectedTeamMembers;
            teamMemberListbox.DisplayMember = "FullName";


        }

       

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = phoneNumberValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpList();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                phoneNumberValue.Text = "";
                               
            }
            else
            {
                MessageBox.Show("You Need to fill in all fields");
            }

        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (phoneNumberValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void TeamNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)memberSelectDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList(); 
            }

        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListbox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);


                WireUpList(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            

           GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);

            this.Close();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    { 
         /// <summary>
         /// the list of team members
         /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents The Team Name
        /// </summary>
        public string TeamName { get; set; }

    }
}

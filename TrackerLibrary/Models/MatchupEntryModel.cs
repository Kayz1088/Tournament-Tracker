using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public  class MatchupEntryModel
    {
        /// <summary>
        /// represents the teams in current matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the Score of current matchup
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// represents the Previous matchup for teams competing
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}

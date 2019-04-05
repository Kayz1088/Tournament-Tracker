using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// represents the Teams entered in tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// represents the Winner of tournament
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents  the current round of tournament
        /// </summary>
        public int MatchupRound { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// represents the Placenumber of team in tourament
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// represents the place name for team in tournament
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// represents the monatery prize for team
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// represents the prize amount based on placment in tourament
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}

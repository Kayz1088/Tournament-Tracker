using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// the unquie identifer
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}

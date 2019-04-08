using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// represents the persons first Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// represents the persons last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// represents the persons Email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// represents the persons CellPhone Number
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData.datadefinitions
{
    //Author: Josh, Wei, Johnson
    //Time: May 23, 2019
    // SearchParameters definitions
    // Responsible for storing Information about the SearchParameters passed by the flightsearch page
 
    public class SearchParameters
    {
        public string Location { get; set; }
        public string Destination { get; set; }
        public DateTime? departDt { get; set; }
        public DateTime? returnDt { get; set; }
    }
}

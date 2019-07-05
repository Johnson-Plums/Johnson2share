using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData.datadefinitions
{
    //Author: Josh, Wei, Johnson
    //Time: May 23, 2019
    // FlightsTable data definitions
    // Responsible for storing Information about the FlightsTable

    public class FlightsTable
    {
        public int FlightId { get; set; }
        public int FltPlaneNo { get; set; }
        public DateTime FltDepart { get; set; }
        public DateTime FltReturn { get; set; }
        public string FltLocation { get; set; }
        public string FltDestination { get; set; }
        public string RegionId { get; set; }
        public double FltTicketPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CPRG-214-MA1 Group 4 
//Author: Josh, Wei, Johnson
// May 5, 2019
namespace CPRG214.Marina.Domain
{
    // create a dock class, get variable by setting a value
    public class Dock
    {
        public int DockID { get; set; }
        public string Name { get; set; }
        public bool WaterService { get; set; }
        public bool ElectricalService { get; set; }
    }
}

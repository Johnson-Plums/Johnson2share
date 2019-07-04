using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  // create a Package class 
    public class Packages
    {
        //set variables to be called locally

        private int packageId;
        private string pkgName;
        private DateTime? pkgStartDate; // data can be null
        private DateTime? pkgEndDate; // data can be null if not set
        private string pkgDesc;
        private decimal pkgBasePrice;
        private decimal? pkgAgencyCommission; // data can be null if not set

        //Create an empty constructor
        public Packages() { } 

        //Constructor without data and description for agent
        public Packages(int packagesId, string pkgName, decimal pkgBasePrice, decimal pkgAgencyCommission)
        {
            this.PackageId = packageId;
            this.PkgName = pkgName;
            this.PkgBasePrice = pkgBasePrice;
            this.PkgAgencyCommission = pkgAgencyCommission;
        }

        //Construtor for item identification
        public Packages( string pkgName, decimal pkgBasePrice, decimal pkgAgencyCommission)
        {
            this.PkgName = pkgName;
            this.PkgBasePrice = pkgBasePrice;
            this.PkgAgencyCommission = pkgAgencyCommission;
        }
        // set and pass series values to DB parameters
        public int PackageId
        {
            get
            {
                return packageId;
            }
            set
            {
                packageId = value;
            }
        }

        public string PkgName
        {
            get
            {
                return pkgName;
            }
            set
            {
                pkgName = value;
            }
        }

        public DateTime? PkgStartDate
        {
            get
            {
                return pkgStartDate;
            }
            set
            {
                pkgStartDate = value;
            }
        }

        public DateTime? PkgEndDate
        {
            get
            {
                return pkgEndDate;
            }
            set
            {
                pkgEndDate = value;
            }
        }

        public string PkgDesc
        {
            get
            {
                return pkgDesc;
            }
            set
            {
                pkgDesc = value;
            }
        }

        public decimal PkgBasePrice
        {
            get
            {
                return pkgBasePrice;
            }
            set
            {
                pkgBasePrice = value;
            }
        }

        public decimal? PkgAgencyCommission
        {
            get
            {
                return pkgAgencyCommission;

            }
            set
            {
                pkgAgencyCommission = value;
            }
        }
    }
}

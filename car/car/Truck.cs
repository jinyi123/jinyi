using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
   public  class Truck:vehicle
    {
        public int Load { get; set; }

        public Truck() { }
        public Truck(string Color, double DailyRent, string LicenseNO, string Name, int RentDate, string RentUser, int YearsOfservice,int load) : 
      base(Color, DailyRent, LicenseNO, Name, RentDate, RentUser, YearsOfservice) 
      {
          this.Color = Color;
          this.DailyRent = DailyRent;
          this.LicenseNO = LicenseNO;
          this.Name = Name;
          this.RentDate = RentDate;
          this.RentUser = RentUser;
          this.YearsOfservice = YearsOfservice;
          this.Load = load;
      }
    }
}

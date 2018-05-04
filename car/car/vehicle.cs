using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
   public abstract class vehicle
   {
       public string Color { get; set; }
       public double DailyRent { get; set; }
       public string  LicenseNO { get; set; }
       public string Name { get; set; }
       public int RentDate { get; set; }
       public string RentUser { get; set; }
       public int YearsOfservice { get; set; }

       public vehicle() { }
       public vehicle(string Color, double DailyRent, string LicenseNO, string Name, int RentDate, string RentUser, int YearsOfservice)
       {
          this.Color = Color;
          this.DailyRent = DailyRent;
          this. LicenseNO = LicenseNO;
          this. Name=Name;
          this. RentDate=RentDate;
          this.RentUser=RentUser;
          this.YearsOfservice = YearsOfservice;


       }
   }
}

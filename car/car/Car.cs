using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
  public  class Car : vehicle
    {

      public Car(string Color, double DailyRent, string LicenseNO, string Name, int RentDate, string RentUser, int YearsOfservice) : 
      base(Color, DailyRent, LicenseNO, Name, RentDate, RentUser, YearsOfservice) 
      {
          this.Color = Color;
          this.DailyRent = DailyRent;
          this.LicenseNO = LicenseNO;
          this.Name = Name;
          this.RentDate = RentDate;
          this.RentUser = RentUser;
          this.YearsOfservice = YearsOfservice;
      }

      public Car() { }
    }
}

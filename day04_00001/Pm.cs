using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04_00001
{
  public  class Pm
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Price { get; set; }

        public Pm(string ID,string Name,int Age,string Sex ,int price )
        {
      this. ID = ID;    
      this.Name  =Name ;             
      this.Age =Age    ;             
      this. Sex   =Sex ;             
      this.Price = price; 
           
        }

        public void hello()
        {

            Console.WriteLine("id:{0}\t姓名：{1}\t年龄：{2}\t性别：{3}\t工资：{4}\t" , ID, Name, Age, Sex, Price);
        
        }

    }
}

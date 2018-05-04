using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace questions3
{
  public  class Address
    {
     
  
      public XmlElement loadxml()
      {
          
              XmlDocument doc = new XmlDocument();
              doc.Load("Address.xml");
              XmlElement root = doc.DocumentElement;
          
        
         
         
          return root;
      
      
      }


    }
}

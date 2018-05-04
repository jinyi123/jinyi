using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TV
{
   public class TypeBChannel:ChannelBase
    {
       
        public override void Fetch()
        {
            TvList = new List<TvProgram>();
            XmlDocument doc = new XmlDocument();
            doc.Load("凤凰卫视.xml");
            XmlNode root = doc.DocumentElement;
           
            foreach (XmlNode item in root.ChildNodes)
            {
                foreach (XmlNode child in item.ChildNodes)
                {
                         TvProgram tv = new TvProgram();
                         tv.PlayTime = Convert.ToDateTime(child["playTime"].InnerText);

                         tv.Name = child["name"].InnerText;                        
                         tv.Path = child["path"].InnerText;
                         this.TvList.Add(tv);
                }
                    
                }      
                
            }
        }
    }


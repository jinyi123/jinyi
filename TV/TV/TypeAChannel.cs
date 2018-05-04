using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TV
{
  public  class TypeAChannel:ChannelBase
    {
        public override void Fetch()
        {
            TvList = new List<TvProgram>();
            XmlDocument doc = new XmlDocument();
            doc.Load("北京电视台.xml");
            XmlNode root = doc.DocumentElement;
            
            foreach (XmlNode item in root.ChildNodes)
            {
                if (item.Name=="tvProgramTable")
                {
                    foreach (XmlNode child in item.ChildNodes)
                    {
                        TvProgram tv = new TvProgram();
                         tv.PlayTime = Convert.ToDateTime(child["playTime"].InnerText);
                        
                         tv.ShiDuan = child["meridien"].InnerText;
                      
                         tv.Name = child["programName"].InnerText;
                        
                         tv.Path = child["path"].InnerText;
                         this.TvList.Add(tv);
                          
                        }
                }
               
                   
                }
                
            }

        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TV
{
   public class ChannelManager
    {
       private Dictionary<string ,ChannelBase> allChannel { get; set; } 


       //初始化频道
       public Dictionary<string, ChannelBase> LoadAllChannel()
       {
           allChannel = new Dictionary<string, ChannelBase>();
           XmlDocument doc = new XmlDocument();
           doc.Load("FullChannels.xml");
           XmlNode root = doc.DocumentElement;

           foreach (XmlNode item in root.ChildNodes)
           {
             ChannelBase channel=  ChannelFactory.getinstance(item["channelType"].InnerText);
             channel.ChannelName = item["tvChannel"].InnerText;
             channel.Path = item["path"].InnerText;
             allChannel.Add(channel.ChannelName,channel);
           }
           return allChannel;
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
  public abstract class ChannelBase
    {
        public string ChannelName { get; set; }
        public string Path { get; set; }
        public List<TvProgram> TvList { get; set; }

        public abstract void Fetch();
     
    }
}

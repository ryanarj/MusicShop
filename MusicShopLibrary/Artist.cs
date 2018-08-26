using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopLibrary
{
    public class Artist
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int records { get; set; }

        public Artist()
        {
            records = 1;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopLibrary
{
    public class Store
    {
        public string Name{ get; set; }
        public List<Artist> Artists { get; set; }
        public List<Item> Items { get; set; }
        public Store()
        {
            Artists = new List<Artist>();
            Items = new List<Item>();
        }
    }
}

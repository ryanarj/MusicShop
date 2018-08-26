using MusicShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class MusicShop : Form
    {
        private Store store = new Store();
        public MusicShop()
        {
            InitializeComponent();
        }

        private void SetupData()
        {
            store.Artists.Add(new Artist { firstName = "Jay", lastName = "Z", records = 7 });
            store.Artists.Add(new Artist { firstName = "Nas", lastName = " ", records = 5 });
            store.Artists.Add(new Artist { firstName = "Biggie", lastName = "Smalls" });
        }
    }
}

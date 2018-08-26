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
        BindingSource itemsBinding = new BindingSource();

        public MusicShop()
        {
            InitializeComponent();
            SetupData();

            // Grab the items and place them into the list box
            itemsBinding.DataSource = store.Items;
            musicRecordListBox.DataSource = itemsBinding;
            musicRecordListBox.DisplayMember = "Display";
            musicRecordListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            // Artists
            store.Artists.Add(new Artist { firstName = "Jay", lastName = "Z", records = 7 });
            store.Artists.Add(new Artist { firstName = "Nas", lastName = " ", records = 5 });
            store.Artists.Add(new Artist { firstName = "Biggie", lastName = "Smalls" });
            
            // The artists albums
            store.Items.Add(new Item { Title = "The Blueprint", Artist = store.Artists[0], Description = "Great Album", Price = 9.99M });
            store.Items.Add(new Item { Title = "Illmatic", Artist = store.Artists[1], Description = "Great Album", Price = 9.99M });
            store.Items.Add(new Item { Title = "Ready to Die", Artist = store.Artists[2], Description = "Great Album", Price = 9.99M });

            // Name of the store
            store.Name = "Hip Hop Nation";
        }
    }
}

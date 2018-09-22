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
        private List<Item> shopCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource storeBinding = new BindingSource();

        public MusicShop()
        {
            InitializeComponent();
            SetupData();

            // Grab the items and place them into the list box
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            musicRecordListBox.DataSource = itemsBinding;
            musicRecordListBox.DisplayMember = "Display";
            musicRecordListBox.ValueMember = "Display";

            cartBinding.DataSource = shopCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            storeBinding.DataSource = store.Artists;
            musicRecordListBox.DataSource = storeBinding;
            musicRecordListBox.DisplayMember = "";
            musicRecordListBox.ValueMember = "";
        }

        private void SetupData()
        {
            // Artists
            store.Artists.Add(new Artist { firstName = "Jay", lastName = "Z", records = 7 });
            store.Artists.Add(new Artist { firstName = "Nas", lastName = " ", records = 5 });
            store.Artists.Add(new Artist { firstName = "Biggie", lastName = "Smalls" });
            
            // The artists albums
            store.Items.Add(new Item { Title = "The Blueprint", Artist = store.Artists[0], Description = "Great Album", Price = 15.99M });
            store.Items.Add(new Item { Title = "Illmatic", Artist = store.Artists[1], Description = "Great Album", Price = 9.99M });
            store.Items.Add(new Item { Title = "Ready to Die", Artist = store.Artists[2], Description = "Great Album", Price = 11.99M });

            // Name of the store
            store.Name = "Hip Hop Nation";
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            // Select item and transfer it to shopping cart list box
            Item selectedItem = (Item)musicRecordListBox.SelectedItem;
            shopCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            foreach (Item item in shopCartData)
            {
                item.Sold = true;
            }
            shopCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }
    }
}

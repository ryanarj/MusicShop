using MusicShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MusicShop
{
    public partial class MusicShop : Form
    {
        DirectoryInfo parentFolder;
        XmlNodeList nodes;
        List<string> recordIds = new List<string>();
        string userID;
        public MusicShop(string id)
        {
            InitializeComponent();
            userID = id;
            string expath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            parentFolder = Directory.GetParent(expath);
            SetupData();

            foreach(XmlNode node in nodes)
            {
                musicRecordListBox.Items.Add(node["recordName"].InnerText + " by " + node["artist"].InnerText + " at " + node["price"].InnerText);
                recordIds.Add(node["recId"].InnerText);
            }
           
        }

        private void SetupData()
        {
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Records.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            nodes = xdoc.GetElementsByTagName("Record");
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            int index = musicRecordListBox.Items.IndexOf(musicRecordListBox.SelectedItem);
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Purchase.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNode purchase = doc.CreateElement("Purchase");
            XmlNode userNode = doc.CreateElement("uid");
            XmlNode record = doc.CreateElement("rid");

            userNode.InnerText = userID;
            record.InnerText = recordIds[index];

            purchase.AppendChild(userNode); purchase.AppendChild(record);
            doc.DocumentElement.AppendChild(purchase);
            doc.Save(fileName);
            MessageBox.Show("Purchase complete");
        }
    }
}

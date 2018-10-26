using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace MusicShop
{
    public partial class MusicShop : Form
    {
        DirectoryInfo parentFolder;
        XmlNodeList nodesRecords;
        XmlNodeList nodesViewing;
        List<string> recordIds = new List<string>();
        List<Panel> panels = new List<Panel>();
        string userID;
        public MusicShop(string id)
        {
            InitializeComponent();
            userID = id;
            string expath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            parentFolder = Directory.GetParent(expath);
            SetupData();
            SetupViewingData();

            foreach (XmlNode node in nodesRecords)
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
            nodesRecords = xdoc.GetElementsByTagName("Record");
        }

        private void SetupViewingData()
        {
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Purchase.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            nodesViewing = xdoc.GetElementsByTagName("Purchase");
        }

        private void SetupViewing()
        {
            foreach (XmlNode node in nodesViewing)
            {
                foreach (XmlNode rNode in nodesRecords)
                {
                    if (node["uid"].InnerText.Equals(userID) && node["rid"].InnerText.Equals(rNode["recId"].InnerText))
                    {
                        viewListingBox.Items.Add(rNode["recordName"].InnerText + " by " + rNode["artist"].InnerText + " at " + rNode["price"].InnerText + " TNo. " + node["pid"].InnerText);
                    }
                }

            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            if (musicRecordListBox.Items.Count == 0)
            {
                MessageBox.Show("No items avaiable!");
            }
            else
            {
                int index = musicRecordListBox.Items.IndexOf(musicRecordListBox.SelectedItem);
                string path = parentFolder.FullName;
                string fileName = path.Substring(0, path.Length - 3) + "Purchase.xml";
                int pidUni = 0;
                bool found = false;
                using (RNGCryptoServiceProvider RCSP = new RNGCryptoServiceProvider())
                {
                    byte[] random = new byte[5];
                    RCSP.GetBytes(random);
                    pidUni = BitConverter.ToInt32(random, 0);
                }
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);

                foreach (XmlNode node in nodesViewing)
                {
                    if (node["rid"].InnerText.Equals(recordIds[index]))
                    {
                        found = true;
                        MessageBox.Show("Purchase already");
                    }
                }

                if (found == false)
                {
                    XmlNode purchase = doc.CreateElement("Purchase");
                    XmlNode userNode = doc.CreateElement("uid");
                    XmlNode record = doc.CreateElement("rid");
                    XmlNode pid = doc.CreateElement("pid");

                    userNode.InnerText = userID;
                    record.InnerText = recordIds[index];
                    pid.InnerText = Math.Abs(pidUni).ToString();

                    purchase.AppendChild(userNode); purchase.AppendChild(record); purchase.AppendChild(pid);
                    doc.DocumentElement.AppendChild(purchase);
                    doc.Save(fileName);
                    MessageBox.Show("Purchase complete");
                    SetupViewing();
                    SetupViewingData();
                }
            }
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
            SetupViewing();
            SetupViewingData();

        }

        private void MusicShop_Load(object sender, EventArgs e)
        {
            panels.Add(panelPurchase);
            panels.Add(panelViewPurchase);
            panels[0].BringToFront();
        }

        private void buyMoreBtn_Click(object sender, EventArgs e)
        {
            panels[0].BringToFront();
            viewListingBox.Items.Clear();
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            string path = parentFolder.FullName;
            bool isFound = false;
            string fileName = path.Substring(0, path.Length - 3) + "Purchase.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            XmlNodeList nodes = xdoc.GetElementsByTagName("Purchase");

            string[] clist = viewListingBox.Items.OfType<string>().ToArray();
            if (clist.Length == 0)
            {
                MessageBox.Show("No items available");
            }
            else
            {

                int index = viewListingBox.Items.IndexOf(viewListingBox.SelectedItem);
                string[] str = clist[index].Split();
                string pid = str[str.Length - 1];
                for (int i = 0; i < nodes.Count; i++)
                {
                    if (nodes[i]["pid"].InnerText.Equals(pid))
                    {

                        nodes[i].ParentNode.RemoveChild(nodes[i]);
                        MessageBox.Show("Order has been canceled.");
                        isFound = true;
                        xdoc.Save(fileName);
                    }
                }
                if (!isFound)
                {
                    MessageBox.Show("Cannot find order!");
                }
                SetupViewingData();
            }
        }
    }
}

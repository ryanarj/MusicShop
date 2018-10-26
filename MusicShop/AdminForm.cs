using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace MusicShop
{
    public partial class AdminForm : Form
    {
        List<Panel> listPanel = new List<Panel>();
        DirectoryInfo parentFolder;
        public AdminForm()
        {
            string expath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            parentFolder = Directory.GetParent(expath);
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            viewRecordLB.Items.Clear();
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Records.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            XmlNodeList nodes = xdoc.GetElementsByTagName("Record");

            for (int i = 0; i < nodes.Count; i++)
            {
                viewRecordLB.Items.Add(nodes[i]["recordName"].InnerText + " ID: " + nodes[i]["recId"].InnerText);
            }
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelAddRecord.Visible = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelAdminMenu);
            listPanel.Add(panelAdminDeleteRecord);
            listPanel.Add(panelAddRecord);
            listPanel.Add(panelViewRecords);
            listPanel[0].BringToFront();
        }

        private void addRecordPanelBtn_Click(object sender, EventArgs e)
        {

            int rid = 0;
            using (RNGCryptoServiceProvider RCSP = new RNGCryptoServiceProvider())
            {
                byte[] random = new byte[5];
                RCSP.GetBytes(random);
                rid = BitConverter.ToInt32(random, 0);
            }

            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Records.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNode record = doc.CreateElement("Record");
            XmlNode recId = doc.CreateElement("recId");
            XmlNode artist = doc.CreateElement("artist");
            XmlNode recordName = doc.CreateElement("recordName");
            XmlNode price = doc.CreateElement("price");

            artist.InnerText = artistNameTB.Text.Trim();
            recordName.InnerText = artistRecordNameTB.Text.Trim();
            price.InnerText = artistRecordPriceTB.Text.Trim();
            recId.InnerText = Math.Abs(rid).ToString().Substring(0, 5);


            record.AppendChild(artist); record.AppendChild(recordName); record.AppendChild(price); record.AppendChild(recId);
            doc.DocumentElement.AppendChild(record);
            doc.Save(fileName);
            MessageBox.Show("New record has been added!!");

            SetupData();
            artistNameTB.Clear();
            artistRecordNameTB.Clear();
            artistRecordPriceTB.Clear();

        }

        private void logoutAdminLbl_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void backCPAddLbl_Click(object sender, EventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelAdminMenu.Visible = true;
        }

        private void backCPViewlbl_Click(object sender, EventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelAdminMenu.Visible = true;
        }

        private void backCPDeleteLbl_Click(object sender, EventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelAdminMenu.Visible = true;
        }

        private void deleteRecordPanelBtn_Click(object sender, EventArgs e)
        {
            string path = parentFolder.FullName;
            bool isFound = false;
            string fileName = path.Substring(0, path.Length - 3) + "Records.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            XmlNodeList nodes = xdoc.GetElementsByTagName("Record");
             
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i]["recId"].InnerText.Equals(recordIdTB.Text))
                {

                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                    MessageBox.Show("Record has been deleted.");
                    isFound = true;
                    xdoc.Save(fileName);
                }
            }
            if (!isFound)
            {
                MessageBox.Show("Cannot find record!");
            }

            for (int n = viewRecordLB.Items.Count - 1; n >= 0; --n)
            {
                if (viewRecordLB.Items[n].ToString().Contains(recordIdTB.Text))
                {
                    viewRecordLB.Items.RemoveAt(n);
                }
            }

            recordIdTB.Clear();
        }

        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelAdminDeleteRecord.Visible = true;
        }

        private void viewRecordBtn_Click(object sender, EventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelViewRecords.Visible = true;
        }
    }
}

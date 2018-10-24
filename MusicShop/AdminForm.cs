using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelAdminMenu);
            listPanel.Add(panelAdminDeleteRecord);
            listPanel.Add(panelAddRecord);
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
            recId.InnerText = Math.Abs(rid).ToString();


            record.AppendChild(artist); record.AppendChild(recordName); record.AppendChild(price); record.AppendChild(recId);
            doc.DocumentElement.AppendChild(record);
            doc.Save(fileName);
            MessageBox.Show("New record has been added!!");
           
        }
    }
}

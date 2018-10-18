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
    public partial class LoginForm : Form
    {
        List<Panel> listPanel = new List<Panel>();
        DirectoryInfo parentFolder;
        public LoginForm()
        {
            string expath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            parentFolder = Directory.GetParent(expath);
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            listPanel[1].BringToFront();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelLogin);
            listPanel.Add(panelRegister);
            listPanel[0].BringToFront();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Users.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode user = doc.CreateElement("User");
            XmlNode username = doc.CreateElement("username");
            username.InnerText = registerUsernameTB.Text.Trim();
            XmlNode password = doc.CreateElement("password");
            if (passwordRegister1TB.Text.Trim().Equals(passwordRegister2TB.Text.Trim()))
            {
                password.InnerText = passwordRegister2TB.Text.Trim();
            }
            else
            {
                MessageBox.Show("Passwords do not match!!");
            }
            XmlNode isAdmin = doc.CreateElement("isAdmin");
            isAdmin.InnerText = "0";

            user.AppendChild(username); user.AppendChild(password); user.AppendChild(isAdmin);
            doc.Save(fileName);
            MessageBox.Show("New user has been added!!");

            listPanel[0].BringToFront();

        }
    }
}

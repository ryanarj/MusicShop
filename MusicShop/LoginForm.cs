using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
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

            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelRegister.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelLogin);
            listPanel.Add(panelRegister);
            listPanel[0].BringToFront();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            int uid = 0;
            using (RNGCryptoServiceProvider RCSP = new RNGCryptoServiceProvider())
            {
                byte[] random = new byte[5];
                RCSP.GetBytes(random);
                uid = BitConverter.ToInt32(random, 0);
            }
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Users.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNode user = doc.CreateElement("User");
            XmlNode username = doc.CreateElement("username");
            username.InnerText = registerUsernameTB.Text.Trim();
            XmlNode uid_node = doc.CreateElement("uid");
            uid_node.InnerText = Math.Abs(uid).ToString();
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

            user.AppendChild(uid_node); user.AppendChild(username); user.AppendChild(password); user.AppendChild(isAdmin);
            doc.DocumentElement.AppendChild(user);
            doc.Save(fileName);
            MessageBox.Show("New user has been added!!");

            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelLogin.Visible = true;

        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            string path = parentFolder.FullName;
            string fileName = path.Substring(0, path.Length - 3) + "Users.xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fileName);
            bool found = false;
            XmlNodeList nodes = xdoc.GetElementsByTagName("User");
            for (int i = 0; i < nodes.Count; i++)
            {

                if (nodes[i]["isAdmin"].InnerXml.Trim().Equals("1") && nodes[i]["username"].InnerXml.Trim().Equals(usernameLoginTB.Text.Trim()) && nodes[i]["password"].InnerXml.Trim().Equals(passwordLoginTB.Text.Trim()))
                {
                    AdminForm af = new AdminForm();
                    af.Show();
                    this.Hide();
                    found = true;
                }
                if (nodes[i]["isAdmin"].InnerXml.Trim().Equals("0") && nodes[i]["username"].InnerXml.Trim().Equals(usernameLoginTB.Text.Trim()) && nodes[i]["password"].InnerXml.Trim().Equals(passwordLoginTB.Text.Trim()))
                {
                    string userid = nodes[i]["uid"].InnerText;
                    string username = nodes[i]["username"].InnerText;
                    MusicShop ms = new MusicShop(userid, username);
                    ms.Show();
                    found = true;
                    this.Hide();
                }
            }

            if (!found)
            {
                MessageBox.Show("No user by those credentials!!");
            }
        }

        private void backLoginLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Panel p in listPanel)
            {
                p.Visible = false;
            }
            panelLogin.Visible = true;
        }
    }
}

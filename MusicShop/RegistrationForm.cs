using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerSubmitBtn_Click(object sender, EventArgs e)
        {
            int uid = 0;
            using (RNGCryptoServiceProvider RCSP = new RNGCryptoServiceProvider())
            {
                byte[] random = new byte[5];
                RCSP.GetBytes(random);
                uid = BitConverter.ToInt32(random, 0);
            }
            string fileName = @"C:\Users\KR\documents\visual studio 2015\Projects\MusicShop\MusicShop\UsersTable.csv";
            string username = registerUsernameTB.Text;
            string password = registerPasswordTB.Text;
            string str = string.Format("{0},{1},{2},{3}", uid, username, password, 0);

            List<string> lines = new List<String>();

            // Open the file and then file the line and then delete it if found.
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            // Split the line by ","
                            string[] split = line.Split(',');
                            // If the user id is in the third position of the array delete the line
                            if (split[1].Contains(username)) {
                                MessageBox.Show("Error Message", "Username exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                string header = "uid,username,password,isAdmin" + Environment.NewLine;
                                File.WriteAllText(fileName, header);
                                File.AppendAllText(fileName, str);
                            }
                        }
                        lines.Add(line);
                    }
                }

                // Add the lines back tot eh file
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (string l in lines)
                        writer.WriteLine(l);
                }
            }
            registerPasswordTB.Clear();
            registerPasswordTB.Clear();
            this.Close();
        }
    }
}

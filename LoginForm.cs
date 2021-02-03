using System;
using System.Windows.Forms;
using System.IO;

namespace LogBook
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            
            string userID = userIDTextBox.Text;
            
            
            if (userID == "")
            {
                MessageBox.Show("Input field is empty. Try again.");
            }
            else 
            {
                string path = $"{Environment.CurrentDirectory}\\employees.csv";
                StreamReader sr = new StreamReader(path);
                string csvLine = sr.ReadLine();
                bool userFound = false;
                while (csvLine != null)
                {

                    string[] substring = csvLine.Split(',');
                    if (substring[0] == userID)
                    {
                        MessageBox.Show("Login success!");
                        userFound = true;
                        new LogbookForm().Show();
                        this.Hide();

                        break;
                    }

                    csvLine = sr.ReadLine();
          
                }

                if (!userFound)
                {
                    MessageBox.Show("User not registered");
                    userIDTextBox.Clear();
                }
                
                sr.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void showRegisterForm()
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void registerHereButton_Click(object sender, EventArgs e)
        {
            showRegisterForm();
        }

    }
}

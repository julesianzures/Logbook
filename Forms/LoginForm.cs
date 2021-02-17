using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using LogBook.Models;



namespace LogBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            
            string employeeID = employeeIdTextBox.Text;

            if (employeeID == String.Empty)
            {
                MessageBox.Show("Input field is empty. Try again.");
            }
            
            else 
            {
                string path = $"{Environment.CurrentDirectory}\\employees.csv";
                
                if (!File.Exists(path))
                {
                    MessageBox.Show("No users found.");
                    File.Create(path).Close();
                }

                using (StreamReader streamReader = new StreamReader(path))
                {
                    string csvLine = streamReader.ReadLine();
                    bool userFound = false;
                    while (csvLine != null)
                    {

                        string[] substring = csvLine.Split(',');
                        if (substring[0] == employeeID)
                        {
                            MessageBox.Show("Login success!");
                            userFound = true;
                            TemporaryStorage.employeeId = Convert.ToInt32(substring[0]);
                            new HomeForm().Show();
                            this.Hide();
                            break;
                        }

                        csvLine = streamReader.ReadLine();

                    }

                    if (!userFound)   
                    {
                        MessageBox.Show("User not registered");
                        employeeIdTextBox.Clear();
                    }
                }
                
            }
        }
        private void registerHereButton_Click(object sender, EventArgs e)
        {
            Form form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void employeeIdTextBox_Enter(object sender, EventArgs e)
        {      
                employeeIdTextBox.Text = null;
                employeeIdTextBox.ForeColor = Color.Black;              
        }

    }
}

using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace LogBook
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        public void RegisterUser()
        {
            string name = nameTextBox.Text;

            if(name == "")
            {
                MessageBox.Show("Input field empty. Try again.");
                return;
            }

            StringBuilder csv = new StringBuilder();
            int id = 1;

            string path = $"{Environment.CurrentDirectory}\\employees.csv";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            
            csv.AppendLine(name);

            StreamReader sr = new StreamReader(path);
            string csvLine = sr.ReadLine();
            while (csvLine != null)
            {
                id++;
                csv.AppendLine(csvLine);
                csvLine = sr.ReadLine();
            }

            sr.Close();

            File.AppendAllText(path, $"{id},{name}{Environment.NewLine}");
            nameTextBox.Clear();
            MessageBox.Show($"You are now registered. ID: {id}");
            //new loginForm().Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void showLoginForm()
        {
            new loginForm().Show();
            this.Hide();
        }
        private void loginInInsteadButton_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }
    }
}

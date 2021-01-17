using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace App_chatting
{
    
    public partial class ntuser : Window
    {
        public ntuser()
        {
            InitializeComponent();
        }
        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        private void login_loaded(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("vars.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
            sr.Close();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (newpasstxt.Password != retyppasswd.Password)
            {
                MessageBox.Show("THE PASSWORD DOES NOT MATCH ");
            }
            else if (users.Contains(newusertxt.Text))
            {
                MessageBox.Show("USERNAME TAKEN :( ");
            }
            else
            {
                using (StreamWriter sw = File.AppendText("vars.txt"))
                {
                    sw.WriteLine(" " + newusertxt.Text + " " + newpasstxt.Password);
                    sw.Close();
                }
                MessageBox.Show("USER ADDED!");

                log_in login = new log_in();
                login.Show();
                Close();
            }

        }

    }
}
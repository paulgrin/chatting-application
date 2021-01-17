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
    
    public partial class log_in : Window
    {
        public log_in()
        {
            InitializeComponent();
        }




        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        private void lego_btn_Click(object sender, RoutedEventArgs e)
        {
            if (users.Contains(usertxt.Text) && pass.Contains(passtxt.Password) && Array.IndexOf(users.ToArray(), usertxt.Text) == Array.IndexOf(pass.ToArray(), passtxt.Password))
            {
                MainWindow main = new MainWindow(usertxt.Text);
                main.Show();
                Close();
            }
            else
                MessageBox.Show("THE USERNAME OR PASSWORD IS INCORRECT");

        }

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

        private void nt_user_Click(object sender, RoutedEventArgs e)
        {
            ntuser ntuser = new ntuser();
            ntuser.Show();
            Close();

        }
    }
}

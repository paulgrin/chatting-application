using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace App_chatting
{
    
    public partial class MainWindow : Window
    {
        public MainWindow(string text)
        {
            InitializeComponent();
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void concreteUserChat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void History_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = History;
            popup_uc.Placement = PlacementMode.Bottom;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "History";
        }

        private void History_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }
    }
}

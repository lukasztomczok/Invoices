using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Invoices_Client.View
{
    /// <summary>
    /// Interaction logic for CompanyView.xaml
    /// </summary>
    public partial class CompanyView : UserControl
    {
        public CompanyView()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Loaded");
        }

        private void Grid_LostFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lost focus");
        }

        private void Grid_Unloaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Unloaded");
        }

        private void UserControl_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Got focus");
        }
    }
}

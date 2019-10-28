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

namespace Invoices_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void companyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DoForm(typeof(View.CompanyView), FormType.Window);
        }

        private void DoForm(Type form, FormType type)
        {
            var f = Activator.CreateInstance(form);
            switch (type)
            {
                case FormType.Window:
                    Window window = new Window();
                    window.Owner = this;
                    window.Content = f;
                    window.Show();
                    break;
                case FormType.Control:
                    break;
                default:
                    break;
            }
        }
    }
}

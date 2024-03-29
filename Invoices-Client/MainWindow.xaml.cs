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
            DoForm(typeof(View.CompanyView), FormType.Control);
        }

        private void DoForm(Type form, FormType type)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            UserControl f = Activator.CreateInstance(form) as UserControl;
            switch (type)
            {
                case FormType.Window:                    
                    Window window = new Window();
                    window.Owner = this;
                    window.Content = f;
                    window.Title= Syncfusion.Windows.Tools.Controls.DocumentContainer.GetHeader(f).ToString();
                    window.Show();
                    break;
                case FormType.Control:
                    this.screen.Items.Add(f);
                    break;
                default:
                    break;
            }
            Mouse.OverrideCursor = null;
        }
    }
}

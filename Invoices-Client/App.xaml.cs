using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Invoices_Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTYzNDE3QDMxMzcyZTMzMmUzME0wdnZ3TmVQajVzVU56bXZwTXBlRGgwTmhMNHlrODY3a25RNDdDVFpzUDg9");
            Syncfusion.SfSkinManager.SfSkinManager.ApplyStylesOnApplication = true;
        }
    }
}

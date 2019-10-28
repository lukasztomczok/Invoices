using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices_Client.Model
{
    public class Company
    {
        private string shortName;

        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

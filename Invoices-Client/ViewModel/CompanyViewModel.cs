using Invoices_Client.Model;
using Invoices_Client.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices_Client.ViewModel
{
    public class CompanyViewModel
    {
        private CompanyRepository _repo = new CompanyRepository();

        public Company Company
        {
            get
            {
                return _repo.Company;
            }
        }
    }
}

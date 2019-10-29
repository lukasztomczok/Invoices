using Invoices_Client.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Invoices_Client.Repository
{
    public class CompanyRepository
    {
        private Company company;
        public Company Company
        {
            get
            {
                if (company == null)
                {


                    company = new Company()
                    {
                        ShortName = "SzWG",
                        Name = "Szpital Wielospecjalistyczny w Gliwicach"
                    };
                }
                return company;
            }
        }
    }
}

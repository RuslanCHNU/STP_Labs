using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace CustomerService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomerList()
        {
            return PopulateCustomerData();
        }

        private List<Customer> PopulateCustomerData()
        {
            List<Customer> lstCustomer = new List<Customer>();

            Customer customer1 = new Customer
            {
                CustomerID = 1,
                FirstName = "John",
                LastName = "Meaney",
                Address = "Chicago"
            };
            lstCustomer.Add(customer1);

            Customer customer2 = new Customer
            {
                CustomerID = 2,
                FirstName = "Peter",
                LastName = "Shaw",
                Address = "New York"
            };
            lstCustomer.Add(customer2);

            return lstCustomer;
        }
    }
}
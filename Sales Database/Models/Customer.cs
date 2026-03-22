using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_Database.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string CreditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudBrinks.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Customers
    {
        public List<Customer> CustomerList { get; set; }
    }
}

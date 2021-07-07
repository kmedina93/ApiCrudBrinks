using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudBrinks.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Detail { get; set; }
        public Customer Customer { get; set; }
    }

    public class Purchases
    {
        public List<Purchase> PurchaseList { get; set; }
    }
}

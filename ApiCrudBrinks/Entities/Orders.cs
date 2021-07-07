using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudBrinks.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Double Price { get; set; }
        public Customer Customer { get; set; }
    }

    public class Orders
    {
        public List<Order> OrderList { get; set; }
    }
}

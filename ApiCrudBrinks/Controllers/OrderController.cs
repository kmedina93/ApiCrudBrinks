using ApiCrudBrinks.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiCrudBrinks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("{idCustomer}")]
        public IActionResult GetOrders(int idCustomer)
        {
            if (idCustomer == 0)
            {
                return NotFound("Error! Usuario no encontrado.");
            }
            else
            {
                //Codigo para consultar ordenes por cliente en base de datos

                Orders orders = new Orders
                {
                    OrderList = new System.Collections.Generic.List<Order> {
                        new Order{Id=1,Date=DateTime.Now,Price=0.0,Customer= new Customer{Id=idCustomer,Name=string.Format("Cliente {0}",idCustomer.ToString()),Address=string.Format("Casa {0}",idCustomer) }  },
                        new Order{Id=2,Date=DateTime.Now,Price=0.0,Customer= new Customer{Id=idCustomer,Name=string.Format("Cliente {0}",idCustomer.ToString()),Address=string.Format("Casa {0}",idCustomer) }  },
                        new Order{Id=3,Date=DateTime.Now,Price=0.0,Customer= new Customer{Id=idCustomer,Name=string.Format("Cliente {0}",idCustomer.ToString()),Address=string.Format("Casa {0}",idCustomer) }  }
                    }
                };
                return Ok(orders);
            }
        }
    }
}

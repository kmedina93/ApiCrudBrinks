using ApiCrudBrinks.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudBrinks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        [HttpGet("{idCustomer}/{datePurchase}")]
        public IActionResult GetPurchases(int idCustomer, DateTime datePurchase)
        {
            if (idCustomer == 0)
            {
                return NotFound("Error! Usuario no encontrado.");
            }
            else
            {
                //Codigo para consultar compras por cliente en base de datos

                Purchases purchases = new Purchases
                {
                    PurchaseList = new System.Collections.Generic.List<Purchase> {
                        new Purchase{Id=1,Date=datePurchase,Detail=string.Format("Detalle de la compra {0}",1),Customer = new Customer{Id=idCustomer,Name=string.Format("Cliente {0}",idCustomer.ToString()),Address=string.Format("Casa {0}",idCustomer) }},
                        new Purchase{Id=2,Date=datePurchase,Detail=string.Format("Detalle de la compra {0}",2),Customer = new Customer{Id=idCustomer,Name=string.Format("Cliente {0}",idCustomer.ToString()),Address=string.Format("Casa {0}",idCustomer) }},
                        new Purchase{Id=3,Date=datePurchase,Detail=string.Format("Detalle de la compra {0}",3),Customer = new Customer{Id=idCustomer,Name=string.Format("Cliente {0}",idCustomer.ToString()),Address=string.Format("Casa {0}",idCustomer) }}
                    }
                };
                return Ok(purchases);
            }
        }
    }
}

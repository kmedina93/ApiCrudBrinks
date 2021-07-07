using ApiCrudBrinks.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiCrudBrinks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpDelete("{idCustomer}")]
        public IActionResult DeleteCustomer(int idCustomer)
        {
            if (idCustomer == 0)
            {
                return NotFound("Error! Usuario no encontrado.");
            }
            else
            {
                //Codigo para eliminar cliente en base de datos
                return Ok(string.Format("El cliente {0] ha sido eliminado.", idCustomer.ToString()));
            }
        }

        [HttpPut("{customer}")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            if (customer.Id == 0)
            {
                return NotFound("Error! Usuario no encontrado.");
            }
            else if (customer.Code.ToString().Length > 10)
            {
                return BadRequest("Error! El código de cliente excede los límites.");
            }
            else if (customer.Name.Length > 100)
            {
                return BadRequest("Error! El nombre de cliente excede los límites.");
            }
            else if (customer.Address.Length > 100)
            {
                return BadRequest("Error! La dirección de cliente excede los límites.");
            }
            else
            {
                // Codigo para actualizar en base de datos

                return Ok(customer);
            }
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (customer.Code.ToString().Length > 10)
            {
                return BadRequest("Error! El código de cliente excede los límites.");
            }
            else if (customer.Name.Length > 100)
            {
                return BadRequest("Error! El nombre de cliente excede los límites.");
            }
            else if (customer.Address.Length > 100)
            {
                return BadRequest("Error! La dirección de cliente excede los límites.");
            }
            else
            {
                // Codigo para insertar en base de datos

                return Ok(customer);
            }
        }
    }
}

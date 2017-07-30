using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaApp.Controllers
{
    public class PizzasController : ApiController
    {
        Pizza[] pizzas = new Pizza[]
        {
            new Pizza { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Pizza { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Pizza { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Pizza> GetAllPizzas()
        {
            return pizzas;
        }

        public IHttpActionResult GetPizza(int id)
        {
            var pizza = pizzas.FirstOrDefault((p) => p.Id == id);
            if (pizza == null)
            {
                return NotFound();
            }
            return Ok(pizza);
        }
    }
}

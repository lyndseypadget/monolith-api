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
            new Pizza { Id = 1, Flavor = Flavor.Cheese.ToString(), PanStyle = PanStyle.Thin.ToString(), Crust = Crust.Original.ToString() },
            new Pizza { Id = 2, Flavor = Flavor.Pepperoni.ToString(), PanStyle = PanStyle.Original.ToString(), Crust = Crust.Original.ToString() },
            new Pizza { Id = 3, Flavor = Flavor.Veggie.ToString(), PanStyle = PanStyle.DeepDish.ToString(), Crust = Crust.WholeWheat.ToString() }
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

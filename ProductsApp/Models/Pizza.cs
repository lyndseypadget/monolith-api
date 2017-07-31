using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public String Flavor { get; set; }
        public String PanStyle { get; set; }
        public String Crust { get; set; }
    }
}
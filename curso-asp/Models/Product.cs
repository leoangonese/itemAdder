using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace curso_asp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Observation { get; set; }
    }
}
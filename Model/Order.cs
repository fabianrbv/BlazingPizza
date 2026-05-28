using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BlazingPizza
{
    public class Order
    {
        private static readonly CultureInfo ColombiaCulture = new CultureInfo("es-CO");

        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("C3", ColombiaCulture);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Isnew { get; set; }
        public static DateTime PremierDate { get; set; }
        public MenuItems(string name, string description, string price, bool false)
        {
            Name = name;
            Description = description;
            Price = price;
            bool = false;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneRepo
{
    public class MenuItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Ingredients{ get; set; }

        public MenuItems()
        { }
        public MenuItems(int id,string name,double price,string description, string ingredients)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Ingredients = ingredients;
        }
    }
}

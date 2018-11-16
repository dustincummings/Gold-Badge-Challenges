using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Menu
    {
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public int MealNumber { get; set; }
        public decimal MealPrice { get; set; }

        public Menu(int mealNumber, string name, string description, string ingredients, decimal mealPrice)
        {
            MealName = name;
            Description = description;
            Ingredients = ingredients;
            MealNumber = mealNumber;
            MealPrice = mealPrice;
            Ingredients = ingredients;
        }

        public Menu()
        {
            
        }

    }
}

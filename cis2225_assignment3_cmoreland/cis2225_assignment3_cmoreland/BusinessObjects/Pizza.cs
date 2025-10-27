using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis2225_assignment3_cmoreland.BusinessObjects
{
    internal class Pizza
    {
        private string size;
        private string sauceType;
        private string[] ingredientList =
        {
            "Pepperoni", "Bacon", "Sausage", "Ham",
            "Salami", "Prosciutto", "Shrimp", "Meatball"
        };
        private double cost;

        private readonly Dictionary<string, double> sizePrices = new Dictionary<string, double>()
        {
            {"10", 5.00},
            {"12", 8.00},
            {"14", 12.00}
        };

        private const double toppingPrice = 0.75;

        public static List<Pizza> OrderList = new List<Pizza>();

        public Pizza() { }

        public Pizza(string size, string sauceType, string[] ingredientList)
        {
            this.size = size;
            this.sauceType = sauceType;
            this.ingredientList = ingredientList;
            CalculateCost();
        }

        private void CalculateCost()
        {
            if  (sizePrices.ContainsKey(size))
            {
                cost = sizePrices[size] + (ingredientList.Length * toppingPrice);
            } else
            {
                cost = ingredientList.Length * toppingPrice;
            }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string SauceType
        {
            get { return sauceType; }
            set { sauceType = value; }
        }

        public string[] IngredientList
        {
            get { return ingredientList; }
            set { ingredientList = value; }
        }

        public double Cost
        {
            get { return cost; }
        }

        public override string ToString()
        {
            return $"{Size}\" Pizza - {SauceType} Sauce - " +
                   $"{string.Join(", ", ingredientList)} - Total: {Cost:C}";
        }
    }
}
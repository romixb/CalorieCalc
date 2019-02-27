using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalorieCalc.DTO
{
    public class ObjectStorage
    {

        public static Dictionary<int, Parameter> Parameters = new Dictionary<int, Parameter>();

        public static Dictionary<int, CalorieLimit> Calories = new Dictionary<int, CalorieLimit>();

        public static Dictionary<LifeStyle, double> LifeStyleRate = new Dictionary<LifeStyle, double>()
        {
            {LifeStyle.Active, 1.7 },
            {LifeStyle.Inactive, 1.2 },
            {LifeStyle.Medium, 1.5 },
            {LifeStyle.Very_Active, 1.9}

        };

        public static Dictionary<string, Product> Products = new Dictionary<string, Product>()
        {
            {"Big Tasty", new Product{Name = "Big Tasty", Calories = 800, ProdID = 1, Weight = 300 } },
            {"Big Mac", new Product {Name = "Big Mac", Calories = 500, ProdID = 2, Weight = 200 }},
            {"Pizza", new Product {Name = "Pizza", Calories = 260, ProdID = 3, Weight = 500 } },
            {"Sushi", new Product {Name = "Sushi", Calories = 375, ProdID = 4, Weight = 400 } },
            {"Pasta", new Product {Name = "Pasta", Calories = 131, ProdID = 5, Weight = 200 } },
            {"Soup", new Product {Name = "Soup", Calories = 45, ProdID = 6, Weight = 200 } },
            {"Muffin", new Product {Name = "Muffin", Calories = 377, ProdID = 7, Weight = 200 } },
            {"Chicken", new Product {Name = "Chicken", Calories = 101, ProdID = 8, Weight = 200 } },
            {"French fries", new Product {Name = "French fries", Calories = 312, ProdID = 9, Weight = 100 } },
            {"Pumkin pie", new Product {Name = "Pumkin pie", Calories = 243, ProdID = 10, Weight = 200 } },
            {"Bacon sandwich", new Product {Name = "Bacon sandwich", Calories = 215, ProdID = 11, Weight = 250 } },
            {"Pork", new Product {Name = "Pork", Calories = 600, ProdID = 12, Weight = 400 } },
            {"Beef", new Product {Name = "Beef", Calories = 400, ProdID = 13, Weight = 400 } },
            {"Nuggets", new Product {Name = "Nuggets", Calories = 300, ProdID = 14, Weight = 150 } },
            {"Ceazar salad", new Product {Name = "Ceazar salad", Calories = 259, ProdID = 15, Weight = 259 } },

        };

        public static Dictionary<int, Meal> Meal = new Dictionary<int, Meal>()
        {
            {1, new Meal{ Date = new DateTime(2018, 01, 01 ),  MealID = 1, Products = new List<Product>{ Products["Big Mac"] } } }
        };

    }
}

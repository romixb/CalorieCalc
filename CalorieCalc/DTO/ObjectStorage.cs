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

        public static Dictionary<string, Product> Products = new Dictionary<string, Product>();

        public static Dictionary<int, Meal> Meal = new Dictionary<int, Meal>();

    }
}

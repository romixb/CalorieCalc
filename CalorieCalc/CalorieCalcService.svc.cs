using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CalorieCalc.DTO;



namespace CalorieCalc
{
   
    public class CalorieCalcService : ICalorieCalc
    {

        private static int ParameterId = 0;
        private static int MealID = 1;



        public string AddOrUpdateParameters(Parameter parameter)
        {

            parameter.IdField = ParameterId;
            ObjectStorage.Parameters.Add(ParameterId, parameter);
            ParameterId++;

            return "Parameter saved";
        }



        public Dictionary<string, Product> GetAllProducts()
        {
            return ObjectStorage.Products;
        }



        public CalorieLimit GetCalLimits()
        {
            var newLimit = new CalorieLimit();
            if (ObjectStorage.Parameters.Count != 0)
            {
                var param = ObjectStorage.Parameters.Last();

                if (param.Value.Sex == true)
                {
                    newLimit.Limit = (10 * param.Value.Weight + 6.25 * param.Value.Height - 5 * param.Value.Age + 5) * ObjectStorage.LifeStyleRate[param.Value.LifeStyle];
                }
                else
                {
                    newLimit.Limit = (10 * param.Value.Weight + 6.25 * param.Value.Height - 5 * param.Value.Age - 161) * ObjectStorage.LifeStyleRate[param.Value.LifeStyle];
                }
                ObjectStorage.Calories.Add(ParameterId, newLimit);
                return newLimit;
            }
            else
            {
                throw new ArgumentNullException("NO PARAMETER FOUND");
            }
            
        }



        public Meal GetMeal(int id)
        {
            Meal meal;

            try
            {
                meal = ObjectStorage.Meal[id];

            }
            catch (KeyNotFoundException ex)
            {
                throw new KeyNotFoundException("KEY NOT FOUND");
            }
            return meal;
        }

        public Dictionary<int, Parameter> GetParameters()
        {
            return ObjectStorage.Parameters;
        }



        public Product GetProduct(string name)
        {
            Product product;
            try
            {
                product = ObjectStorage.Products[name];

            }
            catch (Exception E)
            {
                throw new KeyNotFoundException("KEY NOT FOUND");
            }
            return product;
        }



        public string SaveMeal(int mealID, List <string> productNames)
        {
            if (ObjectStorage.Meal.ContainsKey(mealID))
            {
                var meal = ObjectStorage.Meal[mealID];

                foreach (string name in productNames)
                {
                    meal.Products.Add(ObjectStorage.Products[name]);
                }

                ObjectStorage.Meal[mealID] = meal;
            }
            else
            {
                var meal = new Meal
                {
                    Date = DateTime.Now,
                    MealID = CalorieCalcService.MealID,
                    Products =new List<Product>(),
                };

                foreach (string name in productNames)
                {
                    meal.Products.Add(ObjectStorage.Products[name]);
                }

                ObjectStorage.Meal.Add(mealID, meal);
            }
            MealID++;

            return $"Meal {mealID} Saved";
            
        }
    }

}

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
        private static int MealID = 0;

        public Parameter AddOrUpdateParameters(Parameter parameter)
        {
            

          
            if (parameter.IdField == -1)
            {
                parameter.IdField = ParameterId;
                ObjectStorage.Parameters.Add(ParameterId, parameter);
                ParameterId++;
            }else
            {
                int id = (int)parameter.IdField;
                if (ObjectStorage.Parameters.ContainsKey(id))
                {
                    ObjectStorage.Parameters[id] = parameter;
                }
                else
                {
                    ObjectStorage.Parameters.Add(ParameterId, parameter);
                    ParameterId++;
                }
                
            }
            return parameter;
        }

        public Dictionary<string, Product> GetAllProducts()
        {
            return ObjectStorage.Products;
        }

        public CalorieLimit GetCalLimits()
        {
            var newLimit = new CalorieLimit();
            var param = ObjectStorage.Parameters[ParameterId];

            if (param.Sex == true){
                newLimit.Limit =  (10 * param.Weight + 6.25 * param.Height - 5 * param.Age + 5) * ObjectStorage.LifeStyleRate[param.LifeStyle];
            }else{
                newLimit.Limit = (10 * param.Weight + 6.25 * param.Height - 5 * param.Age - 161) * ObjectStorage.LifeStyleRate[param.LifeStyle];
            }

            ObjectStorage.Calories.Add(ParameterId, newLimit);
            return newLimit;
        }

        public Meal GetMeal(int id)
        {
            Meal meal;

            try
            {
                meal = ObjectStorage.Meal[id];
            
            }
           catch(Exception e)
            {
                throw new KeyNotFoundException("KEY NOT FOUND");
            }
            return meal;
        }

        public Dictionary <int, Parameter> GetParameters()
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
            catch(Exception E)
            {
                throw new KeyNotFoundException("KEY NOT FOUND");
            }
            return product;
        }

        public Meal SaveMeal(Meal meal)
        {
             ObjectStorage.Meal.Add(meal.MealID, meal);
     
            return meal;
        }
    }

}

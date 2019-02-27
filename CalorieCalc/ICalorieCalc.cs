using CalorieCalc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace CalorieCalc
{
    [ServiceContract]
    public interface ICalorieCalc
    {
        [OperationContract]
        string AddOrUpdateParameters(Parameter parameter);

        [OperationContract]
        Dictionary<int, Parameter> GetParameters();

        [OperationContract]
        CalorieLimit GetCalLimits();

        [OperationContract]
        Meal GetMeal(int id);

        [OperationContract]
        string SaveMeal(int MealId,  List<string> ProductNames );

        [OperationContract]
        Product GetProduct(string name);

        [OperationContract]
        Dictionary<string, Product> GetAllProducts();
        
    }
}


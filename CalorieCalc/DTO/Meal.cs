using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalorieCalc
{
    [DataContract]
    public class Meal
    {
        [DataMember]
        public DateTime Date;

        [DataMember]
        public List<Product> Products;

        [DataMember]
        public int MealID;
    }
}
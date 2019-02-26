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
        [DataMember(IsRequired = true)]
        public DateTime Date { get; set; }

        [DataMember]
        public List<Product> Products { get; set; }

        [DataMember]
        public int MealID { get; set; }
    }
}
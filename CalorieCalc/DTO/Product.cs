using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalorieCalc
{
    [DataContract]
    [Serializable]
    public class Product
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double? Weight { get; set; }

        [DataMember]
        public double? Calories { get; set; }

        [DataMember]
        public int ProdID { get; set; }
    }
}
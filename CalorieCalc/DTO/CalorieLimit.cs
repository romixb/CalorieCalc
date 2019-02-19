using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalorieCalc
{
    [DataContract]
    public class CalorieLimit
    {
        [DataMember]
        public double Limit;

        [DataMember]
        public int AdjustedLimit;
    }
}
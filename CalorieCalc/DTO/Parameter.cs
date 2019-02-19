using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalorieCalc
{
    [DataContract]
    [Serializable]
    public class Parameter
    {
        [DataMember]
        public int? IdField { get; set; } 

        [DataMember]
        public bool? InitEnter { get; set; }

        [DataMember(IsRequired = true)]
        public bool Sex { get; set; }

        [DataMember(IsRequired = true)]
        public int Age { get; set; }

        [DataMember(IsRequired = true)]
        public int Weight { get; set; }

        [DataMember(IsRequired = true)]
        public int Height { get; set; }

        [DataMember(IsRequired = true)]
        public LifeStyle LifeStyle { get; set; }

        [DataMember(IsRequired = true)]
        [OptionalField]
        public DateTime Date;
    }

    [DataContract]
    [Serializable]
    public enum LifeStyle : int
    {
        [EnumMember]
        Very_Active = 0,
        [EnumMember]
        Active = 1,
        [EnumMember]
        Medium = 2,
        [EnumMember]
        Inactive = 3

    }

}

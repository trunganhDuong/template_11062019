using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Extensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class Symbol : Attribute
    {
        public string ClassName { get; set; }
    }
}

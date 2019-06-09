using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum input)
        {
            if (input == null)
            {
                return string.Empty;
            }

            Type type = input.GetType();
            MemberInfo[] memberInfo = type.GetMember(input.ToString());
            if (memberInfo == null || !memberInfo.Any())
            {
                return string.Empty;
            }

            var attrDescription = (DescriptionAttribute)memberInfo[0].GetCustomAttribute(typeof(DescriptionAttribute), false);
            if (attrDescription == null)
            {
                return string.Empty;
            }

            return attrDescription.Description;
        }

        public static string GetSymbolClassName(this UtilitiEnum input)
        {
            if (input == null)
            {
                return string.Empty;
            }

            Type type = input.GetType();
            MemberInfo[] memberInfo = type.GetMember(input.ToString());
            if (memberInfo == null || !memberInfo.Any())
            {
                return string.Empty;
            }

            var attrDescription = (Symbol)memberInfo[0].GetCustomAttribute(typeof(Symbol), false);
            if (attrDescription == null)
            {
                return string.Empty;
            }

            return attrDescription.ClassName;
        }

        public static SelectList ToSelectList(this UtilitiEnum input)
        {
            var result = new List<SelectListItem>();
            var listValue = Enum.GetValues(typeof(UtilitiEnum));
            foreach (var item in listValue)
            {
                result.Add(new SelectListItem(((UtilitiEnum)item).GetDescription(), ((int)item).ToString()));
            }

            return new SelectList(result, "Value", "Text", -1);
        }
    }
}

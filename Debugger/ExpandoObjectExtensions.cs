using System.Collections.Generic;
using System.Dynamic;

namespace Debugger
{
    public static class ExpandoObjectExtensions
    {
        public static void AddProperty(this ExpandoObject expandoObject, string propertyName, object propertyValue)
        {
            var expandoDictionary = expandoObject as IDictionary<string, object>;

            if (expandoDictionary.ContainsKey(propertyName))
            {
                expandoDictionary[propertyName] = propertyValue;
            }
            else
            {
                expandoDictionary.Add(propertyName, propertyValue);
            }
        }
    }
}
using System;
using System.Reflection;

namespace BankLib
{
    public static class Display
    {
        public static void DisplayProp(object obj)
        {
            Type objType = obj.GetType();
            var properties = objType.GetProperties();
            foreach (var property in properties)
            {
                var propValue = property.GetValue(obj);
                var propType = propValue.GetType();
                if (propType == typeof(string) || propType.IsPrimitive)
                {
                    var displayPropertyAttribute = property.GetCustomAttributes<DisplayPropertyAttribute>();
                    if (displayPropertyAttribute != null)
                    {
                        Console.WriteLine($"{displayPropertyAttribute}: {propValue}");
                    }
                }
            }
        }
    }
}

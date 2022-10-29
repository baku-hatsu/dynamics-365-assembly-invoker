using System;

namespace Debugger
{
    public static class TypeExtensions
    {
        public static bool IsNotApplicationPrimitive(this Type type)
        {
            return !type.FullName.Equals(typeof(Guid).FullName)
                && !type.FullName.Equals(typeof(string).FullName)
                && !type.FullName.Equals(typeof(int).FullName)
                && !type.FullName.Equals(typeof(bool).FullName)
                && !type.FullName.Equals(typeof(DateTime).FullName)
                && !type.IsEnum;
        }

        public static Type GetUnderlyingType(this Type type)
        {
            var nullableUnderlyingType = Nullable.GetUnderlyingType(type);

            if (nullableUnderlyingType != null)
            {
                type = nullableUnderlyingType;
            }

            if (type.IsEnum)
            {
                return type;
            }

            if (type.IsGenericType)
            {
                return type.GetGenericTypeDefinition();
            }

            return type;
        }
    }
}
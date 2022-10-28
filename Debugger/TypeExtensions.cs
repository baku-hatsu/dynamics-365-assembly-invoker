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
                && !type.FullName.Equals(typeof(DateTime).FullName);
        }
    }
}
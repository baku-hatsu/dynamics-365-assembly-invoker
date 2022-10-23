using System;

namespace Debugger
{
    public static class CastHelper
    {
        public static object Cast(Type type, string value)
        {
            switch (type)
            {
                case Type guidType when guidType == typeof(Guid):
                case Type nullableguidType when nullableguidType == typeof(Guid?):
                    return Guid.TryParse(value, out Guid guid) ? guid : (Guid?)null;

                case Type dateTimeType when dateTimeType == typeof(DateTime):
                    return DateTime.TryParse(value, out DateTime dateTime) ? dateTime : (DateTime?)null;

                case Type boolType when boolType == typeof(bool):
                    return bool.TryParse(value, out bool boolean) ? boolean : (bool?)null;

                case Type intType when intType == typeof(int):
                    return int.TryParse(value, out int integer) ? integer : (int?)null;

                default:
                    return Convert.ChangeType(value, type);
            }
        }
    }
}
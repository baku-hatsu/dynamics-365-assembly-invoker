using System;

namespace Debugger
{
    public static class TypeHelper
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

        public static object DefaultOf(Type type)
        {
            switch (type)
            {
                case Type guidType when guidType == typeof(Guid):
                case Type nullableguidType when nullableguidType == typeof(Guid?):
                    return default(Guid);

                case Type dateTimeType when dateTimeType == typeof(DateTime):
                    return default(DateTime);

                case Type boolType when boolType == typeof(bool):
                    return default(bool);

                case Type intType when intType == typeof(int):
                    return default(int);

                case Type stringType when stringType == typeof(string):
                    return default(string);

                default:
                    return null;
            }
        }

        public static object NewOf(Type type)
        {
            switch (type)
            {
                case Type guidType when guidType == typeof(Guid):
                case Type nullableguidType when nullableguidType == typeof(Guid?):
                    return Guid.NewGuid();

                case Type dateTimeType when dateTimeType == typeof(DateTime):
                    return DateTime.UtcNow;

                case Type boolType when boolType == typeof(bool):
                    return DefaultOf(boolType);

                case Type intType when intType == typeof(int):
                    return DefaultOf(intType);

                case Type stringType when stringType == typeof(string):
                    return DefaultOf(stringType);

                default:
                    return null;
            }
        }
    }
}
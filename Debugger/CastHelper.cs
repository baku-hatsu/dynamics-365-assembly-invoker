using System;

namespace Debugger
{
    public static class CastHelper
    {
        public static object Cast(Type type, string value)
        {
            switch (type.Name)
            {
                case nameof(Guid):
                    return Guid.TryParse(value, out Guid guid) ? guid : (Guid?)null;

                case nameof(DateTime):
                    return DateTime.TryParse(value, out DateTime dateTime) ? dateTime : (DateTime?)null;

                case nameof(Boolean):
                    return bool.TryParse(value, out bool boolean) ? boolean : (bool?)null;

                default:
                    return Convert.ChangeType(value, type);
            }
        }
    }
}
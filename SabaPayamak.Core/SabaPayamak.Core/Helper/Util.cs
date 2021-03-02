using SabaPayamak.Core.Enum;
using System.ComponentModel;
using System.Reflection;

namespace SabaPayamak.Core.Helper
{
    public static class Util
    {
        public static string ToDescriptionString(this ResultStatus value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}

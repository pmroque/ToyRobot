using System.Globalization;

namespace ToyRobot.Extension
{
    public static class StringExtension
    {
        public static string ToTitleCase(this string value)
        {
           
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            return info.ToTitleCase(value.ToLower());

        }
    }
}

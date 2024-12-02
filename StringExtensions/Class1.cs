using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        // Extension method to check if the string starts with an uppercase letter
        public static bool StartsWithUpperCase(this string str)
        {
            // Check if the string is not null or empty and if the first character is uppercase
            if (string.IsNullOrEmpty(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}



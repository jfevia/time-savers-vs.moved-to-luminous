using System;

namespace TimeSavers.VS.Comments.StringExtensions
{
    internal static class StringExtensionMethods
    {
        public static bool Contains(this string text, string value, StringComparison comparison)
        {
            if (String.IsNullOrEmpty(text) || String.IsNullOrEmpty(value))
                return false;

            int index = text.IndexOf(value, comparison);

            return (index >= 0);
        }

        public static bool StartsWith(this string text, string value, int startIndex, StringComparison comparison = StringComparison.Ordinal)
        {
            if (String.IsNullOrEmpty(text) || startIndex > text.Length || String.IsNullOrEmpty(value))
                return false;

            return (text.IndexOf(value, startIndex, comparison) == startIndex);
        }

        public static string StartsWithOneOf(this string text, string[] strings, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(text) || strings == null || strings.Length == 0)
                return null;

            foreach (string t in strings)
            {
                if (text.StartsWith(t, comparison))
                    return t;
            }

            return null;
        }

        public static string StartsWithOneOf(this string text, int startIndex, string[] strings, StringComparison comparison = StringComparison.Ordinal)
        {
            if (String.IsNullOrEmpty(text) || strings == null || strings.Length == 0)
                return null;

            foreach (string t in strings)
            {
                if (text.StartsWith(t, startIndex, comparison))
                    return t;
            }

            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace E_LEARNING.APPLICATION.Base.Extensions
{
    public static class TrimExtensions
    {
        public static string TrimWhenNotNull(this string input)
        {
            return string.IsNullOrEmpty(input) ? input : input.Trim();
        }

        public static string RemoveSpace(this string input)
        {
            return string.IsNullOrEmpty(input) ? input.TrimWhenNotNull() : Regex.Replace(input, @"\s+", "");
        }
    }
}

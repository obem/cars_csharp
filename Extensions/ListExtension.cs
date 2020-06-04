using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Extensions
{
    /// <summary>
    /// some extensions for lists
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// uses the tostring method to print generic objects to the console
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string ToConsole<T>(this List<T> list)
        {
            string output = string.Empty;

            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(output))
                {
                    output = $"{output}\n";
                }

                output = output + item.ToString();
            }

            return output;
        }
    }
}

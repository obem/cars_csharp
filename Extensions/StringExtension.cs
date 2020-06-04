using System;

namespace Cars.Extensions
{
    /// <summary>
    /// has some extensions for strings
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// converts any string to a generic type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T? ConvertType<T>(this string input) where T : struct
        {
            try
            {
                return (T)Convert.ChangeType(input, typeof(T)); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExreciseParser
{
    public static class Parser
    {
        public static string[] Parse(string Word, string separator)
        {
            if (IsNullOrEmpty(Word))
                return Array.Empty<string>();

            if (IsNullOrEmpty(separator))
                throw new ArgumentException($"{nameof(separator)} Is empty or null !");

            var result= Word.Split(separator);
            return result;

        }
        public static bool IsNullOrEmpty(string s) => (s is null || s == String.Empty) ? true : false;
      
    }
}

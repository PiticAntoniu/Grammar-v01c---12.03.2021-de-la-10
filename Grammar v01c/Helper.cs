using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar_v01c
{
    class Helper
    {
        internal static List<char> UpperLetters(string input)
        {
            HashSet<char> result = new HashSet<char>();

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                result.Add(c);
            }

            return result.ToList();
        }

        internal static List<char> LowerLetters(string input)
        {
            HashSet<char> result = new HashSet<char>();

            foreach (char c in input)
            {
                if (char.IsLower(c))
                    result.Add(c);
            }

            return result.ToList();
        }

        internal static object FormatAsSet(List<char> input)
        {
            // abc => {a,b,c}
            string result = "{";
            foreach (char c in input)
            {
                result += c + ",";
            }

            result = result.Remove(result.Length - 1, 1); // sterge ultima virgula
            result += "}";

            return result;
        }

        internal static string CharListToString(List<char> charList)
        {
            StringBuilder result = new StringBuilder();

            foreach (var c in charList)
            {
                result.Append(c);
            }

            return result.ToString();
        }

        internal static string FormatAsSet(List<char> input, string colorName)
        {
            StringBuilder result = new StringBuilder();
            result.Append("{");
            foreach (char c in input)
            {
                result.Append(Helper.ColoredChar(c, colorName));
                result.Append(Helper.ColoredChar(',',Properties.Resources.DefaultColor));
            }

            result = result.Remove(result.Length - 10, 10); // sterge ultima virgula si spanu'
            result.Append("}");

            return result.ToString();
        }

        private static string ColoredChar(char c, string colorName)
        {
            return $"<span style = \"color:{colorName}\">{c}</ span >";
        }

    }
}

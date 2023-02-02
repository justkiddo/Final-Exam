using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Final_Exam.Classes
{
    internal class IntWorker
    {

        public static string ConvertIntToString(int intValues)
        {
            var res = intValues.ToString().Select(t=>char.Parse(t.ToString()));

            var intToString = new Dictionary<char, string>
        {
            {'0', "ноль"},
            {'1',"один"},
            {'2',"два"},
            {'3' , "три"},
            {'4' , "четыре"},
            {'5' , "пять"},
            {'6' , "шесть"},
            {'7' , "семь"},
            {'8' , "восемь"},
            {'9' , "девять"},
            };

            var convertedString = new List<string>();

            foreach (var c in res)
            {
                if (intToString.ContainsKey(c))
                {
                    convertedString.Add(intToString[c]);
                }
            }

            return string.Join(" ", convertedString);
        }


    }
}

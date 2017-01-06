using System;
using System.Linq;
using System.Text;

namespace RowIndexOfMaxRepeat
{
    internal class Program
    {
        private static void Main()
        {
            int[,] a =
            {
                {1, 3, 6, 1, 1, 6}, //3
                {1, 2, 1, 4, 5, 6}, //5
                {1, 2, 3, 2, 5, 1}, //4
                {1, 2, 1, 4, 2, 6}, //4
                {1, 5, 5, 4, 5, 1}  //3
            };

            var obj = new object[a.GetLength(0)];
            var s = new int[a.GetLength(0)];

            for (var i = 0; i < a.GetLength(0); i++)
            {
                var sb = new StringBuilder();
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    sb.Append(a[i, j] + "*");
                }
                obj[i] = sb.ToString().TrimEnd('*').Split('*');

                s[i] = ((string[])obj[i]).Distinct().Count();
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == s.Min())
                {
                    Console.WriteLine($"Max repetition in {i + 1}-th row");
                }
            }
        }
    }
}
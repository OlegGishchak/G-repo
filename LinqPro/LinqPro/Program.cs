using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinqPro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query = from n in names
                                      select Regex.Replace(n, "[aeiou]", "")

                                      into noVowel
                                      where noVowel.Length > 2
                                      orderby noVowel
                                      select noVowel; 
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol.miscellaneous
{
    public static class Utilities
    {
        public static List<int>Moda(List<int> numbers)
        {
           
            var counters=new Dictionary<int, int>();
            foreach (var item in numbers)
            {
                if(counters.ContainsKey(item))
                {
                    counters[item]++;
                }else
                {
                    counters.Add(item,1 );
                }
                
            }
            foreach (var item1 in counters)
            {
                Console.WriteLine($"{item1.Key}={item1.Value}");
            }
            var maxvalue=counters.Max(x => x.Value);
            Console.WriteLine($" max value={maxvalue}");
           return counters.Where(x => x.Value == maxvalue).Select(x=>x.Key).ToList();
           
           
        }

        public static List<int>fill(int n, int min , int max)
        {
            var random =new Random();
            var numbers=new List<int>();
            max++;
            for (int i = 0; i < n; i++)
            {
                numbers.Add(random.Next(min, max));
            }
            return numbers;
        }
        public static string ToString(List<int> numbers)
        {
            var output = string.Empty;
            foreach (var item in numbers)
            {
                output += $"{item}\t";
            }
         
            return output +"\n";
        }
    }
}

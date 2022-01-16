using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekseevaOlga_ExtensionsTest
{
    //Реализовать метод расширения для поиска количество символов в строке.
    public static class HowManySymbolsInStringExtension
    {
        public static int CharCount(this string str, char symbol)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                    counter++;
            }
            return counter;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            char symbol = 'а';
            int x = str.CharCount(symbol);
            Console.WriteLine($"Буква а в вашей строке встречается:{x} раз") ;
            Console.ReadLine();


        var numbers = new List<int>() { 1, 2, 2, 1, 2, 3 };
        numbers.Sort();
 
        var result = new Dictionary<int, int>();
        for(int i=1;i<numbers.Count;i++)
        {
            if(numbers[i]==numbers[i - 1]) 
            {
            if(!result.Keys.Contains(numbers[i]))
            result.Add(numbers[i],1);
            else result[numbers[i]]++;
            }
            }
            foreach (var y in result.Keys)
            if (result[y] > 1) Console.WriteLine("Число {0} встречается {1} раз.", y, result[y]);
            Console.ReadLine();
        }
    }
}

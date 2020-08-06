using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Task1
    {
        static void Main(string[] args)
        {
            // #1. Дан массив, необходимо заполнить его значениями от 0 до 999 и найти произведение всех нечетных элементов
            int[] numbers = new int[1000];
            int sum = 0;
            for (int i = 0; i < 999; i++)
            {
                numbers[i] = i + 1;
            }
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            // #2. Дан массив символов, необходимо преобразовать его в строку
            char[] symbols = new char[] { 'd', 'o', 'n', 'e' };
            string answer = new string(symbols);
            Console.WriteLine(answer);

            // #3. Даны 2 строки, необходимо зеркально отразить каждую строку и вывести в консоль друг за другом
            string first = "llaF";
            string second = "tuo";

            char[] result = (second + first).ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] emails = new string[]
            {
            "randommail@mail.ru",
            "someoneshere@gmail.by",
            "jackteller@gmail.com",
            "yellow.brick.records@mail.cz",
            "randommail2@mail.ru",
            "kidywalters999@gmail.com",
            "mail.trueman@mail.cz",
            "sol.goodman@gmail.com",
            "alfick.demon.44@mail.gv.cz"
            };

            emails
                .Select(n
                => n.Substring(n.LastIndexOf('@'), n.Length - n.IndexOf('@')))
                .Distinct()
                .ToList()
                .ForEach(Console.WriteLine);


            Console.ReadKey();
        }
    }
}
/*     
[Использовать LINQ]
Необходимо получить список уникальных (без повторений) доменных имен почтовых ящиков из списка почтовых адресов
Доменное имя - правая часть почтового адреса (всё что после @)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> database = new List<User>() {
            new User("Fredie", 20, "Fredie@gmail.com"),
            new User("Lenny", 20, "Lenny@gmail.com"),
            new User("Marco", 23, "Marco@gmail.com"),
            new User("Star", 19, "Star@gmail.com"),
            new User("Kile", 22, "Kile@gmail.com")};

            List<User> olderThen21 = new List<User>();
            olderThen21 = database.Where(n => n.age > 20).ToList();

            foreach (var item in olderThen21)
            {
                Console.WriteLine(item);
            }
            
        }
    }
    class User
    {

        public string name;
        public int age;
        public string email;

        public User(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public override string ToString()
        {
            return $"{name}, {age}, {email}";
        }
    }
}

/*  
 *  substring
        Объявить тип User содержащий:
        • Имя пользователя
        • Возраст
        • Почтовый адрес
        • Конструктор с параметрами

        Создать коллекцию из 5 пользователей

        [Использовать LINQ]
        Создать List<User>, в который добавить только пользователей старше 13 лет и почтовые ящики у которых содержат символ @
*/

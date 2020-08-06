using System;
using System.Linq;
using System.Security.Cryptography;
using Task_2;

namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 1.1
			Console.WriteLine("Enter string: ");
			var userEnter = Console.ReadLine();
			Console.WriteLine("Enter index: ");
			int userIndex = Convert.ToInt32(Console.ReadLine());
			string result = userEnter.CutStringByIndex(userEnter, userIndex);
			Console.WriteLine(result);
			Console.ReadKey();
			*/

            /* 1.2
			Console.WriteLine("Enter string: ");
			var userEnter = Console.ReadLine();
			Console.WriteLine("Enter left index: ");
			int userIndexLeft = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter right index: ");
			int userIndexRight = Convert.ToInt32(Console.ReadLine());
			string result = userEnter.CutStringByTwoParts(userEnter, userIndexLeft, userIndexRight);
			Console.WriteLine(result);
			Console.ReadKey();
			*/

            // 1.3
            /*
			Console.WriteLine("Enter string: ");
			string userEnter = Console.ReadLine();
			Console.WriteLine("Enter number of adding strings: ");
			int userIndex = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[userIndex];
			for (int i = 0; i < userIndex ; i++)
            {
				Console.WriteLine($"Enter {i+1} string of {userIndex} strings: ");
				stringArray[i] = Console.ReadLine();
			}
			userEnter = userEnter.CreateNewString(stringArray);

			Console.WriteLine(userEnter); 
			Console.ReadKey();
			*/

            //1.4
            /*
            Console.WriteLine("Enter string: ");
			string userEnter = Console.ReadLine();
			string s = userEnter.SwitchCase(userEnter);
			Console.WriteLine(s);
			Console.ReadKey();
			*/

            //2
            /*
			int a = 212348787;
            Console.WriteLine(Converter(a));
			Console.ReadKey();
			*/

            //3
            /*Vector3 a = new Vector3(10, 10, 10);
            Vector3 b = new Vector3(10, -10, -10);
            Console.WriteLine(a-b);*/


        }
        public static string Converter(int number)
        {
            int _number = number;
            byte[] byteArray = BitConverter.GetBytes(_number);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(byteArray);
            }
            string result = System.Text.Encoding.UTF8.GetString(byteArray);
            return result;
        }

        //Упаковка (boxing) предполагает преобразование объекта значимого типа (например, типа int) к типу object
        public string Type(Object obj)
        {
            string _result = (string)obj;
            return _result;
        }
    }
    struct Vector3
    {
        double x;
        double y;
        double z;

        public override string ToString()
        {
            return $"{x} {y} {z}";
        }


        public override bool Equals(object obj)
        {
            if (obj is Vector3 vector)
            {
                return vector.x == x;
            }
            return base.Equals(obj);
        }

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

     public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x,
                                a.y + b.y,
                                a.z + b.z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x,
                                a.y - b.y,
                                a.z - b.z);
        }
       
    }

	public static class StringExtensions
	{
		public static string CutStringByIndex(this string str, string userEnter, int userIndex)
		{
			int _userIndex = userIndex;
			string _userEnter = userEnter;

			_userEnter = _userEnter.Substring(_userIndex);
			return _userEnter;
		}

		public static string CutStringByTwoParts(this string str, string userEnter, int userIndexLeft, int userIndexRight)
		{
			string _userEnter = userEnter;
			int _userIndexLeft = userIndexLeft;
			int _userIndexRight = userIndexRight;

			_userEnter = _userEnter.Substring(_userIndexLeft, _userIndexRight);
			return _userEnter;
		}
		public static string CreateNewString(this string str, string[] userArray)
		{
			string result = str;

			for (int i = 0; i < userArray.Length; i++)
			{
				result += userArray[i];
			}

			return result;
		}

		public static string SwitchCase(this string str, string input)
		{
			var _input = input.ToCharArray();
			string result = "";
			for (int i = 0; i < _input.Length; i++)
			{
				if (char.IsLower(_input[i]))
				{
					result += char.ToUpper(_input[i]);
				}
				else
				{
					result += char.ToLower(_input[i]);
				}
			}
			return result;
		}
	}

}

/*
	
	4. 	Создать метод, принимающий любой тип и возвращающий название этого типа в виде строки
	
	5. 	Создать класс Library и структуру Book
		Класс Library должен содержать массив типа Book
		Класс Library должен предоставлять методы:
			• Добавление книги 
				void AddBook(string bookName) 
				void AddBook(Book book)
			• Удаление книги
				void RemoveBook(string bookName)
				void RemoveBook(Book book)
			• Вывод на экран названий всех книг, который на данный момент есть в библиотеке
				void ShowBooks()
			• Метод поиска книги 
				bool IsBookExist(string bookName)
				bool IsBookExist(Book book)
*/

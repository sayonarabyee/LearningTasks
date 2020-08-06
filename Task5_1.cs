using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 v1 = new Vector2(10.2, 52.1);
            Vector2 v2 = new Vector2(10.2, 52.1);
            Console.WriteLine(v1.Equals(v2));
            Console.WriteLine(v1.GetHashCode());
            Console.WriteLine(v2.GetHashCode());
        }
    }
    public class Vector2
    {
        public double x { get; set; }
        public double y { get; set; }
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{x} {y}";
        }

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            //Проверка объекта на null
            if (obj == null)
                return false;
            //возвращает null если объект нельзя привести к типу Vector2
            Vector2 v = obj as Vector2;
            //Проверка объекта класса на null
            if (v as Vector2 == null)
                return false;
            //Проверка равенства
            return v.x == this.x && v.y == this.y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
    }
}
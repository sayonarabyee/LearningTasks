using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Race Elf = new Race("Elf");
            Race Demon = new Race("Demon");
            Race Human = new Race("Human");

            
            


            Database database = new Database(4);

            for (int i = 0; i < 4; i++)
            {
                database.AddPlayers(
                    new Player("Adam", Elf, 30),
                    new Player("Edward", Demon, 56),
                    new Player("Sam", Human, 25),
                    new Player("Elfo", Elf, 241)
                    );
            }

            database.playerList
                .ForEach(Console.WriteLine);
        }
    }

    struct Race
    {

        string name { get; }
        
        public Race(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
    class Player
    {
       
        public Player(string name, Race race, int age)
        {
            this.Race = race;
            this.Age = age;
            this.Name = name;
        }

        public string Name { get; set ; }
        public int Age { get; set; }
        public Race Race { get; private set; }

        public override string ToString()
        {
            return $"{Name}, {Race}, {Age}";
        }

    }

    class Database
    {
        public int maxDatabaseSize;
        public List<Player> playerList = new List<Player>();

        public Database(int dbsize)
        {
            this.maxDatabaseSize = dbsize;
        }

        public void AddPlayers(params Player[] player)
        {
            foreach (var item in player)
            {
                AddPlayer(item);
            }   
        }

        void AddPlayer(Player player)
        {
            if (playerList.Count < maxDatabaseSize)
            {
                playerList.Add(player);
            }
        }
    }





    /*
    Создать структуру Race
    • Свойство Name (только для чтения)
    • Конструктор, инициализирующий Name

    Создать класс Player, содержащий:
    [Информация] Модификаторы доступа и сигнатуру (поле или свойство) выбрать на свое усмотрение
    • Ник
    • Возраст персонажа
    • Раса (тип Race)
    • Конструктор для инициализации полей
    
    Создать класс DataBase
    [Информация] Модификаторы доступа и сигнатуру (поле или свойство) выбрать на свое усмотрение
    • Максимальный размер базы данных (целое число)
    • Коллекция для хранения объектов типа Player
    • Конструктор, инициализирующий максимальный размер базы данных
    • Открытый метод void AddPlayers(X) для добавления игроков. Вместо X — возможность принимать в качестве параметра любое количество объектов типа Player.
        • Учесть в базе данных возможность нехватки места (превышение макс. размера базы)
        • Учесть возможность наличия такого никнейма в базе до его добавления (реализовать с использованием следующего метода)
    • Закрытый метод bool IsNickNameExists(string nickname) возвращающий true если такой ник уже есть в базе, false - иначе

    Main
    • Создать игроков (с произвольными никнеймами, уровнем и расой)
    • Создать базу данных
    • Добавить игроков в базу данных
    [LINQ]
    Сформировать из игроков, находящихся в базе данных, следующие выборки:
    • Игроки одной расы (любая произвольная раса из существующих)
    • Игроки больше X уровня. X выбрать произвольно.
    • Игроки, чьи ники начинаются с определенной (произвольной) буквы
    • Игроки расы X с уровнем не больше чем A и игроки расы Y с уровнем не больше чем B. A, B, X, Y выбрать на свое усмотрение.
*/
}

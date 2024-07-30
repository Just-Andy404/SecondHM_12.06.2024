/*
 Создайте класс «Футбольная команда». Класс должен содержать
информацию об игроках футбольной команды. Реализуйте
поддержку итератора для класса "Футбольная Команда".
Протестируйте возможность использования foreach для класса
«Футбольная команда».
*/
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new List<Player>
            {
                new Player("John", 25),
                new Player("Jane", 22),
                new Player("Mike", 27)
            };

            var team = new Team("The Best Team", players);
            Console.WriteLine(team);

            var newPlayer = new Player("Anna", 24);
            team += newPlayer;
            Console.WriteLine(team);

            team -= "Jane";
            Console.WriteLine(team);

            team -= newPlayer;
            Console.WriteLine(team);
        }
    }
}

using System;

namespace ConsoleApp2
{
    internal class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Player()
        {
            Name = "NoName";
            Age = 0;
        }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}

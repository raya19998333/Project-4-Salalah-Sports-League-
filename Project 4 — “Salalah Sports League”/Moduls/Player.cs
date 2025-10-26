﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4____Salalah_Sports_League_.Moduls
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Player(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, Age: {Age}, Position: {Position}");
        }
    }
}

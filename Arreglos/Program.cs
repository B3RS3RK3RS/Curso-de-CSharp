﻿using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]{
                "Jesus","Gustavo","Anali","Roxana","Frank","Pablo",null
            };

            friends[0] = "Arlandria Michell Nicolle de Jesús";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);

            friends[6] = "Jose";
            Console.WriteLine(friends[6]);
        }
    }
}

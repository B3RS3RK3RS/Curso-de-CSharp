using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]{
                "Arlandria","Jesus","Gustavo","Anali","Roxana","Frank","Pablo"
            };

            bool run = true;
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}

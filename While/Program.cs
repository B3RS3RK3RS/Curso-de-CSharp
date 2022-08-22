using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Iteraccion de i: " + i);
                i++;
            }

            int j = 0;
            while (i < 100)
            {
                if (j > 10)
                    break;
                Console.WriteLine("Iteraccion de j: " + j);
                j++;
            }

            string[] friends = new string[7]{
                "Arlandria","Jesus","Gustavo","Anali","Roxana","Frank","Pablo"
            };

            int index = 0;
            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run = false;
            do
            {
                show();
            } while (run);

            static void show()
            {
                Console.WriteLine("Entro una vez y ya");
            }
        }
    }
}

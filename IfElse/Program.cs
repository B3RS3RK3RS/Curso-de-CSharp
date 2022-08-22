using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tienesHambre = true;
            bool tienesDinero = true;

            if (tienesHambre && tienesDinero && restauranAbierto("24 horass"))
            {
                Console.WriteLine("COME");
            }
            else
            {
                Console.WriteLine("NO COMAS");
            }
        }

        static bool restauranAbierto(string nombre, int hour = 0)
        {
            if (nombre == "Cena Pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(nombre == "24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

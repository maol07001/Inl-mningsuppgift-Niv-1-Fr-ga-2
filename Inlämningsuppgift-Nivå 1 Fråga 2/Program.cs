using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer;

            do
            {
                Console.Write("Skriv in ett heltal: ");
                nummer = int.Parse(Console.ReadLine());

                if (nummer != 0)
                {
                    Console.WriteLine("Testa igen");
                }

            } while (nummer != 0);

            Console.WriteLine("Programmet avslutas. Tack!");
        }
    }
}
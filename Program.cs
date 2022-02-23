using System;
using DIO_RPG_ObjectOriented.src.Entities;

namespace DIO_RPG_ObjectOriented
{
    class Program
    {
        static void Main()
        {
            Hero h1 = new Hero("Juan");

            Console.WriteLine(h1);

            Console.WriteLine(h1.Attack());
        }
    }
}

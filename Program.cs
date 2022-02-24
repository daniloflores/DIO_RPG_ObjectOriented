using System;
using DIO_RPG_ObjectOriented.src.Entities;

namespace DIO_RPG_ObjectOriented
{
    class Program
    {
        static void Main()
        {
            Knight hero1 = new Knight("Agatha");
            WhiteWizard hero2 = new WhiteWizard("Gunther");
            BlackWizard hero3 = new BlackWizard("Aang");
            Ninja hero4 = new Ninja("Naruto");

            Console.WriteLine(hero1);
            Console.WriteLine(hero2);
            Console.WriteLine(hero3);
            Console.WriteLine(hero4);

            Console.WriteLine(hero1.Attack());
        }
    }
}

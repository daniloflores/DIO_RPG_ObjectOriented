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
            Console.WriteLine(hero2.Attack());
            Console.WriteLine(hero3.Attack());
            Console.WriteLine(hero4.Attack());

            //Next:
            //1 - Implement another Attack method with a Bonus, with different outcomes depending on Bonus value
            //2 - Make a menu to create characters (up to 4): user chooses hero type and name
            //3 - Check if it is possible to store the heroes in a List, with up to 4 heroes
            //4 - Make a second menu that let's the user "control" the heroes, by choosign an action (Attack) 
        }
    }
}

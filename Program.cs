using System;
using System.Collections.Generic;
using DIO_RPG_ObjectOriented.src.Entities;

namespace DIO_RPG_ObjectOriented
{
    class Program
    {
        static void Main()
        {
            
            PlayerInterface playInterf = new PlayerInterface();
            List<Hero> heroes = new List<Hero>();

            playInterf.Welcome();
            string playerOption = playInterf.MainMenu();
            

            while (playerOption != "E"){

                if (playerOption == "C"){
                    playInterf.CreateHero(heroes);
                } else if (playerOption == "H"){
                    playInterf.ShowHeroes(heroes);
                } else if (playerOption == "F"){
                    playInterf.Fight(heroes);
                } else {
                    Console.WriteLine("Invalid option. Choose again.");
                }

                playerOption = playInterf.MainMenu();
            }


            // Knight hero1 = new Knight("Agatha");
            // WhiteWizard hero2 = new WhiteWizard("Gunther");
            // BlackWizard hero3 = new BlackWizard("Aang");
            // Ninja hero4 = new Ninja("Naruto");

            // Console.WriteLine(hero1);
            // Console.WriteLine(hero2);
            // Console.WriteLine(hero3);
            // Console.WriteLine(hero4);

            // Console.WriteLine(hero1.Attack());
            // Console. WriteLine(hero2.Attack());
            // Console.WriteLine(hero3.Attack());
            // Console.WriteLine(hero4.Attack());

            //Next:
            //1 - Implement another Attack method with a Bonus, with different outcomes depending on Bonus value
            //4 - Make a second menu that let's the user "control" the heroes, by choosign an action (Attack) 
        }

        
    }
}

using static System.Console;
using System.Collections.Generic;

namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class PlayerInterface
    {
        public void Welcome(){
            WriteLine("====================================");
            WriteLine("============ RPG game ==============");
            WriteLine("====================================");
        }

        public string MainMenu(){
            WriteLine();
            WriteLine("------------ MAIN MENU -------------");
            WriteLine("--- Choose an option to continue ---");
            WriteLine("      C: Create new hero            ");
            WriteLine("      H: Show your heroes           ");
            WriteLine("      F: Fight                      ");
            WriteLine("      E: Exit                       ");
            WriteLine("------------------------------------");
            Write("Option: ");
            string playerOption = ReadLine().ToUpper();
            return playerOption;
        }

        public void CreateHero(List<Hero> heroes){

            WriteLine("--------- Create your hero ---------");
            Write("Type in the hero name: ");
            string newName = ReadLine();
            WriteLine("--------- Choose hero type ---------");
            WriteLine("      K: Knight                     ");
            WriteLine("      N: Ninja                      ");
            WriteLine("      B: Black Wizard               ");
            WriteLine("      W: White Wizard               ");
            WriteLine("------------------------------------");
            Write("Option: ");
            string heroType = ReadLine().ToUpper();

            if (heroType == "K") {
                heroes.Add(new Knight(newName));
                WriteLine("Hero created!");
            } else if (heroType == "N") {
                heroes.Add(new Ninja(newName));
                WriteLine("Hero created!");
            } else if (heroType == "B") {
                heroes.Add(new BlackWizard(newName));
                WriteLine("Hero created!");
            } else if (heroType == "W") {
                heroes.Add(new WhiteWizard(newName));
                WriteLine("Hero created!");
            } else {
                WriteLine("Invalid hero type.");
                WriteLine("Hero NOT created!");
            }
        }

        public void ShowHeroes(List<Hero> heroes){

            WriteLine();
            WriteLine($"Your party has {heroes.Count} hero(es):");
            WriteLine("------------------------------------");
            WriteLine("Name          Type          Level      HP       MP");
            WriteLine("----          ----          -----     ----     ----");
            foreach(Hero heroUnit in heroes){
                WriteLine(heroUnit);
            }
            WriteLine("------------------------------------");
        }

        public void Fight(List<Hero> heroes){
            
            WriteLine("----------- FIGHT MENU -------------");

            WriteLine("--------- Choose your hero ---------");
            for(int i=0; i<heroes.Count; i++){
                WriteLine($"      {i+1}: {heroes[i].Name,-27}");
            }
            WriteLine("------------------------------------");
            Write("Option: ");
            int heroChoice = int.Parse(ReadLine())-1;

            WriteLine("--------- Choose a command ---------");
            WriteLine(heroes[heroChoice].CommandList());
            WriteLine("--------- Choose a command ---------");
            Write("Option: ");
            string commandChoice = ReadLine().ToUpper();

            if (commandChoice=="A") {
                WriteLine(heroes[heroChoice].Attack());
            } else if (commandChoice=="D") {
                WriteLine(heroes[heroChoice].Defend());
            } else if (commandChoice=="S") {
                WriteLine(heroes[heroChoice].SpecialAbility());
            } else {
                WriteLine("Invalid command");
            }


        }
    }
}
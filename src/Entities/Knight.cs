using System;

namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class Knight: Hero
    {
       
        public static Random bonusValue = new Random();
        public Knight(string Name) : base(Name)
        {
            this.HeroType = "Knight";
            this.HP = 10;
            this.MaxHP = 10;
            this.MP = 2;
            this.MaxMP = 2;
        }

        public override string CommandList() {
            return base.CommandList() + " (Power attack)";
        }

        public override string SpecialAbility()
        {
            int bonus = bonusValue.Next(1,7);

            if (bonus > 3){
                return base.Attack() + " Critical hit!!";
            } else {
                return base.Attack();
            }
        }
    }
}
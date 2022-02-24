namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name) : base(Name)
        {
            this.HeroType = "Ninja";
            this.HP = 8;
            this.MaxHP = 8;
            this.MP = 5;
            this.MaxMP = 5;
        }

        public override string CommandList() {
            return base.CommandList() + " (Smoke screen)";
        }

        public override string SpecialAbility() {
            return this.Name + " used a smoke screen and is immune to attacks";
        }

    }
}
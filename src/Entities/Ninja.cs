namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name) : base(Name)
        {
            this.HeroType = "Ninja";
            this.HP = 8;
            this.MP = 5;
        }
    }
}
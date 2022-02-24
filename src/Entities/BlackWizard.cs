namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name) : base(Name)
        {
            this.HeroType = "Black wizard";
            this.HP = 5;
            this.MaxHP = 5;
            this.MP = 7;
            this.MaxMP = 7;
        }

        public override string Attack()
        {
            return this.Name + " cast a magic attack";
        }
        public override string CommandList() {
            return base.CommandList() + " (Fire ball)";
        }

        public override string SpecialAbility()
        {
            return this.Name + " cast a fire ball";
        }
    }
}
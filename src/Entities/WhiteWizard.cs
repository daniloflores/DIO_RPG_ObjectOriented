namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name) : base(Name)
        {
            this.HeroType = "White wizard";
            this.HP = 4;
            this.MaxHP = 4;
            this.MP = 8;
            this.MaxMP = 8;
        }

        public override string Attack()
        {
            return this.Name + " cast a cure spell";
        }

        public override string CommandList() {
            return base.CommandList() + " (Cure)";
        }

        public override string SpecialAbility()
        {
            return this.Name + " cast a cure spell";
        }
    }
}
namespace DIO_RPG_ObjectOriented.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set;}
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int MP { get; set; }
        public int MaxMP { get; set; }

        

        public Hero(string Name)
        {
            this.Name = Name;
            this.Level = 1;
        }

        public virtual string Attack() {
            return this.Name + " attacked with a sword.";
        }
        public string Defend() {
            return this.Name + " is defending.";
        }

        public abstract string SpecialAbility();

        public virtual string CommandList() {
            return "A: Attack\nD: Defend\nS: Special ability";
        }


        public override string ToString() {

            string heroData = $"{this.Name,-14}";            
            heroData += $"{this.HeroType,-16}{this.Level,-7}";
            heroData += $"{this.HP,2}/{this.MaxHP,2}";
            heroData += $"    ";
            heroData += $"{this.MP,2}/{this.MaxMP,2}";

            return heroData;
        }
    }
}
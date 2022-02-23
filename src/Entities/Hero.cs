namespace DIO_RPG_ObjectOriented.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set;}
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string Name)
        {
            this.Name = Name;
            this.Level = 1;
            this.HP = 10;
            this.MP = 10;
        }

        public string Attack() {
            return this.Name + " attacked with a sword";
        }

        public override string ToString() {
            return @$"
            Hero name: {this.Name}
            Type: {this.HeroType}
            Level: {this.Level}
            HP: {this.HP}
            MP: {this.MP}
            ";
        }
    }
}
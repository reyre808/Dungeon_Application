namespace DungeonLibrary
{
    public class Werewolf : Monster
    {
        public bool IsFullMoon { get; set; }
        public Werewolf(string name, int life, int maxLife, int hitChance, int block,
            int minDamage, int maxDamage, bool isFullMoon)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsFullMoon = isFullMoon;
        }

        public Werewolf()
        {
            Name = "Werewolf";
            MaxLife = 95;
            Life = 85;
            HitChance = 65;
            Block = 15;
            MinDamage = 45;
            MaxDamage = 70;
            IsFullMoon = true;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return base.ToString() + (IsFullMoon ? "\nUh oh its a full moon!!"
                : "\nHe seems to be weakened");

        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsFullMoon)
            {
                calculatedBlock += calculatedBlock * 2;
            }
            return calculatedBlock;
        }
    }
}
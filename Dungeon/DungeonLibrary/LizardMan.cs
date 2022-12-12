namespace DungeonLibrary
{
    public class LizardMan : Monster
    {
        public bool IsScaly { get; set; }
        public LizardMan(string name, int life, int maxLife, int hitChance, int block,
            int minDamage, int maxDamage, bool isScaly)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage)
        {
            IsScaly = isScaly;
        }

        public LizardMan()
        {
            Name = "Lizard Man";
            MaxLife = 90;
            Life = 80;
            HitChance = 60;
            Block = 15;
            MinDamage = 40;
            MaxDamage = 70;
            IsScaly = true;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return base.ToString() + (IsScaly ? "\nHe is covered in scales that look like armor"
                : "\nHe doesnt seem to have his scales!");

        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsScaly)
            {
                calculatedBlock += calculatedBlock * 2;
            }
            return calculatedBlock;
        }
    }
}


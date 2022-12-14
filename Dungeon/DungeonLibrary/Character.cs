namespace DungeonLibrary
{
    public class Character
    {
        private int _life;
        //Because we are creating a business rule for life's property
        //We need to declare the field.


        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        //Because we are using the MaxLife property
        //in the business rule for Life,
        //MaxLife must be assigned BEFORE LIFE
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else if (value > MaxLife)
                {
                    _life = MaxLife;
                }
            }
        }
        public Character()
        {

        }
        public Character(string name, int hitChance, int block, int maxLife, int life)
        {

            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
            



        }

        public virtual int CalcBlock() { return Block; }
        public virtual int CalcHitChance() { return HitChance; }
        public virtual int CalcDamage() { return 0; }

        public override string ToString()
        {
            return "\nName: " + Name + "\nHit Chance: " + HitChance + "\nBlock: " + Block + "\nMax Life: " + MaxLife + "\nLife: " + Life;

            
        }




    }
}
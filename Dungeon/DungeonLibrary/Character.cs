namespace DungeonLibrary
{
    public class Character
    {
        private int _life;
        //Because we are creating a business rule for life's property
        //We need to declare the field.
        

        public int Name { get; set; }
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
                if(value < MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }

        public Character(int name, int hitChance, int block, int maxLife, int life)
        {
            
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }
    }
}
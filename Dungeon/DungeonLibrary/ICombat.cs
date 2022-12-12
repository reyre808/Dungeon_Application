using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public interface ICombat
    {
        int CalcBlock();
        int CalcHitChance();
        int CalcDamage();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public abstract class DefensiveAbility
    {
        public void defend(GameCharacter defender);
        public bool defenseSuccessful();

        public Double _armorIncrease;

        public Double _successRate;
    }
}
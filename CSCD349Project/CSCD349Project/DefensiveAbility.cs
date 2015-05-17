using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public abstract class DefensiveAbility
    {

        private Double _ArmorIncrease;
        private Double _SuccessRate;
        public abstract void defend(GameCharacter defender);
        public abstract bool defenseSuccessful();

        public Double _armorIncrease;

        public Double _successRate;
    }
}
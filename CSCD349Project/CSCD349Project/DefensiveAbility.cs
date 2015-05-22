using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public abstract class DefensiveAbility
    {
        protected string _AbilityName;
        protected Double _ArmorIncrease;
        protected Double _SuccessRate;

        public string _abilityName
        {
            get { return _AbilityName; }
        }
        public Double _armorIncrease
        {
            get { return _ArmorIncrease; }
        }
        public Double _successRate
        {
            get { return _SuccessRate; }
        }

        //public abstract void defend(GameCharacter defender);
        //public abstract bool defenseSuccessful();

        public override string ToString()
        {
            return _AbilityName;
        }
    }
}
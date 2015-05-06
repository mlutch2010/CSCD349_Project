using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class WarriorLiftShield : IDefend
    {
        private Double _armorIncrease;
        private Double _successRate;

        public WarriorLiftShield()
        {
            this.armorIncrease = 5.0;//5 armor points
            this._successRate = 0.90;//90%
        }

        public void defend(GameCharacter defender)
        {
            CharacterAttributes defenderAttributes = defender.getAttributes();
            
            double healthLost = attackerAttributes._power * this._baseDamage - defenderAttributes._armor;
            defenderAttributes._setHealth(healthLost);
        }

        public Double _armorIncrease
        { get { return _armorIncreash; } }

        public Double _successRate
        { get { return _successRate; } }
    }
}
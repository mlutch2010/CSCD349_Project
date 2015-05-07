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

        public bool defenseSuccessful()
        {
            Random rnd = new Random();
            int percentChance = rnd.Next(0, 101);//generate random number between 0 and 100

            if (percentChance >= this._successRate*100)
                return true;
            return false;
        }

        public Double _armorIncrease
        { get { return _armorIncreash; } }

        public Double _successRate
        { get { return _successRate; } }
    }
}
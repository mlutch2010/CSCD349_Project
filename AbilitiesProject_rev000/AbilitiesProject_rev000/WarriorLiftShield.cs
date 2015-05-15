using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class WarriorLiftShield : IDefend
    {
        private double _armorIncrease;
        private double _successRate;

        public WarriorLiftShield()
        {
            _armorIncrease = 5.0;//5 armor points
            _successRate = 0.90;//90%
        }

        //public void defend(GameCharacter defender)
        //{
        //    CharacterAttributes defenderAttributes = defender.getAttributes();
            
        //   double healthLost = attackerAttributes._power * this._baseDamage - defenderAttributes._armor;
        // defenderAttributes._setHealth(healthLost);
        /// <summary>
        /// 
        /// </summary>
        
        public double GetSuccessRate(){return _successRate;}
        public double GetArmorIcrease() { return _armorIncrease; }
    }
}
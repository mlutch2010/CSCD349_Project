using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class WarriorLiftShield : DefensiveAbility
    {
        public WarriorLiftShield()
        {
            _ArmorIncrease = 5.0;//5 armor points
            _SuccessRate = 0.90;//90%
        }

        //public void defend(GameCharacter defender)
        //{
        //    CharacterAttributes defenderAttributes = defender.getAttributes();
            
        //   double healthLost = attackerAttributes._power * this._baseDamage - defenderAttributes._armor;
        // defenderAttributes._setHealth(healthLost);
        /// <summary>
        /// 
        /// </summary>
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class MageCastShield : DefensiveAbility
    {
        public MageCastShield()
        {
            _ArmorIncrease = 20.0;//5 armor points
            _SuccessRate = 0.80;//80%
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
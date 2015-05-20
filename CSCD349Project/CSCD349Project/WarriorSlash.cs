using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class WarriorSlash : OffensiveAbility
    {
        public WarriorSlash()
        {
            this._AbilityName = "Slash";
            this._BaseDamage = 5.0;//5hp
            this._SuccessRate = 0.90;//90%
            this._EnergyRequired = 5.0;//5 energy points (ep)
        }
    }
}
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
            _AbilityName = "Slash";
            _BaseDamage = 20.0;//20hp
            _SuccessRate = 0.90;//90%
            _EnergyRequired = 5.0;//5 energy points (ep)
        }
    }
}
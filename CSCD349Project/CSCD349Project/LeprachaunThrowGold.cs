using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class LeprachaunThrowGold: OffensiveAbility
    {
        public LeprachaunThrowGold()
        {
            _AbilityName = "throw gold";
            _BaseDamage = 4.0;//4hp
            _SuccessRate = 0.87;//90%
            _EnergyRequired = 5.0;//5 energy points (ep)
        }
    }
}

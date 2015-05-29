using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class GargoyleStare: OffensiveAbility
    {
        public GargoyleStare()
        {
            _AbilityName = "Stare";
            _BaseDamage = 4.0;//4hp
            _SuccessRate = 0.80;//80%
            _EnergyRequired = 3.0;//3 energy points (ep)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class ScoutShootPlainArrow : OffensiveAbility
    {
        public ScoutShootPlainArrow()
        {
            _AbilityName = "Plain Arrow";
            _BaseDamage = 8.0;//5hp
            _SuccessRate = 0.90;//90%
            _EnergyRequired = 5.0;//5 energy points (ep)
        }
    }
}
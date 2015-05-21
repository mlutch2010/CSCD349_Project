using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class LandSharkChomp : OffensiveAbility
    {
        public LandSharkChomp()
        {
            _AbilityName = "Chomp";
            _BaseDamage = 5.0;//5hp
            _SuccessRate = 0.90;//90%
            _EnergyRequired = 5.0;//5 energy points (ep)
        }
    }
}
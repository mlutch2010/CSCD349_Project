using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class MageShootLightning : OffensiveAbility
    {
        public MageShootLightning()
        {
            _AbilityName = "Shoot Lighting";
            _BaseDamage = 15.0;//5hp
            _SuccessRate = 0.80;//80%
            _EnergyRequired = 15.0;//15 energy points (ep)
        }
    }
}
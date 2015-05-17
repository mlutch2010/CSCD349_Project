using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class WarriorSlash : OffensiveAbility
    {
        private string _AbilityName;
        private Double _BaseDamage;
        private Double _SuccessRate;
        private Double _EnergyRequired;
        
        public WarriorSlash()
        {
            this._AbilityName = "Slash";
            this._BaseDamage = 5.0;//5hp
            this._SuccessRate = 0.90;//90%
            this._EnergyRequired = 5.0;//5 energy points (ep)
        }

        public Double GetBaseDamage
        { get { return _BaseDamage; } }

        public Double GetSuccessRate
        { get { return _SuccessRate; } }

        public Double GetEnergyRequired
        { get { return _EnergyRequired; } }
    }
}
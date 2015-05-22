using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public abstract class OffensiveAbility
    {
        protected string _AbilityName;
        protected Double _BaseDamage;
        protected Double _SuccessRate;
        protected Double _EnergyRequired;
        
        // properties
        public string _abilityName
        { get { return _AbilityName; } }
        public Double _successRate
        { get{return _SuccessRate;} }
        public Double _baseDamage
        { get { return _BaseDamage; } }
        public Double _energyRequired
        { get { return _EnergyRequired; } }

        public override string ToString()
        {
            return _AbilityName;
        }



        /** Zack, I commented these becuase above it lookes like we are going with properties instead
         *  of Java style getters/setters
         * 
         */
        //public abstract Double GetBaseDamage();
        //public abstract Double GetSuccessRate();
        //public abstract Double GetEnergyRequired();
    }
}
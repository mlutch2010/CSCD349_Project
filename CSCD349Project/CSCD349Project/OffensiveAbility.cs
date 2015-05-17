using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public abstract class OffensiveAbility
    {
        private string _AbilityName;
        private Double _BaseDamage;
        private Double _SuccessRate;
        private Double _EnergyRequired;
        
        // properties
        public Double _successRate
        {
            get{return _SuccessRate;}
            set{_SuccessRate = value;}
        }

        public Double _baseDamage
        {
            get { return _BaseDamage; }
            set { _BaseDamage = value; }
        }

        public Double _energyRequired
        {
            get { return _EnergyRequired; }
            set { _EnergyRequired = value; }
        }




        public virtual void attack(GameCharacter attacker, GameCharacter defender)
        {
            CharacterAttributes attackerAttributes = attacker.getAttributes();
            CharacterAttributes defenderAttributes = defender.getAttributes();
            OffensiveAbility activeOffense = attackerAttributes.GetActiveAttack();
            DefensiveAbility activeDefense = defenderAttributes.GetActiveDefense();

            //Enough Energy?
            if (attackerAttributes._energy >= activeOffense._energyRequired)//.GetEnergyRequired())
            {
                //Succesful Attack?
                if (AbilitySuccessful(activeOffense._successRate))//GetSuccessRate)));
                {
                    attackerAttributes._energy -= activeOffense._energyRequired;//_energyRequired;

                    Double healthLost = 0.0;

                    //Succesful Defense?
                    if (AbilitySuccessful(activeDefense._successRate))
                    {
                        healthLost = attackerAttributes._power * this._baseDamage - defenderAttributes._armor;
                        healthLost -= activeDefense._armorIncrease;
                    }
                    else
                    {
                        healthLost = attackerAttributes._power * this._baseDamage - defenderAttributes._armor;
                    }

                    defenderAttributes._health -= healthLost;
                }
                else
                {
                    string msg = "Attack Failed\n";// = attacker.getName() "\'s " + this.abilityName + " missed " + defender.getName() + "!";
                    throw new AttackUnsuccesfulException(msg);
                }
            }
            else
            {
                string msg = "Current Warrior Energy: " + attackerAttributes._energy + "\nBut SLASH requires: " + this._energyRequired + "\n";
                throw new NotEnoughEnergyException(msg);
            }
        }

        private bool AbilitySuccessful(double successRate)
        {
            Random rnd = new Random();
            int percentChance = rnd.Next(0, 101);//generate random number between 0 and 100

            if (percentChance >= this._successRate * 100)
                return true;
            return false;
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
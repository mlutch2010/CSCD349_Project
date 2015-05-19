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
        public Double _successRate
        {
            get{return _SuccessRate;}
        }

        public Double _baseDamage
        {
            get { return _BaseDamage; }
        }

        public Double _energyRequired
        {
            get { return _EnergyRequired; }
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

        private bool AbilitySuccessful(double abilitySuccessRate)
        {
            var rnd = new Random();
            int percentChance = rnd.Next(0, 101);//generate random number between 0 and 100

            Console.WriteLine("In AbilitySuccesful(), Random number is: {0}\nabilitySuccessRate is: {1}", percentChance, abilitySuccessRate);

            if (percentChance >= abilitySuccessRate * 100)
                return true;
            return false;
        }

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
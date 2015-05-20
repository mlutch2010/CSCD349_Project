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
        { get{return _SuccessRate;} }
        public Double _baseDamage
        { get { return _BaseDamage; } }
        public Double _energyRequired
        { get { return _EnergyRequired; } }



        public virtual void Attack(GameCharacter attacker, GameCharacter defender)
        {
            CharacterAttributes attackerAttributes = attacker.GetAttributes();
            CharacterAttributes defenderAttributes = defender.GetAttributes();
            OffensiveAbility activeOffense = attackerAttributes.GetActiveAttack();
            DefensiveAbility activeDefense = defenderAttributes.GetActiveDefense();

            //Enough Energy?
            if (attackerAttributes._energy >= activeOffense._energyRequired)//.GetEnergyRequired())
            {
                //Succesful Attack?
                if (AbilitySuccessful(activeOffense._successRate))//GetSuccessRate)));
                {
                    Console.WriteLine("Succesful Attack");
                    attackerAttributes._energy -= activeOffense._energyRequired;//_energyRequired;

                    Double healthLost = 0.0;

                    //Succesful Defense?
                    if (AbilitySuccessful(activeDefense._successRate))
                    {
                        healthLost = attackerAttributes._power * activeOffense._baseDamage - defenderAttributes._armor;
                        healthLost -= activeDefense._armorIncrease;

                        Console.WriteLine("Succesful Defense. healthLost=" + healthLost);
                    }
                    else
                    {
                        healthLost = attackerAttributes._power * activeOffense._baseDamage - defenderAttributes._armor;
                        Console.WriteLine("Health Lost: " + healthLost);
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
            int percentChance = rnd.Next(-1, 101);//generate random number between 0 and 100

            Console.WriteLine("In AbilitySuccesful(), Random number is: {0}\nabilitySuccessRate is: {1}", percentChance, abilitySuccessRate);

            if (percentChance <= abilitySuccessRate * 100)
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
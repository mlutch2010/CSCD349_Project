using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
	class WarriorSlash : IAttack
    {
        private string abilityName;
        private Double _baseDamage;
        private Double _successRate;
        private Double _energyRequired;

        public WarriorSlash()
        {
            this.abilityName = "Slash";
            this._baseDamage = 5.0;//5hp
            this._successRate = 0.90;//90%
            this._energyRequired = 5.0;//5 energy points (ep)
        }

        public void attack(GameCharacter attacker, GameCharacter defender)
        {
            CharacterAttributes attackerAttributes = attacker.getAttributes();
            CharacterAttributes defenderAttributes = defender.getAttributes();
            
            if(attackerAttributes._energy >= this._energyRequired)
            {
                if(attackSuccessful(this._successRate))
                {
                    attackerAttributes._energy -= this._energyRequired;

                    double healthLost = attackerAttributes._power * this._baseDamage - defenderAttributes._armor;
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
                string msg = "Current Warrior Energy: "+ attackerAttributes._energy +"\nBut SLASH requires: "+ this._energyRequired +"\n";
                throw new NotEnoughEnergyException(msg);
            }
        }

        private bool attackSuccessful(Double attackSuccessRate)
        {
            Random rnd = new Random();
            int percentChance = rnd.Next(0, 101);//generate random number between 0 and 100

            if (percentChance >= attackSuccessRate*100)
                return true;
            return false;
        }

        private bool defenseSuccessful(Double defenseSuccessRate)
        {
            Random rnd = new Random();
            int percentChance = rnd.Next(0, 101);//generate random number between 0 and 100

            if (percentChance >= defenseSuccessRate*100)
                return true;
            return false;
        }
    }
}
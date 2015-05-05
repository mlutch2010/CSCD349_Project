using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilitiesProject_rev000
{
    public class NotEnoughEnergyException: Exception
    {
        public NotEnoughEnergyException()
        { }

        public NotEnoughEnergyException(string message)
            : base(message)
        { }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IAttack
    {
        public void attack(GameCharacter attacker, GameCharacter defender);
    }

    class WarriorSlash : IAttack
    {
        private Double baseDamage;
        private Double successRate;
        private Double energyRequired;

        public WarriorSlash()
        {
            this.baseDamage = 5.0;//5hp
            this.successRate = 0.90;//90%
            this.energyRequired = 5.0;//5 energy points (ep)
        }

        public void attack(GameCharacter attacker, GameCharacter defender)
        {
            if(attacker.energy >= this.energyRequired)
            {
                attacker.energy -= this.energyRequired;

                double healthLost = attacker.power * this.baseDamage - defender.armor;
                defender.setHealth(healthLost);
            }
            else
            {
                throw new NotEnoughEnergyException("Current Warrior Energy: {0}\nBut SLASH requires: {1}\n", attacker.energy, this.energyRequired);
            }
        }
    }

    public static class EnactAttack
    {
        public void attack()
        {

        }
    }

}

using System;
namespace CSCD349Project
{
public abstract class GameCharacter : GameObject, IComparable<GameCharacter>
    {
        private static int noInstances = 0;
        private int _ID;
        private CharacterAttributes _Attributes;
        private Party _Party; 
 
        public GameCharacter(string name) : base(name)
        {
            _ID = noInstances ++;
        }
       
        // This constructor is used to create a GamaCharacter instance with a particular id for the purposes 
        // of searching for a character in a list.
        public GameCharacter(int id) : base(""){_ID = id;}
    
        public void PerformActiveAttack(GameCharacter enemy) 
        {
            CharacterAttributes attackerAttributes = this.GetAttributes();
            OffensiveAbility activeAttack = attackerAttributes.GetActiveAttack();
            Double attackDamage = 0.0;

            //Does the attacker have enough Energy to perform the attack?
            if (this._Attributes._energy >= activeAttack._energyRequired && AbilitySuccessful(activeAttack._energyRequired))
            {
                attackDamage = this._Attributes.GetActiveAttack()._baseDamage;
            }

            enemy.PerformActiveDefense(attackDamage);
        }

        public void PerformActiveDefense(Double incomingDamage)
        {
            
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

        public int CompareTo(GameCharacter other)
        {
 	        return _ID - other._ID;
        }

        public CharacterAttributes GetAttributes()
        {
            return _Attributes;
        }

        public void SetAttributes(CharacterAttributes attributes)
        {
            if(attributes != null)
                _Attributes = attributes;
        }

        public override string ToString()
        {
            string output = "----- Game Character    id:" + _ID  + "-----\n";
            output += "name:" + GetName() + "\n";
            output += (_Attributes.GetIsGoodGuy()) ? "goodguy\n" : "badguy";
            output += "health: " + _Attributes._health + "\n";
            output += "energy: " + _Attributes._energy + "\n";
            output += "power: "  + _Attributes._power + "\n";
            output += "armor: "  + _Attributes._armor + "\n";
            output += "----------------------------------------------------\n";
            
            return output;
        }
    }
}
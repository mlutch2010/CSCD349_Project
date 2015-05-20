using System;
namespace CSCD349Project
{
    public class NullAttack : OffensiveAbility
    {
        public NullAttack(){}

        public override string ToString() { return "null Attack"; }
        public override void Attack(GameCharacter attacker, GameCharacter defender)
        {
            // perform attack
        }


        public bool AttackSuccessful(double successRate)
        {
            //throw new NotImplementedException();
            return false;
        }
    }
}

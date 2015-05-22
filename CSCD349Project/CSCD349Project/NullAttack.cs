using System;
namespace CSCD349Project
{
    public class NullAttack : OffensiveAbility
    {
        public NullAttack(){}

        public override string ToString() { return "null Attack"; }

        public bool AttackSuccessful(double successRate)
        {
            //throw new NotImplementedException();
            return false;
        }
    }
}

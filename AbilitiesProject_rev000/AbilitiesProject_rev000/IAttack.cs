using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public interface IAttack
    {
        void attack(GameCharacter attacker, GameCharacter defender);
        bool attackSuccessful(Double successRate);
    }
}
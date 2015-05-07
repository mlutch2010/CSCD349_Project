using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    interface IAttack
    {
        public void attack(GameCharacter attacker, GameCharacter defender);
        private bool attackSuccessful();
    }
}
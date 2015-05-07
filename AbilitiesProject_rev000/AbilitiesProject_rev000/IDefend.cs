using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    interface IDefend
    {
        public void defend(GameCharacter defender);
        public bool defenseSuccessful();
    }
}
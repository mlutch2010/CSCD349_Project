using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public interface IDefend
    {
        void defend(GameCharacter defender);
        bool defenseSuccessful();
    }
}
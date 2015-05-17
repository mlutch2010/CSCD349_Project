using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class NullDefend: DefensiveAbility
    {

        public override void defend(GameCharacter defender)
        {
            //throw new NotImplementedException();
        }

        public override bool defenseSuccessful()
        {
           // throw new NotImplementedException();
            return false;
        }
    
    
        public override string ToString()
        {
 	        return "Null Defend";
        }
    
    }


     

}

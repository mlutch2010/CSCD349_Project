using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class NullDefend: IDefend
    {

        public void defend(GameCharacter defender)
        {
            //throw new NotImplementedException();
        }

        public bool defenseSuccessful()
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

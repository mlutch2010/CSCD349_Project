using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class GargoyleFreeze: DefensiveAbility
    {
        public GargoyleFreeze()
        {
            _ArmorIncrease = 5.0;//5 armor points
            _SuccessRate = 0.90;//90%
        }
    }
}

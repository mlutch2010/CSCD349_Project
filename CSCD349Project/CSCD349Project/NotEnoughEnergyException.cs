using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
	public class NotEnoughEnergyException: Exception
    {
        public NotEnoughEnergyException()
        { }

        public NotEnoughEnergyException(string message)
            : base(message)
        { }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    public class AttackUnsuccesfulException : Exception
    {
        public AttackUnsuccesfulException(String message) : base(message) { }
        public AttackUnsuccesfulException() { }
    }
}

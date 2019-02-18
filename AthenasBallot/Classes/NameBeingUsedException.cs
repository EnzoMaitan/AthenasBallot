using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes
{
    public class NameBeingUsedException : Exception
    {
        public NameBeingUsedException()
        {
        }
        public NameBeingUsedException(string message) : base (message)
        {
                
        }
    }
}

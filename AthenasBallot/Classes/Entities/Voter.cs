using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes.Entities
{
    public class Voter : Student
    {
        public Voter(string name, string studentNumber, string studentClass)
            : base(name, studentNumber, studentClass)
        {
         
        }
        public Voter()
        {

        }
    }
}

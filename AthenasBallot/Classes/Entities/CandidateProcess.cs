using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes.Entities
{
    public class CandidateProcess
    {
        public Candidate Candidate { get; private set; }
        public int CandidateID { get; private set; }
        public Process Process { get; private set; }
        public int ProcessID { get; private set; }

    }
}

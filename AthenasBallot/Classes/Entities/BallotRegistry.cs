using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes.Entities
{
    public class BallotRegistry
    {
        public int Id { get; private set; }
        public SystemOperator SystemOperator { get; private set; }
        public int SystemOperatorID { get; private set; }
        public Student student { get; private set; }
        public int StudentID { get; private set; }
        public Ballot Ballot { get; private set; }
        public int BallotID { get; private set; }
        public DateTime Date { get; private set; }
    }
}

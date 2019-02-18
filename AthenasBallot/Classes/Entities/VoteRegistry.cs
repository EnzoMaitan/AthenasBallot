using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes.Entities
{
    public class VoteRegistry
    {
        public int Id { get; private set; }
        public Voter Voter { get; private set; }
        public int VoterID { get; private set; }
        public Process Process { get; private set; }
        public int ProcessID { get; private set; }
        public Ballot Ballot { get; private set; }

        public VoteRegistry(int id, Voter voter, int voterID, 
            Process process, int processID, Ballot ballot, int ballotID)
        {
            Id = id;
            Voter = voter;
            VoterID = voterID;
            Process = process;
            ProcessID = processID;
            Ballot = ballot;
            BallotID = ballotID;
        }
        public VoteRegistry()
        {

        }
        public int BallotID { get; private set; }
    }
}

using AthenasBallot.Classes.Entities;
using AthenasBallot.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.DAO
{
    public class VoterDAO : IVoterDAO
    {
        private Context context;

        public VoterDAO()
        {
            context = new Context();
        }

        public void Add(Voter voter)
        {
            context.Voters.Add(voter);
            context.SaveChanges();
        }

        public void Update(Voter voter)
        {
            context.Voters.Update(voter);
            context.SaveChanges();
        }

        public IList<Voter> Voters() => context.Voters.ToList();
    }
}

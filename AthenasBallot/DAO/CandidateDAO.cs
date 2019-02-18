using AthenasBallot.Classes.Entities;
using AthenasBallot.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.DAO
{
    public class CandidateDAO : ICandidateDAO
    {
        private Context context;

        public CandidateDAO()
        {
            context = new Context();
        }

        public void Add(Candidate candidate)
        {
            context.Candidates.Add(candidate);
            context.SaveChanges();
        }

        public void Update(Candidate candidate)
        {
            context.Candidates.Update(candidate);
            context.SaveChanges();
        }

        public IList<Candidate> Candidates() => context.Candidates.ToList();
    }
}

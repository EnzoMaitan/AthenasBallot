using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.Classes.Entities;

namespace AthenasBallot.IDAO
{
    public interface ICandidateDAO
    {
        void Add(Candidate candidate);
        void Update(Candidate candidate);
        IList<Candidate> Candidates();
    }
}

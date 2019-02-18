using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.Classes.Entities;

namespace AthenasBallot.IDAO
{
    public interface IVoterDAO
    {
        void Add(Voter voter);
        void Update(Voter voter);
        IList<Voter> Voters();
    }
}

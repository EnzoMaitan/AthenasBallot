using AthenasBallot.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.IDAO
{
    public interface IBallotDAO
    {
        void Add(Ballot Ballot);
        void Update(Ballot Ballot);
        IList<Ballot> Ballots();
    }
}

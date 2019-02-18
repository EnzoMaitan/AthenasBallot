using AthenasBallot.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.IDAO
{
    public interface IBallotRegistryDAO
    {
        void Add(BallotRegistry BallotRegistry);
        void Update(BallotRegistry BallotRegistry);
        IList<BallotRegistry> ballotRegistries();
    }
}

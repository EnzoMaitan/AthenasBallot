using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.Classes.Entities;

namespace AthenasBallot.IDAO
{
    public interface IPartyDAO
    {
        void Add(Party party);
        void Update(Party party);
        IList<Party> Parties();
    }
}

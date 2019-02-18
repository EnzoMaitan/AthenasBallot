using AthenasBallot.Classes.Entities;
using AthenasBallot.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.DAO
{
    public class PartyDAO : IPartyDAO
    {
        private Context context;

        public PartyDAO()
        {
            context = new Context();
        }

        public void Add(Party party)
        {
            context.Parties.Add(party);
            context.SaveChanges();
        }

        public void Update(Party party)
        {
            context.Parties.Update(party);
            context.SaveChanges();
        }

        public IList<Party> Parties() => context.Parties.ToList();
    }
}

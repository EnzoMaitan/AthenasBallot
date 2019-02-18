using AthenasBallot.Classes.Entities;
using AthenasBallot.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.DAO
{
    class SystemOperatorDAO : ISystemOperatorDAO
    {
        private Context context;

        public SystemOperatorDAO()
        {
            context = new Context();
        }

        public void Add(SystemOperator systemOperator)
        {
            context.SystemOperators.Add(systemOperator);
            context.SaveChanges();
        }

        public IList<SystemOperator> SystemOperators() 
            => context.SystemOperators.ToList();

        public void Update(SystemOperator systemOperator)
        {
            context.SystemOperators.Update(systemOperator);
            context.SaveChanges();
        }
    }
}

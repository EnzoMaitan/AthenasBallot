using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.Classes.Entities;

namespace AthenasBallot.IDAO
{
    public interface ISystemOperatorDAO
    {
        void Add(SystemOperator systemOperator);
        void Update(SystemOperator systemOperator);
        IList<SystemOperator> SystemOperators();
    }
}

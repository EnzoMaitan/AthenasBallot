using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.Classes.Entities;

namespace AthenasBallot.IDAO
{
    public interface IProcessDAO
    {
        void Add(Process process);
        void Update(Process process);
        IList<Process> Processes();
    }
}

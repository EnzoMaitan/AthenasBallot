using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.Classes.Entities;
using AthenasBallot.IDAO;

namespace AthenasBallot.DAO
{
    public class ProcessDAO : IProcessDAO
    {
        private Context context;

        public ProcessDAO()
        {
                context = new Context();
        }

        public void Add(Process process)
        {
            context.Processes.Add(process);
            context.SaveChanges();
        }

        public void Update(Process process)
        {
            context.Processes.Update(process);
            context.SaveChanges();
        }

        public IList<Process> Processes() => context.Processes.ToList();
    }
}

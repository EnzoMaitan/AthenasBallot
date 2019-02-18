using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.DAO;

namespace AthenasBallot.Classes.Entities
{
    public class Process : IUniqueName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool Status { get; private set; }
        public DateTime InitialDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Process()
        {

        }

        public Process(string name, DateTime initialDate, DateTime endDate)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));
            CheckNameNotBeingUsed(name);

            Name = name;
            Status = false;
            InitialDate = initialDate;
            EndDate = endDate;
        }

        public bool CheckNameNotBeingUsed(string name)
        {
            var processDAO = new ProcessDAO();
            var process = processDAO.Processes().FirstOrDefault(x => x.Name == name);
            if (process != null)
            {
                return true;
            }
            throw new NameBeingUsedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.DAO;

namespace AthenasBallot.Classes.Entities
{
    public class Candidate : Student, IUniqueName
    {
        public Candidate()
        {

        }

        public Candidate(string name,
            string studentNumber, string studentClass,
            char sex, byte[] photo, int partyId)
            : base(name, studentNumber, studentClass)
        {
            CheckNameNotBeingUsed(name);

            RegistryDate = DateTime.Now;
            Sex = sex;
            Photo = photo;
            PartyID = partyId;
        }

        public char Sex { get; private set; }
        public byte[] Photo { get; private set; }
        public Party Party { get; private set; }
        public int PartyID { get; private set; }

        public bool CheckNameNotBeingUsed(string name)
        {
            var candidateDAO = new CandidateDAO();
            var candidate = candidateDAO.Candidates().FirstOrDefault(x => x.Name == name);
            if (candidate != null)
            {
                return true;
            }
            throw new NameBeingUsedException();
        }

        public void DisassociateParty()
        {
            Party = null;
            PartyID = 0;
        }
    }
}

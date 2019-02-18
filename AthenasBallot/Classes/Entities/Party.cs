using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.DAO;

namespace AthenasBallot.Classes.Entities
{
    public class Party : IUniqueName
    {
       public int Id { get; private set; }
       public string Name { get; private set; }
       public int Number { get; private set; }
       public byte[] LogoImage { get; private set; }

        public Party()
        {

        }

        public Party(string name, int number, byte[] logoImage)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            if (number >= 100 && number <= 0)
                throw new ArgumentException("The party number must be between 1 and 99",nameof(number));
            CheckNameNotBeingUsed(name);

           Name = name;
           Number = number;
           LogoImage = logoImage;
        }

        public bool CheckNameNotBeingUsed(string name)
        {
            var partyDAO = new PartyDAO();
            var party = partyDAO.Parties().FirstOrDefault(x => x.Name == name);
            if (party != null)
            {
                return true;
            }
            throw new NameBeingUsedException();
        }
    }
}

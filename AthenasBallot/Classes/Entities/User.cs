using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes.Entities
{
    public abstract class User
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime RegistryDate { get; protected set; }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            this.Name = name;
            this.RegistryDate = DateTime.Now;
        }

        public User()
        {

        }
    }
}

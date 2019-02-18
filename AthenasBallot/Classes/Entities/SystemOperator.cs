using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenasBallot.DAO;
namespace AthenasBallot.Classes.Entities
{
    public class SystemOperator : User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Role Role { get; private set; }

        public SystemOperator()
        {

        }

        public SystemOperator(string name, DateTime registryDate,
            string login, string password, Role role)
        : base(name)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password));
        }

        internal bool Authenticate(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password));

            var systemOperatorDAO = new SystemOperatorDAO();
            var result = systemOperatorDAO.SystemOperators().FirstOrDefault(
                x=> x.Login == login && x.Password == password);

            if (result != null)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Invalid Credentials");
            }
        }

        public void SetCredentialsFromDataBase(string login, string password)
        {
            var systemOperatorDAO = new SystemOperatorDAO();
            var result = systemOperatorDAO.SystemOperators().FirstOrDefault(
                x => x.Login == login && x.Password == password);

            this.Name = result.Name;
            this.Password = result.Password;
            this.Role = result.Role;
            this.RegistryDate = result.RegistryDate;
            this.Id = result.Id;
        }
    }
}

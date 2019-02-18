using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenasBallot.Classes.Entities
{
    public abstract class Student : User
    {
        public string StudentNumber { get; protected set; }
        public string StudentClass { get; protected set; }

        public Student(string name, string studentNumber, string studentClass)
            : base(name)
        {
            if (string.IsNullOrWhiteSpace(studentNumber))
                throw new ArgumentNullException(nameof(studentNumber));
            if (string.IsNullOrWhiteSpace(studentClass))
                throw new ArgumentNullException(nameof(studentNumber));

            this.StudentNumber = studentNumber;
            this.StudentClass = studentClass;
        }
        public Student()
        {

        }
    }
}

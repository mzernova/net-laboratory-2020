using System;
using System.Diagnostics;

namespace Students
{
    class Student
    {
        private string fullName;
        private string email;

        public Student (string email)
        {
            Debug.Assert (email.Length != 0, "Empty string");

            char[] separators = { '@', '.' };
            string[] splittedEmail = email.Split (separators);

            Debug.Assert(splittedEmail.Length == 4, "Wrong email format");

            this.email = email;
            this.fullName = splittedEmail[0].Substring (0, 1).ToUpper() + splittedEmail[0].Remove(0, 1) + " "
                          + splittedEmail[1].Substring (0, 1).ToUpper() + splittedEmail[1].Remove(0, 1);
        }

        public Student (string name, string surname)
        {
            Debug.Assert (name.Length != 0, "Wrong name");
            Debug.Assert (surname.Length != 0, "Wrong surname");

            this.email = name.ToLower() + '.' + surname.ToLower() + "@epam.com";
            this.fullName = name + " " + surname;
        }

        public override bool Equals (object obj)
        {
            return obj is Student student
                && fullName == student.fullName
                && email == student.email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine (fullName, email);
        }
    }
}

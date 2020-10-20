using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "Maths", "biology", "chemistry", "physics", "geography", "literature" };

            var student1c1 = new Student("irina.allegrova@epam.com");
            var student2c1 = new Student("anatoly.wasserman@epam.com");
            var student3c1 = new Student("donald.trump@epam.com");

            var student1c2 = new Student("Irina", "Allegrova");
            var student2c2 = new Student("Anatoly", "Wasserman");
            var student3c2 = new Student("Donald", "Trump");

            var studentSubjectDict = new Dictionary<Student, HashSet<string>>();

            studentSubjectDict[student1c1] = new HashSet<string> { subjects[0], subjects[1], subjects[2] };
            studentSubjectDict[student2c1] = new HashSet<string> { subjects[3], subjects[4], subjects[0] };
            studentSubjectDict[student3c1] = new HashSet<string> { subjects[5], subjects[4], subjects[1] };
            studentSubjectDict[student1c2] = new HashSet<string> { subjects[3], subjects[2], subjects[0] };
            studentSubjectDict[student2c2] = new HashSet<string> { subjects[0], subjects[4], subjects[5] };
            studentSubjectDict[student3c2] = new HashSet<string> { subjects[5], subjects[1], subjects[3] };
        }
    }
}

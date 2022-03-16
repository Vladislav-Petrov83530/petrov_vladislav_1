using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_II
{
    class University:IEducationInstitution
    {
        public string name { get; set; }
        public int countOfStudents { get; set; }
        public int countOfTeachers { get; set; }
        public int countOfFaculty { get; set; }
        
        public University() { }
        public University(string name, int countOfStudents, int countOfTeachers, int countOfFaculty)
        {
            this.countOfStudents = countOfStudents;
            this.name = name;
            this.countOfTeachers = countOfTeachers;
            this.countOfFaculty = countOfFaculty;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}; \nCount of students: {countOfStudents}; \nCount of teachers: {countOfTeachers};" +
                            $" \nCount of faculties: {countOfFaculty} ");
        }
        public void ShowCountOfFaculty()
        {
            Console.WriteLine($"Count of faculty in {name} = {countOfFaculty}");
        }
        public void Create()
        {
            University un = new University();
            Console.Write("Name:");
            un.name = Console.ReadLine();
            Console.Write("Count of students: ");
            un.countOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of teachers: ");
            un.countOfTeachers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of faculties: ");
            un.countOfFaculty = Convert.ToInt32(Console.ReadLine());
            
            string line = $"Name: {name}; \nCount of students: {countOfStudents}; \nCount of teachers: {countOfTeachers};" +
                            $" \nCount of faculties: {countOfFaculty}";
            using (StreamWriter sw = new StreamWriter("D:\\с#\\LW4_II\\University.txt"))
            {
                sw.WriteLine(line);
            }
        }

    }
}

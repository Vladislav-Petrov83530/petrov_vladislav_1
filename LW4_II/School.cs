using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_II
{
    class School:IEducationInstitution
    {
        public string name { get; set; }
        public int countOfStudents { get; set; }
        public int countOfTeachers { get; set; }
        public int countOfClass { get; set; }
        
        public School() { }

        public School(string name, int countOfStudents, int countOfTeachers, int countOfClass)
        {
            this.countOfStudents = countOfStudents;
            this.name = name;
            this.countOfTeachers = countOfTeachers;
            this.countOfClass = countOfClass;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}; \nCount of students: {countOfStudents}; \nCount of teachers: {countOfTeachers};" +
                $" \nCount of classes: {countOfClass} ");
        }
        public void Create()
        {
            School sc = new School();
            Console.Write("Name:");
            sc.name = Console.ReadLine();
            Console.Write("Count of students: ");
            sc.countOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of teachers: ");
            sc.countOfTeachers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of classes: ");
            sc.countOfClass = Convert.ToInt32(Console.ReadLine());
            
            string line = $"Name: {sc.name}; \nCount of students: {sc.countOfStudents}; \nCount of teachers: {sc.countOfTeachers};" +
                $" \nCount of classes: {sc.countOfClass} ";
            using (StreamWriter sw = new StreamWriter("D:\\с#\\LW4_II\\School.txt"))
            {
                sw.WriteLine(line);
            }
        }
 
    }
}

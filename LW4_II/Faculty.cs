using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_II
{
    class Faculty : IEducationInstitution
    {
        public string name { get; set; }
        public int countOfStudents { get; set; }
        public int countOfTeachers { get; set; }
        public int yearOfFoundation {get; set;}
        public Faculty() { }
        public Faculty(string name,int countOfStudents, int countOfTeachers, int yearOfFoundation)
        {
            this.countOfStudents = countOfStudents;
            this.name = name;
            this.countOfTeachers = countOfTeachers;
            this.yearOfFoundation = yearOfFoundation;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}; \nCount of students: {countOfStudents}; \nCount of teachers: {countOfTeachers};" +
                $" \nYear of foundation: {yearOfFoundation} ");
        }
        public void Create()
        {
            Faculty fc = new Faculty();
            Console.Write("Name:");
            fc.name = Console.ReadLine();
            Console.Write("Count of students: ");
            fc.countOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.Write("Count of teachers: ");
            fc.countOfTeachers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year of foundation: ");
            fc.yearOfFoundation = Convert.ToInt32(Console.ReadLine());
            
            string line = $"Name: {name}; \nCount of students: {countOfStudents}; \nCount of teachers: {countOfTeachers};" +
                $" \nYear of foundation: {yearOfFoundation} ";
            using (StreamWriter sw = new StreamWriter("D:\\с#\\LW4_II\\Faculty.txt"))
            {
                sw.WriteLine(line);
            }
        }

    }
}

using System;
using System.Linq;

//Завдання

//---Проаналізувати завдання, виділити інформаційні об’єкти та дії. Визначити правильну ієрархію об’єктів +

//---Створити базовий суперклас (абстрактний клас або інтерфейс) і визначити загальні методи для даного класу.
//Створити підкласи, в які додати специфічні властивості та методи. Частину методів перевизначити. 

//---Розробити програму з використанням абстрактних класів та інтерфейсів. 
//Чітко розуміти, де доцільно використати суперклас, а де звичайний. 

//---При розробці використовувати наслідування та поліморфізм

//---У всіх класах повинні бути реалізовані доцільні для класу методи, навіть якщо це не вказано у завданні

//---Використовувати об’єкти підкласів для моделювання реальних ситуацій на об’єктів

//25.Створити суперклас Навчальний заклад і підкласи Школа, Університет, Факультет. 
//За допомогою конструктора задати кількість учнів у закладі. Визначити кількість викладачів у навчальному закладі, 
//кількість класів у школі та рік заснування факультету. Вивести на екран кількість факультетів в університеті.
namespace LW4_II
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc1 = new() { name = "School #1", countOfStudents = 500, countOfTeachers = 25, countOfClass = 16 };
            School sc2 = new School("School #2", 1500, 40, 36);
            School sc3 = new School("School #3", 1000, 20, 20);
            University un1 = new University() {name= "National Technical University of Ukraine “Igor Sikorsky Kyiv Polytechnic Institute", countOfStudents= 22446, countOfTeachers=2730,countOfFaculty=16 };
            University un2 = new University("Taras Shevchenko National University of Kyiv", 32000,1600, 14);
            Faculty fc1 = new Faculty() {name="FICT", countOfStudents=1326,countOfTeachers=109,yearOfFoundation=1962 };
            Faculty fc2 = new Faculty("Geography faculty", 1200,103,1933);

            Console.WriteLine("Show info about sc1:");
            sc1.ShowInfo();
            Console.WriteLine("\nShow info about un1:");
            un1.ShowInfo();
            Console.WriteLine("\nShow info about fc2:");
            fc2.ShowInfo();
            Console.WriteLine("\nShow count of faculty in university un2:");
            un2.ShowCountOfFaculty();
            School[] schools = { sc1, sc2, sc3 };
            SortCountStudent(schools);
   
            //Console.WriteLine("If you wanna create your university, enter 1; \nIf you wanna create your faculty, enter 2; \nIf you wanna create your school, enter 3");
            //int choice=0;
            //while(true)
            //{
            //    choice = Convert.ToInt32(Console.ReadLine());

            //    if (choice == 1)
            //    {
            //        University un3 = new University();
            //        un3.Create();
            //        Console.WriteLine("Information writed in University.txt");
            //    }
            //    if (choice == 2)
            //    {
            //        Faculty fc3 = new Faculty();
            //        fc3.Create();
            //        Console.WriteLine("Information writed in Faculty.txt");
            //    }
            //    if (choice == 3)
            //    {
            //        School sc3 = new School();
            //        sc3.Create();
            //        Console.WriteLine("Information writed in School.txt");
            //    }
            //}    
        }

        public static void SortCountStudent(School[] schools)
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Count of students(1) OR Count of Classes(2)");
            if (choice ==1)
            {
                var fuel = schools.OrderByDescending(p => p.countOfStudents);
                foreach (var p in fuel)
                    Console.WriteLine($"{p.name} - {p.countOfStudents} ");
            }
            if (choice ==2)
            {
                var fuel = schools.OrderByDescending(p => p.countOfClass);
                foreach (var p in fuel)
                    Console.WriteLine($"{p.name} - {p.countOfClass} ");
            }
        }
        public static void SortCountStudent(University[] universities)
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Count of students(1) OR Count of Faculty(2)");
            if (choice == 1)
            {
                var fuel = universities.OrderByDescending(p => p.countOfStudents);
                foreach (var p in fuel)
                    Console.WriteLine($"{p.name} - {p.countOfStudents} ");
            }
            if (choice == 2)
            {
                var fuel = universities.OrderByDescending(p => p.countOfFaculty);
                foreach (var p in fuel)
                    Console.WriteLine($"{p.name} - {p.countOfFaculty} ");
            }
        }
        public static void SortCountStudent(Faculty[] faculties)
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Count of students(1) OR Year of foundation (2)");
            if (choice == 1)
            {
                var fuel = faculties.OrderBy(p => p.countOfStudents);
                foreach (var p in fuel)
                    Console.WriteLine($"{p.name} - {p.countOfStudents} ");
            }
            if (choice == 2)
            {
                var fuel = faculties.OrderBy(p => p.yearOfFoundation);
                foreach (var p in fuel)
                    Console.WriteLine($"{p.name} - {p.yearOfFoundation} ");
            }
        }
    }
}

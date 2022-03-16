using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_II
{
    interface IEducationInstitution
    {
        string name { get; set; }
        int countOfStudents { get; set; }
        int countOfTeachers { get; set; }
        void ShowInfo();
        void Create();   
    }
}

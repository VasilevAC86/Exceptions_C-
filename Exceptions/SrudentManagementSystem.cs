using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class StudentManagementSystem
    {
        private List<Student> students = new List<Student> {};
        public void AddStudent (string name, int age)
        {            
            students.Add(new Student(name, age));
        }
        public void RemoveStudent (string name) 
        { 
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                    students.RemoveAt(i);
            }
        }
        public Student GetStudentByName(string name)
        {
            for (int i = 0; i < students.Count; ++i)
            {
                if (students[i].Name == name)
                    return students[i];
                if (i == students.Count - 1)
                    throw new StudentNotFoundException("Студент не найден");
            }           
            return students[0];
        }
    }
}

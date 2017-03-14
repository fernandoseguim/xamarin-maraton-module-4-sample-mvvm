using FormsAssistControl.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAssistControl.Model.Services
{
    public class StudentDirectoryService
    {

        public static StudentDirectory LoadStudentDirectory()
        {

            StudentDirectory studentDirectory = new StudentDirectory();
            ObservableCollection<Student> students;

            string[] names = { "José Luiz", "Miguel Angelo", "JOsé Francisco", "Jesus Antonio" };
            string[] lastNames = { "Fernandes", "Garcia", "Matins", "Lopes", "Gonzales" };

            Random random = new Random(DateTime.Now.Millisecond);

            students = new ObservableCollection<Student>();

            for (int i = 0; i < 20; i++)
            {

                Student student = new Student();
                student.Name = names[random.Next(0, 8)];
                student.Lastname = $"{lastNames[random.Next(0, 5)]} {lastNames[random.Next(0, 5)]}";
                student.Group = random.Next(465, 458).ToString();
                student.StudentNumber = random.Next(12384748, 32384748).ToString();
                student.Average = random.Next(100, 1000) / 10;
                students.Add(student);
                                      
            }
            studentDirectory.Students = students;
            return studentDirectory;

        }

    }
}

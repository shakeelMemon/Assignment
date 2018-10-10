using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Tests.Unit
{
    public class TestUtility
    {

        static string[] courses = { "Math", "Science", "Literature", "Physichal Education" };
        static int[] marks = { 95, 80, 50, 40 };


        public static Diploma GenerateDiploma()
        {
            return new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };
        }
        public static Student[] GenerateStudents(int studentCount)
        {
            Student[] students = new Student[studentCount];

            if (studentCount > 4)
                return students;

            for (int i = 0; i < studentCount; i++)            
                students[i] = GenerateStudent(0, marks[i]);         

            return students;
        }

        private static Student GenerateStudent(int id, int marks)
        {
            Student student = new Student() { Id = id };
            int courseCount = 4;

            student.Courses = new Course[courseCount];            
            for(int i=0; i<courseCount; i++)
                student.Courses[i] = GenerateCourse(i, courses[i], marks);

            return student;
        }
        
        private static Course GenerateCourse(int id, string name, int mark)
        {
            return new Course { Id = id, Name = name, Mark = mark };
        }
    }
}

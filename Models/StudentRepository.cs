namespace StudentManagementApp.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class StudentRepository
    {
        private static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "John Doe", Age = 20, Course = "Computer Science" },
        new Student { Id = 2, Name = "Jane Smith", Age = 22, Course = "Mathematics" }
    };

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
        }
    }

}

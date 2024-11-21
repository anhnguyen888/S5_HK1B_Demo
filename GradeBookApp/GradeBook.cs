using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookApp
{
    internal class GradeBook
    {
        private List<Student> students = new List<Student>();

        public GradeBook() { }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        // Tìm sinh viên có điểm cao nhất trong danh sách sinh viên
        public float FindHighestScore()
        {
            // sử dụng truy vấn LINQ 
            return students.Max(s => s.Score);
        }
        public float AverageScore()
        {
            // sử dụng truy vấn LINQ 
            return students.Average(s => s.Score);
        }
    }
}

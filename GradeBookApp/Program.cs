using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            GradeBook gradeBook = new GradeBook();

            // Thêm sinh viên vào danh sách
            while (true)
            {
                Console.WriteLine("Nhập điểm sinh viên: ");
                float score = float.Parse(Console.ReadLine());               

                Student student = new Student
                {
                    Score = score
                };

                gradeBook.AddStudent(student);

                Console.WriteLine("Nhấn phím bất kỳ để tiếp tục, nhấn 'q' để thoát");
                if (Console.ReadLine().ToLower() == "q")
                {
                    break;
                }
            }

            // Hiển thị điểm cao nhất và điểm trung bình
            Console.WriteLine("Điểm cao nhất: " + gradeBook.FindHighestScore());
            Console.WriteLine("Điểm trung bình: " + gradeBook.AverageScore());

            Console.ReadLine();
        }
    }
}

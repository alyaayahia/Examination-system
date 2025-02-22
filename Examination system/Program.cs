using Examination_system.Answer;
using Examination_system.Exam;
using Examination_system.Qoestions;
using System.Diagnostics;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

        
            Subject subject = new Subject(subjectId, subjectName);
            subject.createExam();
            Console.Clear();
            Console.WriteLine("\nStarting Exam...");
            subject.Exam.ShowExam();
        }
    }
}

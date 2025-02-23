using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Examination_system.Exam
{
    public class FinalExam : Exams
    {
        public FinalExam(int timeOfExam, int numberOfQuestion) : base(timeOfExam, numberOfQuestion) { }
        public override void ShowExam()
        {
            int score = 0;
            Console.WriteLine("//////////////////The Final Exam start///////////////////");
            foreach (var Question in Questions)
            {
                Question.DisplayQuestion();
                Console.Write("Your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (Question.CheckAnswer(userAnswer))
                {
                    score += Question.Mark;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"the Final Exam is finished  Your Score: {score}/{TotalMarks()}");
            Console.WriteLine("Correct Answers:");
            foreach (var q in Questions)
            {
                Console.WriteLine($"Question: {q.BodyOfQuestion} | Correct Answer: {q.CorrectAnswer.AnswerText}");
            }
        }
        private int TotalMarks()
        {
            int total = 0;
            foreach (var Question in Questions)
            {
                total += Question.Mark;
            }
            return total;
        }
    }
}

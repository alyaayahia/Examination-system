using Examination_system.Qoestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exam
{
    public abstract class Exams
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }
        public List<Question> Questions { get; set; }

        protected Exams(int timeOfExam, int numberOfQuestion)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestion = numberOfQuestion;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();
    }
}

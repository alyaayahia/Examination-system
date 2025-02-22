using Examination_system.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace Examination_system.Qoestions
{
    public abstract class Question: ICloneable,IComparable<Question>
    {
        public string HeaderOfQuestion { get; set; }
        public string BodyOfQuestion { get; set; }
        public int Mark { get; set; }
        public List<Answers> AnswersList { get; set; }
        public Answers CorrectAnswer { get; set; }
        protected Question(string headerOfQuestion, string bodyOfQuestion, int mark, Answers correctAnswer,List<Answers> answers)
        {
            HeaderOfQuestion = headerOfQuestion;
            BodyOfQuestion = bodyOfQuestion;
            Mark = mark;
            AnswersList = answers;
            CorrectAnswer = correctAnswer;
        }
        public abstract void DisplayQuestion();
        public abstract bool CheckAnswer(int userAnswer);
        public object Clone() => this.MemberwiseClone();
        public int CompareTo(Question other) => this.Mark.CompareTo(other.Mark);

    }
}

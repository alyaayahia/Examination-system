using Examination_system.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Qoestions
{
    public class MultipleChoiceQuestions : Question
    {
        public MultipleChoiceQuestions(string bodyOfQuestion, int mark, Answers correctAnswer, List<Answers> answers) : base("MSQ", bodyOfQuestion, mark, correctAnswer, answers)
        {}
        public override bool CheckAnswer(int userAnswer)
        {
            Answers SelectAnswer = AnswersList.Find(a => a.AnswerID == userAnswer);
            return SelectAnswer != null && SelectAnswer.AnswerText == CorrectAnswer.AnswerText;
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{HeaderOfQuestion}: {BodyOfQuestion} (Mark: {Mark})");
            for (int i = 0; i < AnswersList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswersList[i].AnswerText}");
            }
        }

       
    }
}

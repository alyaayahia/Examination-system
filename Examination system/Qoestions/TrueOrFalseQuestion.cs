using Examination_system.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Qoestions
{
    public class TrueOrFalseQuestion : Question
    {

        public TrueOrFalseQuestion(string bodyOfQuestion, int mark, Answers correctAnswer) :
        base("True OR False", bodyOfQuestion, mark, correctAnswer, new List<Answers> { new Answers(1, "True"), new Answers(2, "False") })
        { }

        public override bool CheckAnswer(int userAnswer)
        {
            Answers SelectAnswer = AnswersList.Find(a => a.AnswerID == userAnswer);
            return SelectAnswer != null && SelectAnswer.AnswerText==CorrectAnswer.AnswerText;
        }       
        public override void DisplayQuestion()
        {
            Console.WriteLine($"{HeaderOfQuestion}: {BodyOfQuestion} (Mark: {Mark})");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }

        /*
         /public override void DisplayQuestion()
        //{
        //    Console.WriteLine($"{HeaderOfQuestion}: {BodyOfQuestion}, (Marks : {Mark})");
        //    for (int i = 0; i < AnswersList.Count; i++)
        //    {
        //        Console.WriteLine($"{CorrectAnswer.AnswerID}:  {CorrectAnswer.AnswerText}");


        //    }
        //}
 
         
         */

    }
}

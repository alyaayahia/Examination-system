using Examination_system.Answer;
using Examination_system.Exam;
using Examination_system.Qoestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exams Exam { get; set; }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
            Exam = null;
        }
       public void createExam()
        {
         
            Console.WriteLine("Choose Exam Type (1: Final, 2: Practical): ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please Enter the number of Question :  ");
            int NumberOfQuestion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please Enter Time Of Exam (Minutes) :  ");
            int TimeOfExam = int.Parse(Console.ReadLine());
            Exam = choice == 1 ? new FinalExam(TimeOfExam, NumberOfQuestion) : new PracticalExam(TimeOfExam, NumberOfQuestion);
           if(choice==1)
            {
                Console.WriteLine();
                Console.WriteLine("*********The Final Exam*************");
                for (int i=0;i< NumberOfQuestion;i++)
                {                    
                    Console.WriteLine($"please enter the type of Question {i+1} ==> (1)- true or false ,(2) MSQ ");
                    int QuestionType = int.Parse(Console.ReadLine());
                    Console.Write("Enter question text: ");
                    string body = Console.ReadLine();
                    Console.Write("Enter question mark: ");
                    int mark = int.Parse(Console.ReadLine());
                    if (QuestionType==1)
                    {
                        Console.Write("Enter correct answer (1: True, 2: False): ");
                        int correctAnswerId = int.Parse(Console.ReadLine());
                        Answers correctAnswer = new Answers(correctAnswerId, correctAnswerId == 1 ? "True" : "False");
                        Exam.Questions.Add(new TrueOrFalseQuestion(body, mark, correctAnswer));
                    }
                    else if(QuestionType==2)
                    {
                        List<Answers> AnswersList = new List<Answers>();
                        Console.Write("Enter number of choices: ");
                        int numChoices = int.Parse(Console.ReadLine());
                       
                        for (int j = 1; j <= numChoices; j++)
                        {
                            Console.Write($"Enter choice {j}: ");
                            string answerText = Console.ReadLine();
                            AnswersList.Add(new Answers(j, answerText));
                        }

                        Console.Write("Enter correct answer number: ");
                        int correctId = int.Parse(Console.ReadLine());
                        Answers correctAnswer = AnswersList.Find(a => a.AnswerID == correctId);
                        Exam.Questions.Add(new MultipleChoiceQuestions(body, mark, correctAnswer, AnswersList));
                    }
                    
                }
            }
           else if(choice == 2)
            {
                Console.WriteLine("the Practical Exam");
                for (int i = 0; i < NumberOfQuestion; i++)
                {
                    Console.WriteLine($"\nQuestion {i + 1}: ");
                    Console.Write("Enter question text: ");
                    string body = Console.ReadLine();

                    Console.Write("Enter question mark: ");
                    int mark;
                    while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                    {
                        Console.WriteLine("Invalid input! Please enter a positive number for question mark.");
                    }

                    List<Answers> answersList = new List<Answers>();

                    Console.Write("Enter number of choices: ");
                    int numChoices;
                    while (!int.TryParse(Console.ReadLine(), out numChoices) || numChoices < 2)
                    {
                        Console.WriteLine("Invalid input! Please enter a number (minimum 2 choices).");
                    }

                    for (int j = 1; j <= numChoices; j++)
                    {
                        Console.Write($"Enter choice {j}: ");
                        string answerText = Console.ReadLine();
                        answersList.Add(new Answers(j, answerText));
                    }

                    Console.Write("Enter correct answer number: ");
                    int correctId;
                    while (!int.TryParse(Console.ReadLine(), out correctId) || correctId < 1 || correctId > numChoices)
                    {
                        Console.WriteLine($"Invalid input! Please enter a number between 1 and {numChoices}.");
                    }

                    Answers correctAnswer = answersList.Find(a => a.AnswerID == correctId);
                    Exam.Questions.Add(new MultipleChoiceQuestions(body, mark, correctAnswer, answersList));
                }
            }
        }
  
    }


}

/*
 ////////////to one Question
   //Console.WriteLine("please enter the type of Question : ");
                //Console.WriteLine();

                //Console.Write("Enter question text: ");
                //string body = Console.ReadLine();
                //Console.Write("Enter question mark: ");
                //int mark = int.Parse(Console.ReadLine());
                //List<Answers> AnswersList = new List<Answers>();


                //Console.Write("Enter number of choices: ");
                //int numChoices = int.Parse(Console.ReadLine());

                //for (int j = 1; j <= numChoices; j++)
                //{
                //    Console.Write($"Enter choice {j}: ");
                //    string answerText = Console.ReadLine();
                //    AnswersList.Add(new Answers(j, answerText));
                //}

                //Console.Write("Enter correct answer number: ");
                //int correctId = int.Parse(Console.ReadLine());
                //Answers correctAnswer = AnswersList.Find(a => a.AnswerID == correctId);
                //Exam.Questions.Add(new MultipleChoiceQuestions(body, mark, correctAnswer, AnswersList));
 */



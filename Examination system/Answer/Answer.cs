
namespace Examination_system.Answer
{
    public class Answers
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }

        public Answers(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        }
    }
}
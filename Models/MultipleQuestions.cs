namespace DatingApp.API.Models
{
    public class MultipleQuestions
    {
        public int Id {get;set;}
        public string Question {get;set;}
        public MultipleAnswers MultipleAnswers {get;set;}
        public int MultipleAnswersId {get;set;}

    }
}
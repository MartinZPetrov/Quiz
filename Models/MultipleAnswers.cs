namespace DatingApp.API.Models
{
    public class MultipleAnswers
    {
        public int Id {get;set;}
        public string FirstAnswer {get;set;}
        public string SecondAnswer {get;set;}
        public string ThirdAnswer {get;set;}

        public bool FirstAnswerCorrect {get;set;}
        public bool SecondAnswerCorrect {get;set;}
        public bool ThirAnswerCorrect{get;set;}
    }
}
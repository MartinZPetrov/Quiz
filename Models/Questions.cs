namespace DatingApp.API.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question {get;set; }
        public Answers Answer {get;set;}
        public int AnswersId {get;set;}
    }
}
namespace Quiz.API.Models
{
    public class Questions
    {
        public int Id { get; set; }

        protected string _question;
        public string Question 
        {
            get { return this._question?.Trim(); }
            set { this._question = value?.Trim();}
        }
        public Answers Answer {get;set;}
        public int AnswersId {get;set;}
    }
}
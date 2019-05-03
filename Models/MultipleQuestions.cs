namespace Quiz.API.Models
{
    public class MultipleQuestions
    {
        public int Id {get;set;}
        protected string _question;
        public string Question 
        {
            get { return this._question?.Trim(); }
            set { this._question = value?.Trim();}
        }        
        public MultipleAnswers MultipleAnswers {get;set;}
        public int MultipleAnswersId {get;set;}

    }
}
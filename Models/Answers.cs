namespace Quiz.API.Models
{
    public class Answers
    {
        public int Id {get;set;}
        protected string _answer;
        public string Answer 
        {
            get { return this._answer?.Trim(); }
            set { this._answer = value?.Trim();}
        }
        protected string _correctAnswer;
        public string CorrectAnswer
        {
            get { return this._correctAnswer?.Trim(); }
            set { this._correctAnswer = value?.Trim();}
        }
    }
}
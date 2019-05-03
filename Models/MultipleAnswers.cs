namespace Quiz.API.Models
{
    public class MultipleAnswers
    {
        public int Id {get;set;}
        protected string _firstAnswer;
        public string FirstAnswer 
        {
            get { return this._firstAnswer?.Trim(); }
            set { this._firstAnswer = value?.Trim();}
        }    
        protected string _secondAnswer;
        public string SecondAnswer 
        {
            get { return this._secondAnswer?.Trim(); }
            set { this._secondAnswer = value?.Trim();}
        } 
        
        protected string _thirdAnswer;
        public string ThirdAnswer 
        {
            get { return this._thirdAnswer?.Trim(); }
            set { this._thirdAnswer = value?.Trim();}
        } 
        public bool FirstAnswerCorrect  {get;set;}
        public bool SecondAnswerCorrect  {get;set;}
        public bool ThirdAnswerCorrect {get;set;}
    }
}
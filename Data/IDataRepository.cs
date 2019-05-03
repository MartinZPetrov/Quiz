using System.Collections.Generic;
using System.Threading.Tasks;
using Quiz.API.Models;

namespace Quiz.API.Data
{
    public interface IDataRepository
    {
         Task<List<Settings>> GetSettings();
         Task<List<Questions>> GetQuestions();
         Task<List<MultipleQuestions>> GetMultipleQuestions();

    }
}
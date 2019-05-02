using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDataRepository
    {
         Task<List<Settings>> GetSettings();
         Task<List<Questions>> GetQuestions ();
         Task<List<MultipleQuestions>> GetMultipleQuestions();

    }
}
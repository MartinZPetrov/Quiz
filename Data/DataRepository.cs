using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.API.Models;
using Microsoft.EntityFrameworkCore;
namespace Quiz.API.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _context;
        public DataRepository (DataContext context)
        {
            _context = context;
        }
        public async Task<List<MultipleQuestions>> GetMultipleQuestions()
        {
            var multipleQuestions = await _context.MultileQuestions.Include(e=>e.MultipleAnswers).ToListAsync();
            return multipleQuestions;
        }

        public async Task<List<Questions>> GetQuestions()
        {
            var questions = await _context.Questions.Include(e => e.Answer).ToListAsync();
            return questions;
        }

        public async Task<List<Settings>> GetSettings()
        {
            var settings =  await _context.Settings.ToListAsync();
            return settings;
        }
    }
}
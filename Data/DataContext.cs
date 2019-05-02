using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Answers> Answers {get; set;}
        public DbSet<Questions> Questions {get;set;}
        public DbSet<Settings> Settings {get;set;}
        public DbSet<MultipleAnswers> MultipleAnswers {get;set;}
        public DbSet<MultipleQuestions> MultileQuestions {get;set;}
        

    }
}
using CSharpCodeAnaliserWebApi.CodeAnaliser.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpCodeAnaliserWebApi
{
    public class PostgresDatabase : DbContext
    {  
        public PostgresDatabase()
        {
        }
        public DbSet<ValidatorRuleEntity> Validation_Rules { get; set; }
        public DbSet<TestCaseEntity> Test_Cases { get; set; }   
        public DbSet<CodeExcerciseEntity> Code_Excercise { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseNpgsql("Host=localhost:9999;Database=postgres;Username=postgres;Password=admin");
    }
}

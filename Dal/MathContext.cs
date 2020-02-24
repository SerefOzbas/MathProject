using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MathContext : DbContext
    {
        public MathContext() : base(@"Server=.;Database=MathProjectDb;Integrated Security=true;")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                 .HasRequired(a => a.Category)
                .WithMany(a => a.Questions)
                .HasForeignKey(a => a.CategoryId);
            modelBuilder.Entity<Question>()
                .HasRequired(a => a.User)
                .WithMany(a => a.Questions)
                .HasForeignKey(a => a.UserId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Answer>()
                .HasRequired(a => a.User)
                .WithMany(a => a.Answers)
                .HasForeignKey(a => a.UserId);
            modelBuilder.Entity<Answer>()
                .HasRequired(a => a.Question)
                .WithMany(a => a.Answers)
                .HasForeignKey(a => a.QuestionId);
               


            modelBuilder.Properties().Where(a => a.PropertyType == typeof(DateTime)).Configure(a => a.HasColumnType("datetime2"));
        }
    }
    
}

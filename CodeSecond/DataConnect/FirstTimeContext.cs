using Microsoft.EntityFrameworkCore;
using CodeSecond.DTOs;

namespace CodeSecond.DataConnect
{
    public class FirstTimeContext : DbContext
    {
        public FirstTimeContext() : base()
        {
        }

        public DbSet<GradeDTO> Grades { get; set; }
        public DbSet<StudentDTO> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=YourSApasswordNotMine;database=CodeFirst");
                //change the password dude.
            }
        }
    }
}

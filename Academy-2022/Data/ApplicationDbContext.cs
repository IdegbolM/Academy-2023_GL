using Academy_2022.Data;
using Academy_2023.Data;
using Microsoft.EntityFrameworkCore;

namespace Academy_2023.Data
{
    public class ApplicationDbContext : DbContext
    {
        public string DbPath { get; set; }

        public DbSet<User> Users { get; set; } = null;
        public DbSet<Course> Courses { get; set; } = null;


        public ApplicationDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "academy2.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite($"Data Source={DbPath}");

            base.OnConfiguring(optionBuilder);
        }
    }


}

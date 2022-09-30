using Extranet.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Extranet.Infrastructure.Persistence
{
    public class ExtranetDbContext : DbContext
    {
        public ExtranetDbContext(DbContextOptions<ExtranetDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//todo códgio foi refatorado para a pasta Configurations
        }
    }
}

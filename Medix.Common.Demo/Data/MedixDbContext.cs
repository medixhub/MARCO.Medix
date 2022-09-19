
using Medix.Common.Demo.Models;
using Medix.Dtos;
using Microsoft.EntityFrameworkCore;
using Physician = Medix.Common.Demo.Models.Physician;

namespace Medix.Common.Demo.Data
{
    public class MedixDbContext : DbContext
    {
        public MedixDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

         
        }
        public DbSet<Study> Studies { get; set; }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<IssueCode> IssueCodes { get; set; }
    }
}

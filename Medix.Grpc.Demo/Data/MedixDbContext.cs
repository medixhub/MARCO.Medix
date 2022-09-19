
using Medix.Dtos;
using Microsoft.EntityFrameworkCore;
using Physician = Medix.Grpc.Demo.Models.Physician;

namespace Medix.Grpc.Demo.Data
{
    public class MedixDbContext : DbContext
    {
        public MedixDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

         
        }
        public DbSet<Models.Study> Studies { get; set; }
        public DbSet<Models.Physician> Physicians { get; set; }
        public DbSet<Models.IssueCode> IssueCodes { get; set; }
    }
}

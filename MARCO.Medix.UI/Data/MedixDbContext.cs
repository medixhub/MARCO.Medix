
using MARCO.Medix.Dtos;
using Microsoft.EntityFrameworkCore;
using Physician = MARCO.Medix.UI.Models.Physician;

namespace MARCO.Medix.UI.Data
{
    public class MedixDbContext : DbContext
    {
        public MedixDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Physician>().HasData(
                new Physician()
                {
                    PhysicianId = "10001",
                    Name = "Name 10001",
                    Code = "10001",
                    Gender = Gender.Male,
                    Address="a1",
                    InsertDate = DateTime.Now,   
                    Phone= "01",
                    RefuteDescription="",
                    Specialty="",
                    

                }, new Physician()
                {
                    PhysicianId = "10002",
                    Name = "Name 10002",
                    Code = "10002",
                    Gender = Gender.Male,
                    Address = "a1",
                    InsertDate = DateTime.Now,
                    Phone = "01",
                    RefuteDescription = "",
                    Specialty = "",


                }, new Physician()
                {
                    PhysicianId = "10003",
                    Name = "Name 10003",
                    Code = "10003",
                    Gender = Gender.Male,
                    Address = "a1",
                    InsertDate = DateTime.Now,
                    Phone = "01",
                    RefuteDescription = "",
                    Specialty = "",


                }, new Physician()
                {
                    PhysicianId = "10004",
                    Name = "Name 10004",
                    Code = "10004",
                    Gender = Gender.Male,
                    Address = "a1",
                    InsertDate = DateTime.Now,
                    Phone = "01",
                    RefuteDescription = "",
                    Specialty = "",


                }



                );
        }
        public DbSet<Models.Code> Codes { get; set; }
        public DbSet<Models.Physician> Physicians { get; set; }
    }
}

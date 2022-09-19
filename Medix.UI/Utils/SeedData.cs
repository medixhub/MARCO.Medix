

using Medix.Dtos;
using Medix.UI.Data;
using Medix.UI.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Physician = Medix.UI.Models.Physician;

namespace Medix.UI.Utils;
public class SeedData
{
    public static void AddPhysicians(MedixDbContext dbContext)
    {
        List<Physician> data = new List<Physician>()
            {
                new Physician()
                        {
                PhysicianId = "10001",
                Name = "Name 10001",
                Code = "10001",
                Gender = Gender.Male,
                Address = "a1",
                InsertDate = DateTime.Now,
                Phone = "01",
                RefuteDescription = "",
                Specialty = "",
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
        };

        dbContext.Physicians.AddRange(data);
        dbContext.SaveChanges();

    }
}


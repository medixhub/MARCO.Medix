﻿
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

         
        }
        public DbSet<Models.Study> Studies { get; set; }
        public DbSet<Models.Physician> Physicians { get; set; }
        public DbSet<Models.IssueCode> IssueCodes { get; set; }
    }
}

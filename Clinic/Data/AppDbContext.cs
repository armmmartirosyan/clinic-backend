using Clinic.Models;

namespace Clinic.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Dentists> Dentists { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<ProcedureImages> ProcedureImages { get; set; }
        public DbSet<ProcedureNames> ProcedureNames { get; set; }
        public DbSet<Procedures> Procedures { get; set; }
        public DbSet<Registrations> Registrations { get; set; }
        public DbSet<WeekDaySchedule> WeekDaySchedule {  get; set; }
        public DbSet<NotWorkingDays> NotWorkingDays { get; set; }
        public DbSet<MedicinesAssigned> MedicinesAssigned { get; set; }
    }
}

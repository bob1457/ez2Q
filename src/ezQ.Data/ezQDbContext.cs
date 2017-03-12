using ezQ.Core.Entities;
using Clinic = ezQ.Core.Entities.Clinic;

namespace ezQ.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ezQDbContext : DbContext
    {
        static ezQDbContext()
        {
            Database.SetInitializer<ezQDbContext>(null);
        }

        public ezQDbContext()
            : base("name=ezQDbContext")
        {

        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<ClincType> ClincTypes { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<ClinicAddress> ClinicAddresses { get; set; }
        public virtual DbSet<ClinicCategory> ClinicCategories { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<WalkInWaitList> WalkInWaitLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.AppointmentStatus)
                .IsFixedLength();

            modelBuilder.Entity<ClincType>()
                .HasMany(e => e.Clinics)
                .WithRequired(e => e.ClinicType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClinicAddress>()
                .HasMany(e => e.Clinics)
                .WithRequired(e => e.ClinicAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClinicCategory>()
                .HasMany(e => e.Clinics)
                .WithRequired(e => e.ClinicCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.WalkInWaitLists)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);
        }
    }
}

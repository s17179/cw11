﻿using cw11.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        public DoctorDbContext()
        {

        }

        public DoctorDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorEfConfiguration());
            modelBuilder.ApplyConfiguration(new PatientEfConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionEfConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentEfConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionMedicamentEfConfiguration());
        }
    }
}

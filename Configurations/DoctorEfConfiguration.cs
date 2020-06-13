using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasKey(d => d.IdDoctor);

            builder
                .Property(d => d.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(d => d.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(d => d.Email)
                .HasMaxLength(100)
                .IsRequired();

            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jankow@gmail.com" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Andrzej", LastName = "Kowalski", Email = "andkow@gmail.com" });
            doctors.Add(new Doctor { IdDoctor = 3, FirstName = "Krzysztof", LastName = "Kowalski", Email = "krzkow@gmail.com" });

            builder
                .HasData(doctors);
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw11.Models;

namespace cw11.Migrations
{
    [DbContext(typeof(DoctorDbContext))]
    [Migration("20200613121252_AddMedicamentTable")]
    partial class AddMedicamentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "jankow@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "andkow@gmail.com",
                            FirstName = "Andrzej",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "krzkow@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Kowalski"
                        });
                });

            modelBuilder.Entity("cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2020, 6, 13, 14, 12, 51, 571, DateTimeKind.Local).AddTicks(8753),
                            FirstName = "Łukasz",
                            LastName = "Trybiel"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2020, 6, 13, 14, 12, 51, 578, DateTimeKind.Local).AddTicks(4515),
                            FirstName = "Adam",
                            LastName = "Opol"
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("Date");

                    b.Property<int?>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int?>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 6, 13, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(5678),
                            DueDate = new DateTime(2020, 6, 23, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(6423),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 6, 13, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8493),
                            DueDate = new DateTime(2020, 6, 23, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8531),
                            IdDoctor = 2,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2020, 6, 13, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8564),
                            DueDate = new DateTime(2020, 6, 23, 14, 12, 51, 580, DateTimeKind.Local).AddTicks(8568),
                            IdDoctor = 2,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription", b =>
                {
                    b.HasOne("cw11.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor");

                    b.HasOne("cw11.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient");
                });
#pragma warning restore 612, 618
        }
    }
}
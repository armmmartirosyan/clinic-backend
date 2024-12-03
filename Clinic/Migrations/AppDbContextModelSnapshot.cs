﻿// <auto-generated />
using System;
using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clinic.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Clinic.Models.Dentists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("image_url");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("CHAR(32)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("phone");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Dentists");
                });

            modelBuilder.Entity("Clinic.Models.MedicinesAssigned", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<sbyte>("DayCount")
                        .HasColumnType("TINYINT")
                        .HasColumnName("day_count");

                    b.Property<string>("Dose")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("dose");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("name");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("notes");

                    b.Property<sbyte>("Quantity")
                        .HasColumnType("TINYINT")
                        .HasColumnName("quantity");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("DATE")
                        .HasColumnName("start_date");

                    b.HasKey("Id");

                    b.ToTable("medicines_assigned");
                });

            modelBuilder.Entity("Clinic.Models.NotWorkingDays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATE")
                        .HasColumnName("date");

                    b.Property<int>("DentistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DentistId");

                    b.ToTable("not_wordking_days");
                });

            modelBuilder.Entity("Clinic.Models.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATE")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("image_url");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("CHAR(32)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Clinic.Models.ProcedureImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("procedure_images");
                });

            modelBuilder.Entity("Clinic.Models.ProcedureNames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("procedure_names");
                });

            modelBuilder.Entity("Clinic.Models.Procedures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATE")
                        .HasColumnName("date");

                    b.Property<int>("DentistId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TIME")
                        .HasColumnName("end_time");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("notes");

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(10,2)")
                        .HasColumnName("price");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TIME")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.HasIndex("DentistId");

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("Clinic.Models.Registrations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<TimeSpan>("CallingTime")
                        .HasColumnType("TIME")
                        .HasColumnName("calling_time");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATE")
                        .HasColumnName("date");

                    b.Property<int>("DentistId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TIME")
                        .HasColumnName("end_time");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("notes");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TIME")
                        .HasColumnName("start_time");

                    b.Property<sbyte>("Status")
                        .HasColumnType("TINYINT")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("DentistId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Clinic.Models.Specializations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Clinic.Models.WeekDaySchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<TimeSpan>("BreakEndTime")
                        .HasColumnType("TIME")
                        .HasColumnName("break_end_time");

                    b.Property<TimeSpan>("BreakStartTime")
                        .HasColumnType("TIME")
                        .HasColumnName("break_start_time");

                    b.Property<sbyte>("DayOfWeek")
                        .HasColumnType("TINYINT")
                        .HasColumnName("day_of_week");

                    b.Property<int>("DentistId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TIME")
                        .HasColumnName("end_time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TIME")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.HasIndex("DentistId");

                    b.ToTable("week_day_schedule");
                });

            modelBuilder.Entity("Clinic.Models.Dentists", b =>
                {
                    b.HasOne("Clinic.Models.Specializations", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("Clinic.Models.NotWorkingDays", b =>
                {
                    b.HasOne("Clinic.Models.Dentists", "Dentist")
                        .WithMany("NotWorkingDays")
                        .HasForeignKey("DentistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dentist");
                });

            modelBuilder.Entity("Clinic.Models.Procedures", b =>
                {
                    b.HasOne("Clinic.Models.Dentists", "Dentist")
                        .WithMany("Procedures")
                        .HasForeignKey("DentistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dentist");
                });

            modelBuilder.Entity("Clinic.Models.Registrations", b =>
                {
                    b.HasOne("Clinic.Models.Dentists", "Dentist")
                        .WithMany("Registrations")
                        .HasForeignKey("DentistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dentist");
                });

            modelBuilder.Entity("Clinic.Models.WeekDaySchedule", b =>
                {
                    b.HasOne("Clinic.Models.Dentists", "Dentist")
                        .WithMany("WeekDaySchedule")
                        .HasForeignKey("DentistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dentist");
                });

            modelBuilder.Entity("Clinic.Models.Dentists", b =>
                {
                    b.Navigation("NotWorkingDays");

                    b.Navigation("Procedures");

                    b.Navigation("Registrations");

                    b.Navigation("WeekDaySchedule");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using MOD_AuthenticationService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD_AuthenticationService.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20191122102808_authen")]
    partial class authen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD_AuthenticationService.Models.Mentor", b =>
                {
                    b.Property<long>("MentorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("From_Time_slot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Mentor_Avail")
                        .HasColumnType("bit");

                    b.Property<int>("Mentor_Contact")
                        .HasColumnType("int");

                    b.Property<string>("Mentor_Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Mentor_active")
                        .HasColumnType("bit");

                    b.Property<string>("Mentor_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To_Time_slot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MentorId");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD_AuthenticationService.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<float>("AmountMentor")
                        .HasColumnType("real");

                    b.Property<long>("MentorId")
                        .HasColumnType("bigint");

                    b.Property<string>("MentorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Student_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.HasIndex("MentorId");

                    b.HasIndex("Student_Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("MOD_AuthenticationService.Models.Student", b =>
                {
                    b.Property<long>("Student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Student_Contact")
                        .HasColumnType("int");

                    b.Property<string>("Student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Student_active")
                        .HasColumnType("bit");

                    b.Property<string>("Student_email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MOD_AuthenticationService.Models.Technology", b =>
                {
                    b.Property<long>("Tech_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Fees")
                        .HasColumnType("int");

                    b.Property<string>("TOC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tech_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tech_id");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("MOD_AuthenticationService.Models.Training", b =>
                {
                    b.Property<string>("Training_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MentorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Student_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Tech_id")
                        .HasColumnType("bigint");

                    b.Property<string>("timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Training_id");

                    b.HasIndex("MentorId");

                    b.HasIndex("Student_Id");

                    b.HasIndex("Tech_id");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("MOD_AuthenticationService.Models.Payment", b =>
                {
                    b.HasOne("MOD_AuthenticationService.Models.Mentor", "Mentor")
                        .WithMany("Payments")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD_AuthenticationService.Models.Student", "Student")
                        .WithMany("Payments")
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOD_AuthenticationService.Models.Training", b =>
                {
                    b.HasOne("MOD_AuthenticationService.Models.Mentor", "Mentor")
                        .WithMany("Trainings")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD_AuthenticationService.Models.Student", "Student")
                        .WithMany("Trainings")
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD_AuthenticationService.Models.Technology", "Technology")
                        .WithMany("Trainings")
                        .HasForeignKey("Tech_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

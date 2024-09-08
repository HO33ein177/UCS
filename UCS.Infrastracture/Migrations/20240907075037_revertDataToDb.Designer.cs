﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UCS.Infrastracture.Data;

#nullable disable

namespace UCS.Infrastracture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240907075037_revertDataToDb")]
    partial class revertDataToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UCS.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<long>("UniqueMemberId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("UCS.Domain.Entities.Course", b =>
                {
                    b.Property<long>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseId"));

                    b.Property<int>("CourseCapacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CourseExamDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("CourseFee")
                        .HasColumnType("float");

                    b.Property<string>("Days")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("ExamDurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("StartHour")
                        .HasColumnType("time");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1L,
                            CourseCapacity = 100,
                            CourseExamDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseFee = 50.0,
                            Days = "[0,2]",
                            DepartmentId = 5,
                            DurationMinutes = 120,
                            ExamDurationMinutes = 0,
                            Level = 0,
                            Name = "Calculus 1",
                            StartHour = new TimeOnly(10, 30, 0),
                            Units = 4
                        },
                        new
                        {
                            CourseId = 2L,
                            CourseCapacity = 100,
                            CourseExamDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseFee = 50.0,
                            Days = "[6,1]",
                            DepartmentId = 5,
                            DurationMinutes = 120,
                            ExamDurationMinutes = 0,
                            Level = 0,
                            Name = "Calculus 2",
                            StartHour = new TimeOnly(10, 30, 0),
                            Units = 4
                        },
                        new
                        {
                            CourseId = 3L,
                            CourseCapacity = 100,
                            CourseExamDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseFee = 50.0,
                            Days = "[0,2]",
                            DepartmentId = 3,
                            DurationMinutes = 120,
                            ExamDurationMinutes = 0,
                            Level = 0,
                            Name = "Holiday Physics 1",
                            StartHour = new TimeOnly(8, 30, 0),
                            Units = 3
                        },
                        new
                        {
                            CourseId = 4L,
                            CourseCapacity = 100,
                            CourseExamDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseFee = 50.0,
                            Days = "[6,1]",
                            DepartmentId = 3,
                            DurationMinutes = 120,
                            ExamDurationMinutes = 0,
                            Level = 0,
                            Name = "Holiday Physics 2",
                            StartHour = new TimeOnly(8, 30, 0),
                            Units = 3
                        });
                });

            modelBuilder.Entity("UCS.Domain.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("DepartmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentNumber = 11,
                            Name = "CE"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentNumber = 10,
                            Name = "CSMath"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentNumber = 12,
                            Name = "EE"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentNumber = 13,
                            Name = "Physics"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentNumber = 14,
                            Name = "Languages"
                        });
                });

            modelBuilder.Entity("UCS.Domain.Entities.Professor", b =>
                {
                    b.HasBaseType("UCS.Domain.Entities.ApplicationUser");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Professor");

                    b.HasData(
                        new
                        {
                            Id = "2ee806a3-a456-428a-a940-e30d59e26c52",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "586859db-9c9a-46b4-9397-4df69a822d17",
                            DepartmentId = 5,
                            EmailConfirmed = false,
                            FullName = "firstmath lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "50a42331-1bd9-4d06-b8e7-716bc99ecc6c",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 6L,
                            State = 0
                        },
                        new
                        {
                            Id = "faa9dbf1-74eb-4892-9c7e-f63cf473f100",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "742210bd-0724-4331-91d3-20a816f801d9",
                            DepartmentId = 5,
                            EmailConfirmed = false,
                            FullName = "scndmath lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "daf17a2c-e3bc-4f85-9f4d-163a9079b66f",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 1L,
                            State = 0
                        },
                        new
                        {
                            Id = "bda18f05-be45-4ab2-ac9b-1e781cbe5e4d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce86c605-3a04-435d-bb2a-39c059b97d34",
                            DepartmentId = 1,
                            EmailConfirmed = false,
                            FullName = "firstce lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "370de4d5-71ae-48de-b410-de51e80f47f2",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 2L,
                            State = 0
                        },
                        new
                        {
                            Id = "d764961f-02c0-4a95-a4e0-06903d0673dc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af671ebf-abb4-434a-bd33-7a63881c8d3f",
                            DepartmentId = 2,
                            EmailConfirmed = false,
                            FullName = "firstee lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2ab5a807-d5ff-49a8-b9ac-eec77ae18a76",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 3L,
                            State = 0
                        },
                        new
                        {
                            Id = "521e7923-4ecb-4743-83eb-388430a7fb59",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4b79f1c8-9233-48d0-acbd-725076cbbf1d",
                            DepartmentId = 3,
                            EmailConfirmed = false,
                            FullName = "firstphys lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fa09fd7b-ca1a-4891-b8ef-fbbad6958fee",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 4L,
                            State = 0
                        },
                        new
                        {
                            Id = "6bc3e740-7777-477a-a9f3-0ef909f5a052",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0ecc54d3-d78f-4978-a4fe-a5b3d7c1601c",
                            DepartmentId = 4,
                            EmailConfirmed = false,
                            FullName = "firstlang lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "89787908-736f-48f1-ab8f-a7afa63b131f",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 5L,
                            State = 0
                        });
                });

            modelBuilder.Entity("UCS.Domain.Entities.Student", b =>
                {
                    b.HasBaseType("UCS.Domain.Entities.ApplicationUser");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("Major")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.Property("State")
                                .HasColumnName("Student_State");
                        });

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = "c7508609-edda-4350-8148-28b287ad4fd5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "74281312-cccc-411c-bb47-e6c2a7e8d776",
                            DepartmentId = 1,
                            EmailConfirmed = false,
                            FullName = "Hosein BN",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "118db891-b645-40ed-9e03-869c1d3078d5",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 990342348L,
                            Degree = 0,
                            Major = 6,
                            State = 16
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UCS.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UCS.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UCS.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UCS.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UCS.Domain.Entities.ApplicationUser", b =>
                {
                    b.HasOne("UCS.Domain.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UCS.Domain.Entities.Course", b =>
                {
                    b.HasOne("UCS.Domain.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UCS.Domain.Entities.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UCS.Domain.Entities.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}

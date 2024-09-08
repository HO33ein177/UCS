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
    [Migration("20240907105352_seedProfessorsToDb")]
    partial class seedProfessorsToDb
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
                            Id = "fb9f5cfb-2cea-447d-a851-20f8ad658842",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c3a372dd-0eb1-4699-9472-cf02869e4d9b",
                            DepartmentId = 5,
                            EmailConfirmed = false,
                            FullName = "firstmath lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0bad5af9-b609-4364-82b3-8ca3b9b2a2bd",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 6L,
                            State = 0
                        },
                        new
                        {
                            Id = "f595cf70-a628-4381-a614-888fd3576848",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac24d744-89a4-4803-8c18-3b12ca864419",
                            DepartmentId = 5,
                            EmailConfirmed = false,
                            FullName = "scndmath lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7783c571-2136-4fee-98ab-8a9e1e30360b",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 1L,
                            State = 0
                        },
                        new
                        {
                            Id = "72f5e62f-8f4f-419f-9cd3-b892567eda64",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17af40c9-d19b-4d68-a1cb-2343a2338896",
                            DepartmentId = 1,
                            EmailConfirmed = false,
                            FullName = "firstce lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7c72c6e3-fc16-4f33-8bd4-e49b010f9dfc",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 2L,
                            State = 0
                        },
                        new
                        {
                            Id = "40f62ce1-76b0-4dce-99d1-6bec646440ac",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba9991f8-11d2-43b4-8473-093713e727e6",
                            DepartmentId = 2,
                            EmailConfirmed = false,
                            FullName = "firstee lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "727b24a0-820a-4e20-a92f-138728ff3a92",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 3L,
                            State = 0
                        },
                        new
                        {
                            Id = "a7b37344-0acd-4f03-a4fd-138d97edd7bd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44082549-24ae-4b6e-aed5-9d0a88c36b5d",
                            DepartmentId = 3,
                            EmailConfirmed = false,
                            FullName = "firstphys lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "563ecfcb-9ae8-46fb-b3dd-6cec776a1633",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 4L,
                            State = 0
                        },
                        new
                        {
                            Id = "f69ffb4e-5f4a-4357-8650-bcb5134c4aa2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9dadb120-7f99-44a9-b7d3-ee0fad200c61",
                            DepartmentId = 4,
                            EmailConfirmed = false,
                            FullName = "firstlang lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8f443b9f-0ea2-4dac-87eb-ede2daff2445",
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
                            Id = "9f7ee44f-fdb3-484a-98ad-2494fa747b9d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0ffc99db-e181-4193-a52f-10679fd9ed08",
                            DepartmentId = 1,
                            EmailConfirmed = false,
                            FullName = "Hosein BN",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8a6233a9-6722-46fb-841f-3296c51dc1ac",
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

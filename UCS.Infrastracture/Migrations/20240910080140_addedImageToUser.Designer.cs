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
    [Migration("20240910080140_addedImageToUser")]
    partial class addedImageToUser
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

                    b.Property<string>("ImageUrl")
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
                            Id = "0403220c-4a5d-4eb1-996c-86363657a006",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c85a016-d079-4618-940f-a31afdf1044a",
                            DepartmentId = 5,
                            EmailConfirmed = false,
                            FullName = "firstmath lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "618f230c-d8c0-4d3b-a822-a532302bbb84",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 6L,
                            State = 0
                        },
                        new
                        {
                            Id = "bf358f62-8096-4aa1-9b2a-64815f28549a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6a49037f-3d06-482c-8398-4c715970fab5",
                            DepartmentId = 5,
                            EmailConfirmed = false,
                            FullName = "scndmath lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "552cdca9-1026-4323-b88d-c827ff5df558",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 1L,
                            State = 0
                        },
                        new
                        {
                            Id = "a833e5ae-ea71-4eec-942a-546c5dcd4ce9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e1229084-bc2d-41d7-b2cb-abf2f9e233c4",
                            DepartmentId = 1,
                            EmailConfirmed = false,
                            FullName = "firstce lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "318eaca4-747f-46b7-9838-2782d787d098",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 2L,
                            State = 0
                        },
                        new
                        {
                            Id = "9bff20e3-396b-4315-89fe-7590a6d8a69e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "733a3ffb-eaa1-4dec-8a67-13008de70500",
                            DepartmentId = 2,
                            EmailConfirmed = false,
                            FullName = "firstee lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00095903-1841-4dfb-98f1-0a863b35765c",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 3L,
                            State = 0
                        },
                        new
                        {
                            Id = "834ca086-6a69-431e-a675-0e4ff3c96c1b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a16e0d7a-eb39-4fbb-aabf-7366b62fd364",
                            DepartmentId = 3,
                            EmailConfirmed = false,
                            FullName = "firstphys lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "769831d6-bb0b-4770-8cfa-bab055a4f5e2",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 4L,
                            State = 0
                        },
                        new
                        {
                            Id = "8354a0cd-2bac-48be-9353-d294aaa07b2c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c78e9819-d3be-4dd0-9578-4044af3e521d",
                            DepartmentId = 4,
                            EmailConfirmed = false,
                            FullName = "firstlang lastname",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "307fb4d0-4716-4671-bf9d-12e98e36e770",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 5L,
                            State = 0
                        });
                });

            modelBuilder.Entity("UCS.Domain.Entities.Student", b =>
                {
                    b.HasBaseType("UCS.Domain.Entities.ApplicationUser");

                    b.Property<bool>("Allowed")
                        .HasColumnType("bit");

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
                            Id = "2c0bbb82-b814-4ee1-9572-c25ab685c32b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99d4981c-182d-40ce-9aa0-ec2a3d5b06a0",
                            DepartmentId = 1,
                            EmailConfirmed = false,
                            FullName = "Hosein BN",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f605f163-4363-4453-a77b-a2be10495586",
                            TwoFactorEnabled = false,
                            UniqueMemberId = 990342348L,
                            Allowed = true,
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

﻿// <auto-generated />
using System;
using E_LearningSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_LearningSite.Data.Migrations
{
    [DbContext(typeof(LearningContext))]
    partial class LearningContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("E_LearningSite.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Catalogue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Catalogues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "9th Grade - Mathematics Informatics",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "10th Grade - Science",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "9th Grade - Philosophy",
                            SchoolId = 2
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Discover the elements of the solar system",
                            Name = "Solar System",
                            SchoolId = 1,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 2,
                            Description = "Basic elements of OOP",
                            Name = "OOP",
                            SchoolId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Basic elements of cyber security",
                            Name = "Cyber Security",
                            SchoolId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 4,
                            Description = "Political, Economic and Diplomatic Causes in the Far East",
                            Name = "World Word II",
                            SchoolId = 2,
                            SubjectId = 4
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.CourseCatalogue", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogueId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "CatalogueId");

                    b.HasIndex("CatalogueId");

                    b.ToTable("CourseCatalogue");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Link = "Link 1",
                            Name = "Planets of the Solar system"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Link = "Link 2",
                            Name = "Natural satellites"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            Link = "Link 1",
                            Name = "Classes and Methods"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            Link = "Link 2",
                            Name = "Overload and Override"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            Link = "Link 1",
                            Name = "Malware"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            Link = "Link 2",
                            Name = "Data breaches"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            Link = "Link 1",
                            Name = "Chinese Warlords, Kuomintang and Marco Polo Incident(1937)"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            Link = "Link 2",
                            Name = "Soviet–Japanese border interests and the Battle of Khalkin Gol(1939)"
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CatalogueId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Mark")
                        .HasColumnType("real");

                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogueId");

                    b.HasIndex("CourseId");

                    b.HasIndex("MentorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessRights")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Mentors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessRights = 0,
                            BirthDate = new DateTime(1960, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marcel Popescu",
                            Photo = "mentor11.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccessRights = 0,
                            BirthDate = new DateTime(1970, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Adrian Barbu",
                            Photo = "mentor12.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 3,
                            AccessRights = 0,
                            BirthDate = new DateTime(1980, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Iulain Apostol",
                            Photo = "mentor13.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 4,
                            AccessRights = 0,
                            BirthDate = new DateTime(1964, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eric Angelescu",
                            Photo = "mentor21.jpg",
                            SchoolId = 2
                        },
                        new
                        {
                            Id = 5,
                            AccessRights = 0,
                            BirthDate = new DateTime(1970, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Emanuel Aramitu",
                            Photo = "mentor22.jpg",
                            SchoolId = 2
                        },
                        new
                        {
                            Id = 6,
                            AccessRights = 0,
                            BirthDate = new DateTime(1966, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Andrei Pavel",
                            Photo = "mentor23.jpg",
                            SchoolId = 2
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.MentorCatalogue", b =>
                {
                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogueId")
                        .HasColumnType("int");

                    b.HasKey("MentorId", "CatalogueId");

                    b.HasIndex("CatalogueId");

                    b.ToTable("MentorCatalogue");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Principal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessRights")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId")
                        .IsUnique();

                    b.ToTable("Principals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessRights = 2,
                            BirthDate = new DateTime(1950, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Georgiana Ionescu",
                            Photo = "principal1.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccessRights = 2,
                            BirthDate = new DateTime(1967, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marian Stanciulescu",
                            Photo = "principal2.jpg",
                            SchoolId = 2
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Harvard",
                            Photo = "school1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Oxford",
                            Photo = "school2.jpg"
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessRights")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CatalogueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogueId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessRights = 1,
                            BirthDate = new DateTime(1999, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Elena Diaconescu",
                            Photo = "student11.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccessRights = 1,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Costin Constantinescu",
                            Photo = "student12.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 3,
                            AccessRights = 1,
                            BirthDate = new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "George Iordanescu",
                            Photo = "student14.jpg",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 4,
                            AccessRights = 1,
                            BirthDate = new DateTime(1989, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Diana Petrache",
                            Photo = "student21.jpg",
                            SchoolId = 2
                        },
                        new
                        {
                            Id = 5,
                            AccessRights = 1,
                            BirthDate = new DateTime(2001, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dorian Stefan",
                            Photo = "student22.jpg",
                            SchoolId = 2
                        },
                        new
                        {
                            Id = 6,
                            AccessRights = 1,
                            BirthDate = new DateTime(2000, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Andreea Popescu",
                            Photo = "student23.jpg",
                            SchoolId = 2
                        });
                });

            modelBuilder.Entity("E_LearningSite.Domain.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HISTORY",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "IT",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "ASTRONOMY",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "HISTORY",
                            SchoolId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT",
                            SchoolId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "ASTRONOMY",
                            SchoolId = 2
                        });
                });

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Catalogue", b =>
                {
                    b.HasOne("E_LearningSite.Domain.School", "School")
                        .WithMany("Catalogues")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Course", b =>
                {
                    b.HasOne("E_LearningSite.Domain.School", "School")
                        .WithMany("Courses")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("E_LearningSite.Domain.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("E_LearningSite.Domain.CourseCatalogue", b =>
                {
                    b.HasOne("E_LearningSite.Domain.Catalogue", "Catalogue")
                        .WithMany("CourseCatalogues")
                        .HasForeignKey("CatalogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_LearningSite.Domain.Course", "Course")
                        .WithMany("CourseCatalogues")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catalogue");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Document", b =>
                {
                    b.HasOne("E_LearningSite.Domain.Course", "Course")
                        .WithMany("Documents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Grade", b =>
                {
                    b.HasOne("E_LearningSite.Domain.Catalogue", "Catalogue")
                        .WithMany("Grades")
                        .HasForeignKey("CatalogueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("E_LearningSite.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_LearningSite.Domain.Mentor", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_LearningSite.Domain.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catalogue");

                    b.Navigation("Course");

                    b.Navigation("Mentor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Mentor", b =>
                {
                    b.HasOne("E_LearningSite.Domain.School", "School")
                        .WithMany("Mentors")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("E_LearningSite.Domain.MentorCatalogue", b =>
                {
                    b.HasOne("E_LearningSite.Domain.Catalogue", "Catalogue")
                        .WithMany("MentorCatalogues")
                        .HasForeignKey("CatalogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_LearningSite.Domain.Mentor", "Mentor")
                        .WithMany("MentorCatalogues")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catalogue");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Principal", b =>
                {
                    b.HasOne("E_LearningSite.Domain.School", "School")
                        .WithOne("Principal")
                        .HasForeignKey("E_LearningSite.Domain.Principal", "SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Student", b =>
                {
                    b.HasOne("E_LearningSite.Domain.Catalogue", "Catalogue")
                        .WithMany("Students")
                        .HasForeignKey("CatalogueId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("E_LearningSite.Domain.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Catalogue");

                    b.Navigation("School");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Subject", b =>
                {
                    b.HasOne("E_LearningSite.Domain.School", "School")
                        .WithMany("Subjects")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
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
                    b.HasOne("E_LearningSite.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("E_LearningSite.Data.ApplicationUser", null)
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

                    b.HasOne("E_LearningSite.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("E_LearningSite.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_LearningSite.Domain.Catalogue", b =>
                {
                    b.Navigation("CourseCatalogues");

                    b.Navigation("Grades");

                    b.Navigation("MentorCatalogues");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Course", b =>
                {
                    b.Navigation("CourseCatalogues");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Mentor", b =>
                {
                    b.Navigation("MentorCatalogues");
                });

            modelBuilder.Entity("E_LearningSite.Domain.School", b =>
                {
                    b.Navigation("Catalogues");

                    b.Navigation("Courses");

                    b.Navigation("Mentors");

                    b.Navigation("Principal")
                        .IsRequired();

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("E_LearningSite.Domain.Subject", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}

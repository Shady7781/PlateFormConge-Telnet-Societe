﻿// <auto-generated />
using System;
using API_Test.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Test.Migrations
{
    [DbContext(typeof(TelnetContext))]
    [Migration("20190731183451_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_Test.Entities.Conge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CongeState");

                    b.Property<DateTime>("end_Date");

                    b.Property<DateTime>("start_Date");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("Half_Day");

                    b.Property<string>("Motif");

                    b.Property<int>("Reason");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Conges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CongeState = 2,
                            end_Date = new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            start_Date = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            Half_Day = 0,
                            Motif = "Sickness",
                            Reason = 0
                        },
                        new
                        {
                            Id = 2,
                            CongeState = 0,
                            end_Date = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            start_Date = new DateTime(2018, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 3,
                            Half_Day = 0,
                            Motif = "Pregnancy",
                            Reason = 2
                        });
                });

            modelBuilder.Entity("API_Test.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<int>("InitialCongeSolde");

                    b.Property<string>("LastName");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.Property<int>("RemainingCongeSolde");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Tarek",
                            InitialCongeSolde = 31,
                            LastName = "ElGhali",
                            Login = "Tarek.ElGhali",
                            Password = "azerty",
                            RemainingCongeSolde = 29
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Sameh",
                            InitialCongeSolde = 25,
                            LastName = "Ouederni",
                            Login = "Sameh.Ouederni",
                            Password = "123aze",
                            RemainingCongeSolde = 25
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Test",
                            InitialCongeSolde = 21,
                            LastName = "testing",
                            Login = "test",
                            Password = "admin",
                            RemainingCongeSolde = 21
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Mahdi",
                            InitialCongeSolde = 21,
                            LastName = "Turki",
                            Login = "Mahdi.Turki",
                            Password = "123",
                            RemainingCongeSolde = 18
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "5555",
                            InitialCongeSolde = 21,
                            LastName = "testing",
                            Login = "test",
                            Password = "admin",
                            RemainingCongeSolde = 21
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "6666",
                            InitialCongeSolde = 21,
                            LastName = "testing",
                            Login = "test",
                            Password = "admin",
                            RemainingCongeSolde = 21
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "7777",
                            InitialCongeSolde = 21,
                            LastName = "testing",
                            Login = "test",
                            Password = "admin",
                            RemainingCongeSolde = 21
                        });
                });

            modelBuilder.Entity("API_Test.Entities.Sortie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Motif");

                    b.Property<int>("SortieState");

                    b.Property<int>("SortieTime");

                    b.Property<DateTime>("Recovery_Date");

                    b.Property<DateTime>("Sortie_Date");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Sorties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 5,
                            Motif = "personnel",
                            SortieState = 1,
                            SortieTime = 3,
                            Recovery_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sortie_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 3,
                            Motif = "personnel",
                            SortieState = 1,
                            SortieTime = 0,
                            Recovery_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sortie_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 1,
                            Motif = "personnel",
                            SortieState = 1,
                            SortieTime = 2,
                            Recovery_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Sortie_Datee = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("API_Test.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ManagerId");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManagerId = 1
                        },
                        new
                        {
                            Id = 2,
                            ManagerId = 2
                        });
                });

            modelBuilder.Entity("API_Test.Entities.TeamEmployee", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("TeamId");

                    b.Property<int>("Id");

                    b.HasKey("EmployeeId", "TeamId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamEmployees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 3,
                            TeamId = 1,
                            Id = 1
                        },
                        new
                        {
                            EmployeeId = 4,
                            TeamId = 1,
                            Id = 2
                        },
                        new
                        {
                            EmployeeId = 5,
                            TeamId = 1,
                            Id = 3
                        },
                        new
                        {
                            EmployeeId = 1,
                            TeamId = 2,
                            Id = 4
                        });
                });

            modelBuilder.Entity("API_Test.Entities.Conge", b =>
                {
                    b.HasOne("API_Test.Entities.Employee", "Employee")
                        .WithMany("Conges")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API_Test.Entities.Sortie", b =>
                {
                    b.HasOne("API_Test.Entities.Employee", "Employee")
                        .WithMany("Sorties")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API_Test.Entities.Team", b =>
                {
                    b.HasOne("API_Test.Entities.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API_Test.Entities.TeamEmployee", b =>
                {
                    b.HasOne("API_Test.Entities.Employee", "Employee")
                        .WithMany("TeamEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("API_Test.Entities.Team", "Team")
                        .WithMany("TeamEmployees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

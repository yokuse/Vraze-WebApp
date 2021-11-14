﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vraze.Models;

namespace Vraze.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211114013221_secondCreate")]
    partial class secondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Vraze.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTutorialChallenge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MapImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Solution")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("Vraze.Models.ChallengeHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SessionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Solution")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ChallengeHistories");
                });

            modelBuilder.Entity("Vraze.Models.Facilitator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSystemAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Facilitators");
                });

            modelBuilder.Entity("Vraze.Models.GameSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedByFacilitatorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SessionEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SessionStartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GameSessions");
                });

            modelBuilder.Entity("Vraze.Models.Hint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HintInformation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("Hints");
                });

            modelBuilder.Entity("Vraze.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GameSessionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasCompletedTutorial")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GameSessionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Vraze.Models.Hint", b =>
                {
                    b.HasOne("Vraze.Models.Challenge", null)
                        .WithMany("Hints")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vraze.Models.Student", b =>
                {
                    b.HasOne("Vraze.Models.GameSession", null)
                        .WithMany("StudentList")
                        .HasForeignKey("GameSessionId");
                });

            modelBuilder.Entity("Vraze.Models.Challenge", b =>
                {
                    b.Navigation("Hints");
                });

            modelBuilder.Entity("Vraze.Models.GameSession", b =>
                {
                    b.Navigation("StudentList");
                });
#pragma warning restore 612, 618
        }
    }
}

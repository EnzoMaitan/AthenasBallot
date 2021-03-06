﻿// <auto-generated />
using System;
using AthenasBallot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AthenasBallot.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Ballot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BallotStatus");

                    b.HasKey("Id");

                    b.ToTable("Ballots");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.BallotRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BallotID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("StudentID");

                    b.Property<int>("SystemOperatorID");

                    b.HasKey("Id");

                    b.HasIndex("BallotID");

                    b.HasIndex("StudentID");

                    b.HasIndex("SystemOperatorID");

                    b.ToTable("BallotRegistries");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.CandidateProcess", b =>
                {
                    b.Property<int>("CandidateID");

                    b.Property<int>("ProcessID");

                    b.HasKey("CandidateID", "ProcessID");

                    b.HasIndex("ProcessID");

                    b.ToTable("CandidateProcesses");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Party", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("LogoImage");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("InitialDate");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<DateTime>("RegistryDate");

                    b.Property<string>("StudentClass");

                    b.Property<string>("StudentNumber");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Student");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.SystemOperator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<DateTime>("RegistryDate");

                    b.Property<int>("Role");

                    b.HasKey("Id");

                    b.ToTable("SystemOperators");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.VoteRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BallotID");

                    b.Property<int>("ProcessID");

                    b.Property<int>("VoterID");

                    b.HasKey("Id");

                    b.HasIndex("BallotID");

                    b.HasIndex("ProcessID");

                    b.HasIndex("VoterID");

                    b.ToTable("VoteRegistries");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Candidate", b =>
                {
                    b.HasBaseType("AthenasBallot.Classes.Entities.Student");

                    b.Property<int>("PartyID");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasIndex("PartyID");

                    b.ToTable("Candidate");

                    b.HasDiscriminator().HasValue("Candidate");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Voter", b =>
                {
                    b.HasBaseType("AthenasBallot.Classes.Entities.Student");


                    b.ToTable("Voter");

                    b.HasDiscriminator().HasValue("Voter");
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.BallotRegistry", b =>
                {
                    b.HasOne("AthenasBallot.Classes.Entities.Ballot", "Ballot")
                        .WithMany()
                        .HasForeignKey("BallotID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AthenasBallot.Classes.Entities.Student", "student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AthenasBallot.Classes.Entities.SystemOperator", "SystemOperator")
                        .WithMany()
                        .HasForeignKey("SystemOperatorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.CandidateProcess", b =>
                {
                    b.HasOne("AthenasBallot.Classes.Entities.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AthenasBallot.Classes.Entities.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.VoteRegistry", b =>
                {
                    b.HasOne("AthenasBallot.Classes.Entities.Ballot", "Ballot")
                        .WithMany()
                        .HasForeignKey("BallotID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AthenasBallot.Classes.Entities.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AthenasBallot.Classes.Entities.Voter", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AthenasBallot.Classes.Entities.Candidate", b =>
                {
                    b.HasOne("AthenasBallot.Classes.Entities.Party", "Party")
                        .WithMany()
                        .HasForeignKey("PartyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetRegister.Data;

namespace PetRegister.Migrations
{
    [DbContext(typeof(PetRegisterContext))]
    [Migration("20220319210856_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetRegister.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("PetRegister.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.Property<float>("WeightInKg")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetRegister.Models.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SpeciesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specieses");
                });

            modelBuilder.Entity("PetRegister.Models.VetVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VetVisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("VetVisits");
                });

            modelBuilder.Entity("PetRegister.Models.Pet", b =>
                {
                    b.HasOne("PetRegister.Models.Gender", "Gender")
                        .WithMany("Pets")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetRegister.Models.Species", "Species")
                        .WithMany("Pets")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("Species");
                });

            modelBuilder.Entity("PetRegister.Models.VetVisit", b =>
                {
                    b.HasOne("PetRegister.Models.Pet", "Pet")
                        .WithMany("VetVisites")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("PetRegister.Models.Gender", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetRegister.Models.Pet", b =>
                {
                    b.Navigation("VetVisites");
                });

            modelBuilder.Entity("PetRegister.Models.Species", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}

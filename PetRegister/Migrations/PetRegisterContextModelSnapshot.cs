// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetRegister.Data;

namespace PetRegister.Migrations
{
    [DbContext(typeof(PetRegisterContext))]
    partial class PetRegisterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenderName = "male"
                        },
                        new
                        {
                            Id = 2,
                            GenderName = "female"
                        });
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
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.Property<float>("WeightInKg")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenderId = 1,
                            Name = "Tom",
                            SpeciesId = 1,
                            WeightInKg = 5f
                        },
                        new
                        {
                            Id = 2,
                            GenderId = 1,
                            Name = "Jerry",
                            SpeciesId = 2,
                            WeightInKg = 0.1f
                        },
                        new
                        {
                            Id = 3,
                            GenderId = 1,
                            Name = "Spike",
                            SpeciesId = 3,
                            WeightInKg = 30f
                        },
                        new
                        {
                            Id = 4,
                            GenderId = 2,
                            Name = "Shelkie",
                            SpeciesId = 1,
                            WeightInKg = 3f
                        });
                });

            modelBuilder.Entity("PetRegister.Models.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SpeciesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Specieses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SpeciesName = "cat"
                        },
                        new
                        {
                            Id = 2,
                            SpeciesName = "mouse"
                        },
                        new
                        {
                            Id = 3,
                            SpeciesName = "dog"
                        });
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

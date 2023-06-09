﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PredDiplom.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BookId");

                    b.Property<string>("Athor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("TimeOfIssue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeOfReturn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Athor = "Борис Стругатский, Аркадий Стругатский",
                            Description = "«Пикни́к на обо́чине» — философская фантастическая повесть братьев Стругацких, впервые изданная в 1972 году.",
                            Genre = "Фантастика",
                            IBAN = "1723323947",
                            Name = "Пикник на обочине",
                            TimeOfIssue = "22.03.2023",
                            TimeOfReturn = "14.04.2023"
                        },
                        new
                        {
                            Id = new Guid("c9d4c911-49b6-410c-bc78-2d54a9991870"),
                            Athor = "Борис Стругатский, Аркадий Стругатский",
                            Description = "««Град обрече́нный» — философский роман Аркадия и Бориса Стругацких. Писался «в стол», когда братья оказались в состоянии мировоззренческого кризиса, а затем были резко ограничены в возможностях публиковаться. ",
                            Genre = "Роман",
                            IBAN = "786324345",
                            Name = "Град обреченный",
                            TimeOfIssue = "22.03.2023",
                            TimeOfReturn = "14.04.2023"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

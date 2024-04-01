﻿// <auto-generated />
using System;
using ExemploApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExemploApi.Migrations
{
    [DbContext(typeof(DatabaseApi))]
    [Migration("20240401165204_Ini")]
    partial class Ini
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExemploApi.Core.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CriadoEm = new DateTime(2024, 4, 1, 13, 52, 3, 786, DateTimeKind.Local).AddTicks(7141),
                            Email = "Rafael@gmail.com",
                            Genero = 1,
                            Nome = "Rafael"
                        },
                        new
                        {
                            Id = 2,
                            CriadoEm = new DateTime(2024, 4, 1, 13, 52, 3, 786, DateTimeKind.Local).AddTicks(7143),
                            Email = "Fernando@gmail.com",
                            Genero = 1,
                            Nome = "Fernando"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
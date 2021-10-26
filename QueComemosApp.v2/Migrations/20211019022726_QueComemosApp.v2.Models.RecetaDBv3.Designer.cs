﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QueComemosApp.v2.Models;

namespace QueComemosApp.v2.Migrations
{
    [DbContext(typeof(RecetaDBContext))]
    [Migration("20211019022726_QueComemosApp.v2.Models.RecetaDBv3")]
    partial class QueComemosAppv2ModelsRecetaDBv3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QueComemosApp.v2.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecetaId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioNumeroUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecetaId");

                    b.HasIndex("UsuarioNumeroUsuario");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("QueComemosApp.v2.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TiempoPreparacion")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("QueComemosApp.v2.Usuario", b =>
                {
                    b.Property<int>("NumeroUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NumeroUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("QueComemosApp.v2.Ingrediente", b =>
                {
                    b.HasOne("QueComemosApp.v2.Receta", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("RecetaId");

                    b.HasOne("QueComemosApp.v2.Usuario", null)
                        .WithMany("MisIngredientes")
                        .HasForeignKey("UsuarioNumeroUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}

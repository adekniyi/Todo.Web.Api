﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoWebApi.Context;

namespace TodoWebApi.Migrations
{
    [DbContext(typeof(TodoInfoContext))]
    [Migration("20200901163113_initializing database")]
    partial class initializingdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoWebApi.Entities.Todo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("isCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("todo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            isCompleted = false,
                            todo = "do the laundry"
                        },
                        new
                        {
                            id = 2,
                            isCompleted = false,
                            todo = "read a novel"
                        },
                        new
                        {
                            id = 3,
                            isCompleted = false,
                            todo = "play game"
                        },
                        new
                        {
                            id = 4,
                            isCompleted = false,
                            todo = "visit a friend"
                        },
                        new
                        {
                            id = 5,
                            isCompleted = false,
                            todo = "write code"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
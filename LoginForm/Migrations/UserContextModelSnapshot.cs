﻿// <auto-generated />
using System;
using LoginForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginForm.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoginForm.Models.Likes", b =>
                {
                    b.Property<string>("CompositeKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LikedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompositeKey");

                    b.ToTable("Lik");

                    b.HasData(
                        new
                        {
                            CompositeKey = "Post1Root",
                            LikedBy = "Root",
                            PostId = "Post1"
                        });
                });

            modelBuilder.Entity("LoginForm.Models.Person", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecoveryEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Email = "Root@Root1",
                            Name = "Root",
                            Password = "Root",
                            RecoveryEmail = "Root@Root1"
                        },
                        new
                        {
                            Email = "Root@Root2",
                            Name = "Root2",
                            Password = "Root",
                            RecoveryEmail = "Root@Root2"
                        },
                        new
                        {
                            Email = "Root@Root3",
                            Name = "Root3",
                            Password = "Root",
                            RecoveryEmail = "Root@Root3"
                        },
                        new
                        {
                            Email = "Root@Root4",
                            Name = "Root4",
                            Password = "Root",
                            RecoveryEmail = "Root@Root4"
                        });
                });

            modelBuilder.Entity("LoginForm.Models.Post", b =>
                {
                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = "Post1",
                            Likes = 5,
                            PostDate = new DateTime(2023, 2, 6, 4, 46, 41, 89, DateTimeKind.Local).AddTicks(1687),
                            Text = "Example post 1",
                            UserEmail = "user1@example.com"
                        },
                        new
                        {
                            PostId = "Post2",
                            Likes = 3,
                            PostDate = new DateTime(2023, 2, 6, 4, 46, 41, 89, DateTimeKind.Local).AddTicks(1698),
                            Text = "Example post 2",
                            UserEmail = "user2@example.com"
                        },
                        new
                        {
                            PostId = "Post3",
                            Likes = 10,
                            PostDate = new DateTime(2023, 2, 6, 4, 46, 41, 89, DateTimeKind.Local).AddTicks(1700),
                            Text = "Example post 3",
                            UserEmail = "user3@example.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

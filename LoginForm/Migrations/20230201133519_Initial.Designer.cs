﻿// <auto-generated />
using LoginForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginForm.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230201133519_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
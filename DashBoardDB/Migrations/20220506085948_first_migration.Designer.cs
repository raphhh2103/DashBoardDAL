﻿// <auto-generated />
using DashBoardDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DashBoardDAL.Migrations
{
    [DbContext(typeof(DBConnect))]
    [Migration("20220506085948_first_migration")]
    partial class first_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DashBoardDAL.Entities.BoardEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("PK_Board");

                    b.HasIndex("Title");

                    b.ToTable("BoardEntity");
                });

            modelBuilder.Entity("DashBoardDAL.Entities.ContentEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id")
                        .HasName("PK_Content");

                    b.ToTable("ContentEntity");
                });

            modelBuilder.Entity("DashBoardDAL.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdUser")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PssWd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_User");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("UK_Email");

                    b.HasIndex("Pseudo")
                        .IsUnique()
                        .HasDatabaseName("UK_Pseudo");

                    b.ToTable("UserEntity");
                });

            modelBuilder.Entity("DashBoardDAL.Entities.BoardEntity", b =>
                {
                    b.HasOne("DashBoardDAL.Entities.UserEntity", "UserOwner")
                        .WithMany("Boards")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserOwner");
                });

            modelBuilder.Entity("DashBoardDAL.Entities.ContentEntity", b =>
                {
                    b.HasOne("DashBoardDAL.Entities.BoardEntity", "TitleBoard")
                        .WithMany("Contents")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TitleBoard");
                });

            modelBuilder.Entity("DashBoardDAL.Entities.BoardEntity", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("DashBoardDAL.Entities.UserEntity", b =>
                {
                    b.Navigation("Boards");
                });
#pragma warning restore 612, 618
        }
    }
}
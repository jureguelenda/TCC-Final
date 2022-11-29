﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC_2._0.Data;

#nullable disable

namespace TCC_2._0.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221128190110_tirandoitens")]
    partial class tirandoitens
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TCC_2._0.Models.CATEGORIA", b =>
                {
                    b.Property<int>("CATID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CATID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CATID"), 1L, 1);

                    b.Property<string>("CATDESCRICAO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CATDESCRICAO");

                    b.HasKey("CATID");

                    b.ToTable("CATEGORIA");
                });

            modelBuilder.Entity("TCC_2._0.Models.ENTRADA", b =>
                {
                    b.Property<int>("ENTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ENTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ENTID"), 1L, 1);

                    b.Property<DateTime>("ENTDATA")
                        .HasColumnType("datetime2")
                        .HasColumnName("ENTDATA");

                    b.Property<string>("ENTOBSERVACAO")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ENTOBSERVACAO");

                    b.Property<string>("ENTORIGEM")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ENTORIGEM");

                    b.HasKey("ENTID");

                    b.ToTable("ENTRADA");
                });

            modelBuilder.Entity("TCC_2._0.Models.ITENSENTRADA", b =>
                {
                    b.Property<int>("ITEID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ITEID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ITEID"), 1L, 1);

                    b.Property<int>("ENTID")
                        .HasColumnType("int");

                    b.Property<int>("ITEQUANTIDADE")
                        .HasColumnType("int")
                        .HasColumnName("ITEQUANTIDADE");

                    b.Property<int>("PTID")
                        .HasColumnType("int");

                    b.HasKey("ITEID");

                    b.HasIndex("ENTID");

                    b.HasIndex("PTID");

                    b.ToTable("ITENSENTRADA");
                });

            modelBuilder.Entity("TCC_2._0.Models.ITENSSAIDA", b =>
                {
                    b.Property<int>("ITSID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ITSID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ITSID"), 1L, 1);

                    b.Property<int>("ITSPRECO")
                        .HasColumnType("int")
                        .HasColumnName("ITSPRECO");

                    b.Property<int>("ITSQUANTIDADE")
                        .HasColumnType("int")
                        .HasColumnName("ITSQUANTIDADE");

                    b.Property<int>("PTID")
                        .HasColumnType("int");

                    b.Property<int>("SAIID")
                        .HasColumnType("int");

                    b.HasKey("ITSID");

                    b.HasIndex("PTID");

                    b.HasIndex("SAIID");

                    b.ToTable("ITENSSAIDA");
                });

            modelBuilder.Entity("TCC_2._0.Models.PRODUTO", b =>
                {
                    b.Property<int>("PROID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PROID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PROID"), 1L, 1);

                    b.Property<int>("CATID")
                        .HasColumnType("int");

                    b.Property<string>("PRODESCRICAO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PRODESCRICAO");

                    b.Property<byte[]>("PROIMAGEM")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PROIMAGEM");

                    b.HasKey("PROID");

                    b.HasIndex("CATID");

                    b.ToTable("PRODUTO");
                });

            modelBuilder.Entity("TCC_2._0.Models.PROTIPO", b =>
                {
                    b.Property<int>("PTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PTID"), 1L, 1);

                    b.Property<int>("PROID")
                        .HasColumnType("int");

                    b.Property<int>("PTESTOQUE")
                        .HasColumnType("int")
                        .HasColumnName("PTESTOQUE");

                    b.Property<byte[]>("PTIMAGEM")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PTIMAGEM");

                    b.Property<int>("PTMAXIMO")
                        .HasColumnType("int")
                        .HasColumnName("PTMAXIMO");

                    b.Property<int>("PTMINIMO")
                        .HasColumnType("int")
                        .HasColumnName("PTMINIMO");

                    b.Property<int>("TIPID")
                        .HasColumnType("int");

                    b.HasKey("PTID");

                    b.HasIndex("PROID");

                    b.HasIndex("TIPID");

                    b.ToTable("PROTIPO");
                });

            modelBuilder.Entity("TCC_2._0.Models.SAIDA", b =>
                {
                    b.Property<int>("SAIID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SAIID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SAIID"), 1L, 1);

                    b.Property<DateTime>("SAIDATA")
                        .HasColumnType("datetime2")
                        .HasColumnName("SAIDATA");

                    b.HasKey("SAIID");

                    b.ToTable("SAIDA");
                });

            modelBuilder.Entity("TCC_2._0.Models.TIPO", b =>
                {
                    b.Property<int>("TIPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TIPID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TIPID"), 1L, 1);

                    b.Property<string>("TIPNOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TIPNOME");

                    b.HasKey("TIPID");

                    b.ToTable("TIPO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TCC_2._0.Models.ITENSENTRADA", b =>
                {
                    b.HasOne("TCC_2._0.Models.ENTRADA", "ENTRADA")
                        .WithMany()
                        .HasForeignKey("ENTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC_2._0.Models.PROTIPO", "PROTIPO")
                        .WithMany()
                        .HasForeignKey("PTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ENTRADA");

                    b.Navigation("PROTIPO");
                });

            modelBuilder.Entity("TCC_2._0.Models.ITENSSAIDA", b =>
                {
                    b.HasOne("TCC_2._0.Models.PROTIPO", "PROTIPO")
                        .WithMany()
                        .HasForeignKey("PTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC_2._0.Models.SAIDA", "SAIDA")
                        .WithMany()
                        .HasForeignKey("SAIID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PROTIPO");

                    b.Navigation("SAIDA");
                });

            modelBuilder.Entity("TCC_2._0.Models.PRODUTO", b =>
                {
                    b.HasOne("TCC_2._0.Models.CATEGORIA", "CATEGORIA")
                        .WithMany()
                        .HasForeignKey("CATID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CATEGORIA");
                });

            modelBuilder.Entity("TCC_2._0.Models.PROTIPO", b =>
                {
                    b.HasOne("TCC_2._0.Models.PRODUTO", "PRODUTO")
                        .WithMany()
                        .HasForeignKey("PROID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC_2._0.Models.TIPO", "TIPO")
                        .WithMany()
                        .HasForeignKey("TIPID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PRODUTO");

                    b.Navigation("TIPO");
                });
#pragma warning restore 612, 618
        }
    }
}

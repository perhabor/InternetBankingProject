﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using internetBankingProject.Data;

namespace InternetBankingProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220129143003_ApplicationData")]
    partial class ApplicationData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("internetBankingProject.Models.AccountRight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountRights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Pamela",
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(6823),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(7152),
                            DeleteFlag = true,
                            IsActive = true,
                            ModifiedBy = " Admin",
                            Name = " Stan"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Pamela",
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(8033),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(8038),
                            DeleteFlag = true,
                            IsActive = true,
                            ModifiedBy = " Admin",
                            Name = " Isaac"
                        });
                });

            modelBuilder.Entity("internetBankingProject.Models.DeliveryMode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryModes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Pamela",
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(3706),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(4086),
                            DeleteFlag = true,
                            IsActive = true,
                            ModifiedBy = " Admin",
                            Name = " Emmauel"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Pamela",
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(5003),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 958, DateTimeKind.Local).AddTicks(5008),
                            DeleteFlag = true,
                            IsActive = true,
                            ModifiedBy = " Admin",
                            Name = " Isaac"
                        });
                });

            modelBuilder.Entity("internetBankingProject.Models.RetailAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("AccountLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("bit");

                    b.Property<int?>("DeliveryModeId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RetailUserId")
                        .HasColumnType("int");

                    b.Property<string>("Rights")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryModeId");

                    b.HasIndex("RetailUserId");

                    b.ToTable("RetailAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountLimit = 10000000m,
                            AccountType = "Current",
                            CreatedBy = "Pamela",
                            Currency = "Naira",
                            CustomerId = 1,
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(1705),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(2034),
                            DeleteFlag = true,
                            ModifiedBy = " Admin",
                            Name = " Emmauel",
                            RetailUserId = 1,
                            Rights = " Customer"
                        },
                        new
                        {
                            Id = 2,
                            AccountLimit = 20000000m,
                            AccountType = "Savings",
                            CreatedBy = "Pamela",
                            Currency = "Naira",
                            CustomerId = 2,
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(3180),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 959, DateTimeKind.Local).AddTicks(3184),
                            DeleteFlag = true,
                            ModifiedBy = " Admin",
                            Name = " Steph",
                            RetailUserId = 1,
                            Rights = " Customer"
                        });
                });

            modelBuilder.Entity("internetBankingProject.Models.RetailUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("bit");

                    b.Property<int>("DeliveryModeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryModeId");

                    b.ToTable("RetailUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Pamela",
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 955, DateTimeKind.Local).AddTicks(8120),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 956, DateTimeKind.Local).AddTicks(8668),
                            DeleteFlag = true,
                            DeliveryModeId = 1,
                            Email = "Samuelo@gmail.com ",
                            FirstName = " Samuel",
                            IsActive = true,
                            LastName = " Osoufia",
                            MiddleName = "Ajayi",
                            ModifiedBy = " Admin",
                            Password = "forever222",
                            Phone = "+2348124536609",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Pamela",
                            DateCreated = new DateTime(2022, 1, 29, 15, 30, 2, 956, DateTimeKind.Local).AddTicks(9833),
                            DateModified = new DateTime(2022, 1, 29, 15, 30, 2, 956, DateTimeKind.Local).AddTicks(9839),
                            DeleteFlag = true,
                            DeliveryModeId = 2,
                            Email = " abasa@gmail.com",
                            FirstName = " Abayomi",
                            IsActive = true,
                            LastName = " Osoufia",
                            MiddleName = "Abas",
                            ModifiedBy = " Admin",
                            Password = "forever12345",
                            Phone = "+2347124536609",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("internetBankingProject.Models.RetailAccount", b =>
                {
                    b.HasOne("internetBankingProject.Models.DeliveryMode", null)
                        .WithMany("RetailAccounts")
                        .HasForeignKey("DeliveryModeId");

                    b.HasOne("internetBankingProject.Models.RetailUser", "RetailUser")
                        .WithMany("RetailAccounts")
                        .HasForeignKey("RetailUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RetailUser");
                });

            modelBuilder.Entity("internetBankingProject.Models.RetailUser", b =>
                {
                    b.HasOne("internetBankingProject.Models.DeliveryMode", "DeliveryMode")
                        .WithMany()
                        .HasForeignKey("DeliveryModeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryMode");
                });

            modelBuilder.Entity("internetBankingProject.Models.DeliveryMode", b =>
                {
                    b.Navigation("RetailAccounts");
                });

            modelBuilder.Entity("internetBankingProject.Models.RetailUser", b =>
                {
                    b.Navigation("RetailAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}

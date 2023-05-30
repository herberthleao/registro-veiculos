﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VehicleRegistry.Infrastructure.Contexts;

#nullable disable

namespace VehicleRegistry.Migrations.Business
{
    [DbContext(typeof(BusinessContext))]
    [Migration("20230519053847_Business")]
    partial class Business
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3cb22682-044c-4747-a1d8-8e8cf0982748"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Fiat",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("549b5854-8885-4c66-8322-0a3c7fa0f373"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "GM",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("d69785ce-4841-4ff6-be11-584b1b82e71d"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Volkswagen",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("a26b77fc-336c-41a3-8b67-d8579811f115"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Toyota",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("4af78d17-cc18-4144-99dc-4c8f0e8d002f"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Hyundai",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("b4dfad56-bb52-41e2-aa8a-fa05e1b27ccf"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Jeep",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("e62be930-b819-49b4-901e-0a94b300cd91"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Renault",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("a80ad2f9-b50b-476a-842d-b12564f50011"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Honda",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("150e62cc-84be-4c98-9570-1b037e69d8d5"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Nissan",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("5b98e776-7b5e-42e5-aeac-7f591995ea75"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Peugeot",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("68d4d7ee-2842-41c4-97bc-952bb53b5fd9"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Ford",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        },
                        new
                        {
                            Id = new Guid("a4525922-664f-413f-b068-b7a118dc566d"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840),
                            Name = "Chevrolet",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5840)
                        });
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("TypeId");

                    b.ToTable("Models", (string)null);
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Owners", (string)null);
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FuelId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("FuelId");

                    b.HasIndex("ModelId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Vehicles", (string)null);
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.VehicleColor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("VehicleColors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4745231-46ba-4a53-b6b6-ac329d1ef1a3"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400),
                            Name = "Azul",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400)
                        },
                        new
                        {
                            Id = new Guid("0550da29-8022-4cb2-8de3-c4f503beab6d"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400),
                            Name = "Branco",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400)
                        },
                        new
                        {
                            Id = new Guid("74bf9c8a-262b-4325-aefc-1834f6e77192"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400),
                            Name = "Cinza",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400)
                        },
                        new
                        {
                            Id = new Guid("4d0ec66c-da8b-418c-9f8e-6b6c11ed4140"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400),
                            Name = "Preto",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400)
                        },
                        new
                        {
                            Id = new Guid("93e8104c-4ce7-40ce-b9e3-c988204ea615"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400),
                            Name = "Verde",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400)
                        },
                        new
                        {
                            Id = new Guid("c5eb6535-d793-4999-a398-aac479d6cea3"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400),
                            Name = "Vermelho",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5400)
                        });
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.VehicleFuel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("VehicleFuels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac936171-8484-4a8d-b736-a8a065f3af04"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720),
                            Name = "Álcool",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720)
                        },
                        new
                        {
                            Id = new Guid("22eb4bbe-ceba-435a-a554-15e8a2164a61"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720),
                            Name = "Diesel",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720)
                        },
                        new
                        {
                            Id = new Guid("19356992-5b66-4acf-9a81-6b157be60108"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720),
                            Name = "Gás",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720)
                        },
                        new
                        {
                            Id = new Guid("f6d65bc8-d211-440c-b5d5-a384cc20a3e5"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720),
                            Name = "Gasolina",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720)
                        },
                        new
                        {
                            Id = new Guid("0c15413b-05e4-4f61-80f7-09258edd9eea"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720),
                            Name = "Flex",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720)
                        },
                        new
                        {
                            Id = new Guid("cf8bfe79-67e2-41b6-92e8-944a520fc2bd"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720),
                            Name = "Nenhum",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5720)
                        });
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.VehicleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b46925bf-e18d-41ab-98b9-e8c74fffefe7"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Crossover",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("282d343c-5521-4f1e-9aab-b33c00dcbc5e"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Esportivo",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("21f23f60-c1b8-43ab-a20a-c8a50669ef25"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Furgão",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("c3100d62-cbfb-4a3c-9d91-db5ee71acb11"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Hatch",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("f85df1e9-9f24-460c-9d45-18cd3d60e7d5"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Minivan",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("650d9e17-2033-43a9-b20c-7ddacddbb691"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Perua",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("93f155e5-7588-4780-8da8-e873dc8e791c"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Picape",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("6091d04f-7ccd-496a-9189-90fbf0bc0f95"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "Sedã",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        },
                        new
                        {
                            Id = new Guid("e35fe407-5852-4bed-a932-4717a373cf6b"),
                            CreatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770),
                            Name = "SUV",
                            UpdatedAt = new DateTime(2023, 5, 19, 5, 38, 47, 513, DateTimeKind.Utc).AddTicks(5770)
                        });
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.Model", b =>
                {
                    b.HasOne("VehicleRegistry.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleRegistry.Domain.Entities.VehicleType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("VehicleRegistry.Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("VehicleRegistry.Domain.Entities.VehicleColor", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleRegistry.Domain.Entities.VehicleFuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleRegistry.Domain.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleRegistry.Domain.Entities.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Fuel");

                    b.Navigation("Model");

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
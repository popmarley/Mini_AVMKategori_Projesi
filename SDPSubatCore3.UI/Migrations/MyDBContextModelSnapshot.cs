﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDPSubatCore3.UI.Models.Core.Context;

namespace SDPSubatCore3.UI.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Calisan", b =>
                {
                    b.Property<int>("CalisanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnvanID")
                        .HasColumnType("int");

                    b.HasKey("CalisanID");

                    b.HasIndex("UnvanID");

                    b.ToTable("Calisans");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.CalisanOzlukBilgi", b =>
                {
                    b.Property<int>("CalisanOzlukBilgiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<string>("TC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CalisanOzlukBilgiID");

                    b.HasIndex("CalisanID")
                        .IsUnique();

                    b.ToTable("CalisanOzlukBilgis");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.CalisanTakim", b =>
                {
                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<int>("TakimID")
                        .HasColumnType("int");

                    b.HasKey("CalisanID", "TakimID");

                    b.HasIndex("TakimID");

                    b.ToTable("CalisanTakims");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Takim", b =>
                {
                    b.Property<int>("TakimtID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TakimAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TakimtID");

                    b.ToTable("Takims");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Unvan", b =>
                {
                    b.Property<int>("UnvanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnvanAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnvanID");

                    b.ToTable("Unvan");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Calisan", b =>
                {
                    b.HasOne("SDPSubatCore3.UI.Models.Core.Entities.Unvan", "Unvan")
                        .WithMany("Calisans")
                        .HasForeignKey("UnvanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unvan");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.CalisanOzlukBilgi", b =>
                {
                    b.HasOne("SDPSubatCore3.UI.Models.Core.Entities.Calisan", "Calisan")
                        .WithOne("CalisanOzlukBilgi")
                        .HasForeignKey("SDPSubatCore3.UI.Models.Core.Entities.CalisanOzlukBilgi", "CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.CalisanTakim", b =>
                {
                    b.HasOne("SDPSubatCore3.UI.Models.Core.Entities.Calisan", "Calisan")
                        .WithMany("CalisanTakims")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDPSubatCore3.UI.Models.Core.Entities.Takim", "Takim")
                        .WithMany("CalisanTakims")
                        .HasForeignKey("TakimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Takim");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Person", b =>
                {
                    b.OwnsOne("SDPSubatCore3.UI.Models.Core.Entities.PersonAdress", "PersonAdress", b1 =>
                        {
                            b1.Property<int>("PersonID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Sehir");

                            b1.Property<string>("Country")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Ulke");

                            b1.HasKey("PersonID");

                            b1.ToTable("People");

                            b1.WithOwner()
                                .HasForeignKey("PersonID");
                        });

                    b.OwnsOne("SDPSubatCore3.UI.Models.Core.Entities.PersonName", "PersonName", b1 =>
                        {
                            b1.Property<int>("PersonID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("MidName")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("SecoundName");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("Surname")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PersonID");

                            b1.ToTable("People");

                            b1.WithOwner()
                                .HasForeignKey("PersonID");
                        });

                    b.Navigation("PersonAdress");

                    b.Navigation("PersonName");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Product", b =>
                {
                    b.HasOne("SDPSubatCore3.UI.Models.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Calisan", b =>
                {
                    b.Navigation("CalisanOzlukBilgi");

                    b.Navigation("CalisanTakims");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Takim", b =>
                {
                    b.Navigation("CalisanTakims");
                });

            modelBuilder.Entity("SDPSubatCore3.UI.Models.Core.Entities.Unvan", b =>
                {
                    b.Navigation("Calisans");
                });
#pragma warning restore 612, 618
        }
    }
}

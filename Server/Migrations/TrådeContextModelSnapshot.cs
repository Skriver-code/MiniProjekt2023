﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(TrådeContext))]
    partial class TrådeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Shared.Bruger", b =>
                {
                    b.Property<int>("BrugerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brugernavn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BrugerId");

                    b.ToTable("Bruger");
                });

            modelBuilder.Entity("Shared.Kommentar", b =>
                {
                    b.Property<int>("KommentarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrugerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dato")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Downvote")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TrådeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Upvote")
                        .HasColumnType("INTEGER");

                    b.HasKey("KommentarId");

                    b.HasIndex("BrugerId");

                    b.HasIndex("TrådeId");

                    b.ToTable("Kommentar");
                });

            modelBuilder.Entity("Shared.Tråde", b =>
                {
                    b.Property<int>("TrådeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrugerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dato")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Downvote")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tråde_Overskrift")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Upvote")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrådeId");

                    b.HasIndex("BrugerId");

                    b.ToTable("Trådes");
                });

            modelBuilder.Entity("Shared.Kommentar", b =>
                {
                    b.HasOne("Shared.Bruger", "Bruger")
                        .WithMany()
                        .HasForeignKey("BrugerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Tråde", null)
                        .WithMany("Kommentare")
                        .HasForeignKey("TrådeId");

                    b.Navigation("Bruger");
                });

            modelBuilder.Entity("Shared.Tråde", b =>
                {
                    b.HasOne("Shared.Bruger", "bruger")
                        .WithMany()
                        .HasForeignKey("BrugerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bruger");
                });

            modelBuilder.Entity("Shared.Tråde", b =>
                {
                    b.Navigation("Kommentare");
                });
#pragma warning restore 612, 618
        }
    }
}

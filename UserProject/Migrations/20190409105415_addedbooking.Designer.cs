﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserProject.Models;

namespace AdminProject.Migrations
{
    [DbContext(typeof(FinalProjectDataDbContext))]
    [Migration("20190409105415_addedbooking")]
    partial class addedbooking
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminProject.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AudiName");

                    b.Property<double>("BookingAmount");

                    b.Property<DateTime>("BookingDate");

                    b.Property<string>("ShowTiming");

                    b.Property<int>("UserDetailId");

                    b.HasKey("BookingId");

                    b.HasIndex("UserDetailId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("AdminProject.Models.BookingDetail", b =>
                {
                    b.Property<int>("BookingId");

                    b.Property<int>("MovieId");

                    b.Property<int>("QtySeats");

                    b.HasKey("BookingId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("AdminProject.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Pay");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AdminProject.Models.Review", b =>
                {
                    b.Property<int>("UserDetailId");

                    b.Property<int>("MovieId");

                    b.Property<string>("Comment");

                    b.HasKey("UserDetailId", "MovieId");

                    b.HasAlternateKey("MovieId", "UserDetailId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.HasIndex("UserDetailId")
                        .IsUnique();

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("UserProject.Models.Auditorium", b =>
                {
                    b.Property<int>("AuditoriumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuditoriumDescription");

                    b.Property<string>("AuditoriumName");

                    b.Property<int>("MultiplexId");

                    b.Property<int>("Seats");

                    b.Property<string>("Time1");

                    b.Property<string>("Time2");

                    b.Property<string>("Time3");

                    b.HasKey("AuditoriumId");

                    b.HasIndex("MultiplexId");

                    b.ToTable("Auditoriums");
                });

            modelBuilder.Entity("UserProject.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationImage");

                    b.Property<string>("LocationName")
                        .IsRequired();

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("UserProject.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MovieDate");

                    b.Property<string>("MovieDescription");

                    b.Property<string>("MovieDuration");

                    b.Property<string>("MovieImage");

                    b.Property<string>("MovieName");

                    b.Property<double>("MoviePrice");

                    b.Property<int>("MultiplexId");

                    b.HasKey("MovieId");

                    b.HasIndex("MultiplexId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("UserProject.Models.MovieDetail", b =>
                {
                    b.Property<int>("MovieDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Casting");

                    b.Property<string>("Director");

                    b.Property<string>("MovieDuration");

                    b.Property<int>("MovieId");

                    b.Property<string>("MovieImage");

                    b.Property<string>("MovieType");

                    b.Property<string>("Producer");

                    b.HasKey("MovieDetailId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MovieDetails");
                });

            modelBuilder.Entity("UserProject.Models.Multiplex", b =>
                {
                    b.Property<int>("MultiplexId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId");

                    b.Property<string>("MultiplexDescription")
                        .IsRequired();

                    b.Property<string>("MultiplexImage");

                    b.Property<string>("MultiplexName")
                        .IsRequired();

                    b.HasKey("MultiplexId");

                    b.HasIndex("LocationId");

                    b.ToTable("Multiplexes");
                });

            modelBuilder.Entity("UserProject.Models.UserDetail", b =>
                {
                    b.Property<int>("UserDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ContactNo");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserDetailID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("AdminProject.Models.Booking", b =>
                {
                    b.HasOne("UserProject.Models.UserDetail", "UserDetail")
                        .WithMany("Bookings")
                        .HasForeignKey("UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdminProject.Models.BookingDetail", b =>
                {
                    b.HasOne("AdminProject.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UserProject.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdminProject.Models.Review", b =>
                {
                    b.HasOne("UserProject.Models.Movie", "Movie")
                        .WithOne("Reviews")
                        .HasForeignKey("AdminProject.Models.Review", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UserProject.Models.UserDetail", "UserDetail")
                        .WithOne("Reviews")
                        .HasForeignKey("AdminProject.Models.Review", "UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UserProject.Models.Auditorium", b =>
                {
                    b.HasOne("UserProject.Models.Multiplex", "Multiplex")
                        .WithMany("Auditoriums")
                        .HasForeignKey("MultiplexId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UserProject.Models.Movie", b =>
                {
                    b.HasOne("UserProject.Models.Multiplex", "Multiplex")
                        .WithMany()
                        .HasForeignKey("MultiplexId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UserProject.Models.MovieDetail", b =>
                {
                    b.HasOne("UserProject.Models.Movie", "Movie")
                        .WithOne("MovieDetail")
                        .HasForeignKey("UserProject.Models.MovieDetail", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UserProject.Models.Multiplex", b =>
                {
                    b.HasOne("UserProject.Models.Location", "Location")
                        .WithMany("Multiplexes")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

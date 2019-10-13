﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scraper.Models;

namespace Scraper.Migrations
{
    [DbContext(typeof(ScraperContext))]
    partial class ScraperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scraper.Models.Session", b =>
                {
                    b.Property<DateTime>("requestTime");

                    b.Property<string>("appearedList");

                    b.Property<string>("keyWords");

                    b.Property<int>("numberOfResults");

                    b.Property<string>("query");

                    b.Property<string>("requestedUrl");

                    b.HasKey("requestTime");

                    b.ToTable("sessions");
                });

            modelBuilder.Entity("Scraper.Models.singleResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("sessionrequestTime");

                    b.Property<string>("url");

                    b.HasKey("Id");

                    b.HasIndex("sessionrequestTime");

                    b.ToTable("singleResults");
                });

            modelBuilder.Entity("Scraper.Models.singleResult", b =>
                {
                    b.HasOne("Scraper.Models.Session", "session")
                        .WithMany()
                        .HasForeignKey("sessionrequestTime");
                });
#pragma warning restore 612, 618
        }
    }
}

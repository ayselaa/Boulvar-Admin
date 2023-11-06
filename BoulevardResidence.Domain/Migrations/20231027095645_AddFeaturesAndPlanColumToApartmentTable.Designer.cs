﻿// <auto-generated />
using System;
using BoulevardResidence.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoulevardResidence.Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231027095645_AddFeaturesAndPlanColumToApartmentTable")]
    partial class AddFeaturesAndPlanColumToApartmentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Apartments.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartmentPlan")
                        .HasColumnType("text");

                    b.Property<string>("AreaTotal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("CustomStatusId")
                        .HasColumnType("integer");

                    b.Property<bool>("EuroLayout")
                        .HasColumnType("boolean");

                    b.Property<int>("Floor")
                        .HasColumnType("integer");

                    b.Property<bool>("FreeLayout")
                        .HasColumnType("boolean");

                    b.Property<int>("HouseId")
                        .HasColumnType("integer");

                    b.Property<string>("HouseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LayoutType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomsAmount")
                        .HasColumnType("integer");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SpecialOffersIds")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Studio")
                        .HasColumnType("boolean");

                    b.Property<string>("TypePurpose")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WithoutLayout")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.Architectural", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Architecturals");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ArchitecturalBlogs");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalBlogTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArchitecturalBlogId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ArchitecturalBlogId");

                    b.ToTable("ArchitecturalBlogTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArchitecturalId")
                        .HasColumnType("integer");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ArchitecturalId");

                    b.ToTable("ArchitecturalTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.Comfort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Comforts");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.ComfortBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ComfortBlogs");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.ComfortBlogTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ComfortBlogId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ComfortBlogId");

                    b.ToTable("ComfortBlogTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.ComfortTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ComfortId")
                        .HasColumnType("integer");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ComfortId");

                    b.ToTable("ComfortTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Contacts.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Features.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Features.FeatureTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("FeatureId")
                        .HasColumnType("integer");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.ToTable("FeatureTranslate");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Galleries.GalleryCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("GalleryCategories");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Galleries.GalleryCategoryTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("GalleryCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GalleryCategoryId");

                    b.ToTable("GalleryCategoryTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Galleries.GalleryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GalleryCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GalleryCategoryId");

                    b.ToTable("GalleryItems");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Headers.SectionBackgroundImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SectionBackgroundImages");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Infrastructures.Infrastructure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Infrastructures");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Infrastructures.InfrastructureTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("InfrastructureId")
                        .HasColumnType("integer");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InfrastructureId");

                    b.ToTable("InfrastructureTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Locations.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Settings.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Sliders.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Sliders.SliderHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("SliderHeaders");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Sliders.SliderHeaderTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SliderHeaderId")
                        .HasColumnType("integer");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SliderHeaderId");

                    b.ToTable("SliderHeaderTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Socials.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalBlogTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalBlog", null)
                        .WithMany("ArchitecturalBlogTranslates")
                        .HasForeignKey("ArchitecturalBlogId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.ArchitecturalElegances.Architectural", null)
                        .WithMany("ArchitecturalTranslates")
                        .HasForeignKey("ArchitecturalId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.ComfortBlogTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Comforts.ComfortBlog", null)
                        .WithMany("ComfortBlogTranslates")
                        .HasForeignKey("ComfortBlogId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.ComfortTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Comforts.Comfort", null)
                        .WithMany("ComfortTranslates")
                        .HasForeignKey("ComfortId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Features.Feature", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Apartments.Apartment", null)
                        .WithMany("Features")
                        .HasForeignKey("ApartmentId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Features.FeatureTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Features.Feature", null)
                        .WithMany("FeatureTranslates")
                        .HasForeignKey("FeatureId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Galleries.GalleryCategoryTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Galleries.GalleryCategory", null)
                        .WithMany("GalleryCategoryTranslates")
                        .HasForeignKey("GalleryCategoryId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Galleries.GalleryItem", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Galleries.GalleryCategory", "GalleryCategory")
                        .WithMany("GalleryItems")
                        .HasForeignKey("GalleryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GalleryCategory");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Infrastructures.InfrastructureTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Infrastructures.Infrastructure", null)
                        .WithMany("InfrastructureTranslates")
                        .HasForeignKey("InfrastructureId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Sliders.SliderHeaderTranslate", b =>
                {
                    b.HasOne("BoulevardResidence.Domain.Entity.Sliders.SliderHeader", null)
                        .WithMany("SliderHeaderTranslates")
                        .HasForeignKey("SliderHeaderId");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Apartments.Apartment", b =>
                {
                    b.Navigation("Features");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.Architectural", b =>
                {
                    b.Navigation("ArchitecturalTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.ArchitecturalElegances.ArchitecturalBlog", b =>
                {
                    b.Navigation("ArchitecturalBlogTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.Comfort", b =>
                {
                    b.Navigation("ComfortTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Comforts.ComfortBlog", b =>
                {
                    b.Navigation("ComfortBlogTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Features.Feature", b =>
                {
                    b.Navigation("FeatureTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Galleries.GalleryCategory", b =>
                {
                    b.Navigation("GalleryCategoryTranslates");

                    b.Navigation("GalleryItems");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Infrastructures.Infrastructure", b =>
                {
                    b.Navigation("InfrastructureTranslates");
                });

            modelBuilder.Entity("BoulevardResidence.Domain.Entity.Sliders.SliderHeader", b =>
                {
                    b.Navigation("SliderHeaderTranslates");
                });
#pragma warning restore 612, 618
        }
    }
}

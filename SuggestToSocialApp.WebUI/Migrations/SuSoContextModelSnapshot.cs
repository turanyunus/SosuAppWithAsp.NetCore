﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuggestToSocialApp.WebUI.Repository.Concrete.EF;

namespace SuggestToSocialApp.WebUI.Migrations
{
    [DbContext(typeof(SuSoContext))]
    partial class SuSoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryToPost");

                    b.Property<string>("CommentDesc");

                    b.Property<DateTime>("Date");

                    b.Property<int>("PostId");

                    b.Property<int>("SubjectId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName");

                    b.Property<int?>("PostId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("DisLike");

                    b.Property<string>("Image");

                    b.Property<int>("ImageId");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("Language");

                    b.Property<int>("Like");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.Property<int>("SubjectId");

                    b.Property<string>("Tag");

                    b.Property<int>("View");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Image", b =>
                {
                    b.HasOne("SuggestToSocialApp.WebUI.Entity.Post")
                        .WithMany("Images")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("SuggestToSocialApp.WebUI.Entity.Post", b =>
                {
                    b.HasOne("SuggestToSocialApp.WebUI.Entity.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuggestToSocialApp.WebUI.Entity.Subject", "Subject")
                        .WithMany("Posts")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

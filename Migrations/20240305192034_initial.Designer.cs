﻿// <auto-generated />
using FAQs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FAQs.Migrations
{
    [DbContext(typeof(FAQsContext))]
    [Migration("20240305192034_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FAQs.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "hist",
                            Name = "History"
                        },
                        new
                        {
                            CategoryId = "gen",
                            Name = "General"
                        });
                });

            modelBuilder.Entity("FAQs.Models.FAQ", b =>
                {
                    b.Property<int>("FAQId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAQId"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FAQId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TopicId");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            FAQId = 1,
                            Answer = "January 5, 2002",
                            CategoryId = "hist",
                            Question = "When did ASP.NET come out?",
                            TopicId = "aspnet"
                        },
                        new
                        {
                            FAQId = 2,
                            Answer = "2000",
                            CategoryId = "hist",
                            Question = "When did C# come out?",
                            TopicId = "csharp"
                        },
                        new
                        {
                            FAQId = 3,
                            Answer = "1995",
                            CategoryId = "hist",
                            Question = "When did Javascript come out?",
                            TopicId = "javascript"
                        },
                        new
                        {
                            FAQId = 4,
                            Answer = "Building great websites and web applications using HTML, CSS, and JavaScript. You can also create Web APIs and use real-time technologies like Web Sockets.",
                            CategoryId = "gen",
                            Question = "What is ASP.NET best used for?",
                            TopicId = "aspnet"
                        },
                        new
                        {
                            FAQId = 5,
                            Answer = "To create a number of different programs and applications: mobile apps, desktop apps, cloud-based services, websites, enterprise software and games",
                            CategoryId = "gen",
                            Question = "What is C# used for?",
                            TopicId = "csharp"
                        },
                        new
                        {
                            FAQId = 6,
                            Answer = "Used to develop web pages. Developed in Netscape, JS allows developers to create a dynamic and interactive web page to interact with visitors and execute complex actions. It also enables users to load content into a document without reloading the entire page",
                            CategoryId = "gen",
                            Question = "What is Javascript used for?",
                            TopicId = "javascript"
                        });
                });

            modelBuilder.Entity("FAQs.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "aspnet",
                            Name = "ASP.NET"
                        },
                        new
                        {
                            TopicId = "csharp",
                            Name = "C#"
                        },
                        new
                        {
                            TopicId = "javascript",
                            Name = "JavaScript"
                        });
                });

            modelBuilder.Entity("FAQs.Models.FAQ", b =>
                {
                    b.HasOne("FAQs.Models.Category", "Category")
                        .WithMany("FAQs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FAQs.Models.Topic", "Topic")
                        .WithMany("FAQs")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("FAQs.Models.Category", b =>
                {
                    b.Navigation("FAQs");
                });

            modelBuilder.Entity("FAQs.Models.Topic", b =>
                {
                    b.Navigation("FAQs");
                });
#pragma warning restore 612, 618
        }
    }
}

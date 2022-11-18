﻿// <auto-generated />
using System;
using EcommerceWebVdo1.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceWebVdo1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceWebVdo1.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "video-games"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "book",
                            Name = "Novels",
                            Url = "novels"
                        });
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Play Station"
                        },
                        new
                        {
                            Id = 5,
                            Name = "E-book"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Audio book"
                        });
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a PC game. Developed by Ubisoft",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Far_Cry_3_PAL_box_art.jpg/220px-Far_Cry_3_PAL_box_art.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Farcry 3"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a PC game. Developed by Ubisoft",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/29/Assassin%27s_Creed_III_Game_Cover.jpg/220px-Assassin%27s_Creed_III_Game_Cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Assasins Creed 3"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a PC game. Developed by Rockstar Games",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "GTA 5"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a PC game. It is a story of Laura Craft",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/TombRaider2013.jpg/220px-TombRaider2013.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Tomb Raider 2013"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a Hollywood Movie in MCU",
                            Image = "https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Avengers EndGame"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a Hollywood Movie in DCU",
                            Image = "https://upload.wikimedia.org/wikipedia/en/6/6b/Justice_League_%28film%29_poster.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Justice League"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is noval written by KALKI",
                            Image = "https://upload.wikimedia.org/wikipedia/en/b/ba/Ponniyin_selvan_volume_1.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Ponniyin Selvan"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "It is a history play and tragedy by William Shakespeare",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Edwin_Austin_Abbey_-_Within_the_Tent_of_Brutus%2C_Enter_the_Ghost_of_Caesar%2C_Julius_Caesar%2C_Act_IV%2C_Scene_III_-_1937.1148_-_Yale_University_Art_Gallery.jpg/220px-Edwin_Austin_Abbey_-_Within_the_Tent_of_Brutus%2C_Enter_the_Ghost_of_Caesar%2C_Julius_Caesar%2C_Act_IV%2C_Scene_III_-_1937.1148_-_Yale_University_Art_Gallery.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Julius Caeser"
                        });
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 1999.99m,
                            Price = 499.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 2499.99m,
                            Price = 599.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 1699.99m,
                            Price = 449.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 3,
                            OriginalPrice = 1799.99m,
                            Price = 449.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 4,
                            OriginalPrice = 2299.99m,
                            Price = 519.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 1899.99m,
                            Price = 499.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 3,
                            OriginalPrice = 1399.99m,
                            Price = 399.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 4,
                            OriginalPrice = 2199.99m,
                            Price = 499.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 5,
                            OriginalPrice = 999.99m,
                            Price = 249.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 6,
                            OriginalPrice = 1399.99m,
                            Price = 349.99m
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 5,
                            OriginalPrice = 1199.99m,
                            Price = 299.99m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 1,
                            OriginalPrice = 899.99m,
                            Price = 199.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 1,
                            OriginalPrice = 799.99m,
                            Price = 149.99m
                        });
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("LastVisits")
                        .HasColumnType("datetime2");

                    b.Property<int>("Visits")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.Product", b =>
                {
                    b.HasOne("EcommerceWebVdo1.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.ProductVariant", b =>
                {
                    b.HasOne("EcommerceWebVdo1.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceWebVdo1.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EcommerceWebVdo1.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}

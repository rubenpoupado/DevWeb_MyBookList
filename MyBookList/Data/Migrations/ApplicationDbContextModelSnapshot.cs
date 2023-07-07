﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBookList.Data;

#nullable disable

namespace MyBookList.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorsBooks", b =>
                {
                    b.Property<int>("AuthorsListId")
                        .HasColumnType("int");

                    b.Property<int>("BookListId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsListId", "BookListId");

                    b.HasIndex("BookListId");

                    b.ToTable("AuthorsBooks");
                });

            modelBuilder.Entity("BooksGenres", b =>
                {
                    b.Property<int>("BooksListId")
                        .HasColumnType("int");

                    b.Property<int>("GenresListId")
                        .HasColumnType("int");

                    b.HasKey("BooksListId", "GenresListId");

                    b.HasIndex("GenresListId");

                    b.ToTable("BooksGenres");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyBookList.Models.Authors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "Cherie Priest is the author of two dozen books and novellas, most recently The Toll, The Family Plot, The Agony House, and the Philip K. Dick Award nominee Maplecroft; but she is perhaps best known for the steampunk pulp adventures of the Clockwork Century, beginning with Boneshaker. Her works have been nominated for the Hugo and Nebula awards for science fiction, and have won the Locus Award (among others) – and over the years, they’ve been translated into nine languages in eleven countries. Cherie lives in Seattle, WA, with her husband and a menagerie of exceedingly photogenic pets.",
                            Name = "Cherie Priest"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Timothy Thomas Powers is an American science fiction and fantasy author. Powers has won the World Fantasy Award twice for his critically acclaimed novels Last Call and Declare.\r\n\r\nMost of Powers's novels are \"secret histories\": he uses actual, documented historical events featuring famous people, but shows another view of them in which occult or supernatural factors heavily influence the motivations and actions of the characters.\r\n\r\n\r\nPowers was born in Buffalo, New York, and grew up in California, where his Roman Catholic family moved in 1959.\r\n\r\nHe studied English Literature at Cal State Fullerton, where he first met James Blaylock and K.W. Jeter, both of whom remained close friends and occasional collaborators; the trio have half-seriously referred to themselves as \"steampunks\" in contrast to the prevailing cyberpunk genre of the 1980s. Powers and Blaylock invented the poet William Ashbless while they were at Cal State Fullerton.\r\n\r\nAnother friend Powers first met during this period was noted science fiction writer Philip K. Dick; the character named \"David\" in Dick's novel VALIS is based on Powers and Do Androids Dream of Electric Sheep? (Blade Runner) is dedicated to him.\r\n\r\nPowers's first major novel was The Drawing of the Dark (1979), but the novel that earned him wide praise was The Anubis Gates, which won the Philip K. Dick Award, and has since been published in many other languages.\r\n\r\nPowers also teaches part-time in his role as Writer in Residence for the Orange County High School of the Arts where his friend, Blaylock, is Director of the Creative Writing Department. Powers and his wife, Serena, currently live in Muscoy, California. He has frequently served as a mentor author as part of the Clarion science fiction/fantasy writer's workshop.\r\n\r\nHe also taught part time at the University of Redlands.",
                            Name = "Tim Powers"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Alden Bell is a pseudonym for Joshua Gaylord, whose first novel, Hummingbirds, was released in Fall '09. He teaches at a New York City prep school and is an adjunct professor at The New School. He lives in New York City with his wife, the Edgar Award-winning mystery writer, Megan Abbott.",
                            Name = "Alden Bell"
                        });
                });

            modelBuilder.Entity("MyBookList.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PublisherFK")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherFK");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MyBookList.Models.Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Science Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Fantasy"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Adventure"
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Fiction"
                        },
                        new
                        {
                            Id = 6,
                            Genre = "Paranormal"
                        },
                        new
                        {
                            Id = 7,
                            Genre = "Mystery"
                        },
                        new
                        {
                            Id = 8,
                            Genre = "Historical"
                        },
                        new
                        {
                            Id = 9,
                            Genre = "Apocalyptic"
                        });
                });

            modelBuilder.Entity("MyBookList.Models.Members", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MyBookList.Models.Publishers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Tor Books is the primary imprint of Tor Publishing Group (previously Tom Doherty Associates), a publishing company based in New York City. It primarily publishes science fiction and fantasy titles.",
                            Name = "Tor Books"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ace Books is a publisher of science fiction and fantasy books founded in New York City in 1952 by Aaron A. Wyn. It began as a genre publisher of mysteries and westerns, and soon branched out into other genres, publishing its first science fiction title in 1953.",
                            Name = "Ace Books"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Holt Paperbacks publishes reprints from all the company’s adult imprints including Henry Holt, Metropolitan Books, and Times Books. Holt Paperbacks also publishes original trade paperbacks across all the categories that Henry Holt focuses on, including literary fiction, mysteries and thrillers, history, current events, social science, adventure, biography and memoir, personal development, and psychology. Whether as an original or reprint, every book on the Holt Paperbacks list strives to deliver to the paperback reader the same high caliber of information and entertainment that is the hallmark of all Henry Holt publications. Acclaimed and bestselling authors published under the Holt Paperbacks imprint include Rick Atkinson, Noam Chomsky, Barbara Ehrenreich, Harville Hendrix, Julie Morgenstern, and Stacy Schiff.",
                            Name = "Holt Paperbacks"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Test",
                            Name = "Babbage Press"
                        });
                });

            modelBuilder.Entity("MyBookList.Models.Status", b =>
                {
                    b.Property<int>("MemberFK")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("BookFK")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ScoreRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberFK", "BookFK");

                    b.HasIndex("BookFK");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("AuthorsBooks", b =>
                {
                    b.HasOne("MyBookList.Models.Authors", null)
                        .WithMany()
                        .HasForeignKey("AuthorsListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBookList.Models.Books", null)
                        .WithMany()
                        .HasForeignKey("BookListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BooksGenres", b =>
                {
                    b.HasOne("MyBookList.Models.Books", null)
                        .WithMany()
                        .HasForeignKey("BooksListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBookList.Models.Genres", null)
                        .WithMany()
                        .HasForeignKey("GenresListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyBookList.Models.Books", b =>
                {
                    b.HasOne("MyBookList.Models.Publishers", "Publisher")
                        .WithMany("BookList")
                        .HasForeignKey("PublisherFK");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("MyBookList.Models.Status", b =>
                {
                    b.HasOne("MyBookList.Models.Books", "Book")
                        .WithMany("StatusList")
                        .HasForeignKey("BookFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBookList.Models.Members", "Member")
                        .WithMany("StatusList")
                        .HasForeignKey("MemberFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MyBookList.Models.Books", b =>
                {
                    b.Navigation("StatusList");
                });

            modelBuilder.Entity("MyBookList.Models.Members", b =>
                {
                    b.Navigation("StatusList");
                });

            modelBuilder.Entity("MyBookList.Models.Publishers", b =>
                {
                    b.Navigation("BookList");
                });
#pragma warning restore 612, 618
        }
    }
}

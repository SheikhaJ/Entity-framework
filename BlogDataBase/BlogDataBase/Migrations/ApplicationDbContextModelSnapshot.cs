﻿// <auto-generated />
using BlogDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogDataBase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogDataBase.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Feild")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BlogDataBase.Model.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("blogId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("BlogDataBase.Model.blog", b =>
                {
                    b.Property<int>("blogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("blogId"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("blogId");

                    b.HasIndex("AuthorID")
                        .IsUnique();

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("BlogDataBase.Model.tag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tag");
                });

            modelBuilder.Entity("Posttag", b =>
                {
                    b.Property<int>("postsPostId")
                        .HasColumnType("int");

                    b.Property<int>("tagid")
                        .HasColumnType("int");

                    b.HasKey("postsPostId", "tagid");

                    b.HasIndex("tagid");

                    b.ToTable("Posttag");
                });

            modelBuilder.Entity("BlogDataBase.Model.Post", b =>
                {
                    b.HasOne("BlogDataBase.Model.blog", "blog")
                        .WithMany("Posts")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");
                });

            modelBuilder.Entity("BlogDataBase.Model.blog", b =>
                {
                    b.HasOne("BlogDataBase.Model.Author", "authour")
                        .WithOne("blog")
                        .HasForeignKey("BlogDataBase.Model.blog", "AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("authour");
                });

            modelBuilder.Entity("Posttag", b =>
                {
                    b.HasOne("BlogDataBase.Model.Post", null)
                        .WithMany()
                        .HasForeignKey("postsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogDataBase.Model.tag", null)
                        .WithMany()
                        .HasForeignKey("tagid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogDataBase.Model.Author", b =>
                {
                    b.Navigation("blog")
                        .IsRequired();
                });

            modelBuilder.Entity("BlogDataBase.Model.blog", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScifiTupi.API.Data;

namespace ScifiTupi.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("ScifiTupi.API.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Access")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<int>("Catid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CheckedOut")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CheckedOutTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedByAlias")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullText")
                        .HasColumnType("TEXT");

                    b.Property<int>("Hits")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageIcon")
                        .HasColumnType("TEXT");

                    b.Property<string>("IntroText")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetaDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Metadata")
                        .HasColumnType("TEXT");

                    b.Property<string>("Metakey")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ordering")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("PublishDownDt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PublishUpDt")
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Urls")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Catid");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ScifiTupi.API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<int>("Parent_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<int>("Published")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("hits")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ScifiTupi.API.Models.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Cid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentText")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ip")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("PublishDown")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PublishUp")
                        .HasColumnType("TEXT");

                    b.Property<int>("Published")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ScifiTupi.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Activation")
                        .HasColumnType("TEXT");

                    b.Property<int>("Block")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastResetTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastVisitDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Otep")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("OtpKey")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("Password")
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("RequireReset")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResetCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SendEmail")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ScifiTupi.API.Models.Article", b =>
                {
                    b.HasOne("ScifiTupi.API.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("Catid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScifiTupi.API.Models.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScifiTupi.API.Models.Comment", b =>
                {
                    b.HasOne("ScifiTupi.API.Models.Article", null)
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Academy.Migrations
{
    [DbContext(typeof(AcademyContext))]
    partial class AcademyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Academy.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<string>("BranchAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchNameAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Academy.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescriptionAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDescriptionEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Academy.Models.CategoryTrainers", b =>
                {
                    b.Property<int>("CategoryTrainersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryTrainersId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("CategoryTrainersId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TrainerId");

                    b.ToTable("CategoryTrainers");
                });

            modelBuilder.Entity("Academy.Models.ChampionChild", b =>
                {
                    b.Property<int>("ChampionChildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChampionChildId"));

                    b.Property<int>("ChampionsId")
                        .HasColumnType("int");

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.HasKey("ChampionChildId");

                    b.HasIndex("ChampionsId");

                    b.HasIndex("ChildId");

                    b.ToTable("ChampionChildren");
                });

            modelBuilder.Entity("Academy.Models.Champions", b =>
                {
                    b.Property<int>("ChampionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChampionsId"));

                    b.Property<string>("ChampionDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampionDescriptionAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampionDescriptionEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampionNameAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampionNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ChampionScore")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("ChampionsId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("Academy.Models.Child", b =>
                {
                    b.Property<int>("ChildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChildId"));

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("ChildId");

                    b.HasIndex("ParentId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("Academy.Models.ChildAbscess", b =>
                {
                    b.Property<int>("ChildAbscessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChildAbscessId"));

                    b.Property<DateTime>("AbsentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAbsent")
                        .HasColumnType("bit");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChildAbscessId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ChildId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Abscesses");
                });

            modelBuilder.Entity("Academy.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentDescriptionAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentDescriptionEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentNameAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DepartmentId");

                    b.HasIndex("BranchId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Academy.Models.MonthlyChildScore", b =>
                {
                    b.Property<int>("MonthlyChildScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthlyChildScoreId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("ScoreDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("MonthlyChildScoreId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ChildId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TrainerId");

                    b.ToTable("MonthlyChildScores");
                });

            modelBuilder.Entity("Academy.Models.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentId"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ParentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentId");

                    b.HasIndex("BranchId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Academy.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SubCategoryDescriptionAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategoryDescriptionEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategoryNameAR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategoryNameEN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Academy.Models.SubCategoryTrainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TrainerId");

                    b.ToTable("SubCategoryTrainer");
                });

            modelBuilder.Entity("Academy.Models.Subscriptions", b =>
                {
                    b.Property<int>("SubscriptionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionsId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubscriptionDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionsId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ChildId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Academy.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TrainerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerId");

                    b.HasIndex("BranchId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Academy.Models.Category", b =>
                {
                    b.HasOne("Academy.Models.Department", "Department")
                        .WithMany("Categories")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Academy.Models.CategoryTrainers", b =>
                {
                    b.HasOne("Academy.Models.Category", "Category")
                        .WithMany("CategoryTrainers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Models.Trainer", "Trainer")
                        .WithMany("CategoryTrainers")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Academy.Models.ChampionChild", b =>
                {
                    b.HasOne("Academy.Models.Champions", "Champions")
                        .WithMany("championChildren")
                        .HasForeignKey("ChampionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Models.Child", "Child")
                        .WithMany("ChampionChildren")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champions");

                    b.Navigation("Child");
                });

            modelBuilder.Entity("Academy.Models.Champions", b =>
                {
                    b.HasOne("Academy.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Academy.Models.Child", b =>
                {
                    b.HasOne("Academy.Models.Parent", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Academy.Models.ChildAbscess", b =>
                {
                    b.HasOne("Academy.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Academy.Models.Child", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Academy.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("Academy.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId");

                    b.Navigation("Category");

                    b.Navigation("Child");

                    b.Navigation("Department");

                    b.Navigation("SubCategory");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Academy.Models.Department", b =>
                {
                    b.HasOne("Academy.Models.Branch", "Branch")
                        .WithMany("Departments")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Academy.Models.MonthlyChildScore", b =>
                {
                    b.HasOne("Academy.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Academy.Models.Child", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Academy.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("Academy.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId");

                    b.Navigation("Category");

                    b.Navigation("Child");

                    b.Navigation("Department");

                    b.Navigation("SubCategory");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Academy.Models.Parent", b =>
                {
                    b.HasOne("Academy.Models.Branch", "Branch")
                        .WithMany("Parents")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Academy.Models.SubCategory", b =>
                {
                    b.HasOne("Academy.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Academy.Models.SubCategoryTrainer", b =>
                {
                    b.HasOne("Academy.Models.SubCategory", "SubCategory")
                        .WithMany("SubCategoryTrainers")
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("Academy.Models.Trainer", "Trainer")
                        .WithMany("subCategoryTrainers")
                        .HasForeignKey("TrainerId");

                    b.Navigation("SubCategory");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Academy.Models.Subscriptions", b =>
                {
                    b.HasOne("Academy.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Academy.Models.Child", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Academy.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("Academy.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Child");

                    b.Navigation("Department");

                    b.Navigation("SubCategory");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Academy.Models.Trainer", b =>
                {
                    b.HasOne("Academy.Models.Branch", "Branch")
                        .WithMany("Trainers")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Academy.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Academy.Models.Branch", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Parents");

                    b.Navigation("Trainers");
                });

            modelBuilder.Entity("Academy.Models.Category", b =>
                {
                    b.Navigation("CategoryTrainers");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Academy.Models.Champions", b =>
                {
                    b.Navigation("championChildren");
                });

            modelBuilder.Entity("Academy.Models.Child", b =>
                {
                    b.Navigation("ChampionChildren");
                });

            modelBuilder.Entity("Academy.Models.Department", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Academy.Models.Parent", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Academy.Models.SubCategory", b =>
                {
                    b.Navigation("SubCategoryTrainers");
                });

            modelBuilder.Entity("Academy.Models.Trainer", b =>
                {
                    b.Navigation("CategoryTrainers");

                    b.Navigation("subCategoryTrainers");
                });
#pragma warning restore 612, 618
        }
    }
}

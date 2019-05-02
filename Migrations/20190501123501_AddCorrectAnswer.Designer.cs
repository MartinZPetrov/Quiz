﻿// <auto-generated />
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190501123501_AddCorrectAnswer")]
    partial class AddCorrectAnswer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("DatingApp.API.Models.Answers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("CorrectAnswer");

                    b.Property<bool>("IsCorrect");

                    b.HasKey("Id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("DatingApp.API.Models.MultipleAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstAnswer");

                    b.Property<bool>("FirstAnswerCorrect");

                    b.Property<string>("SecondAnswer");

                    b.Property<bool>("SecondAnswerCorrect");

                    b.Property<bool>("ThirAnswerCorrect");

                    b.Property<string>("ThirdAnswer");

                    b.HasKey("Id");

                    b.ToTable("MultipleAnswers");
                });

            modelBuilder.Entity("DatingApp.API.Models.MultipleQuestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MultipleAnswersId");

                    b.Property<string>("Question");

                    b.HasKey("Id");

                    b.HasIndex("MultipleAnswersId");

                    b.ToTable("MultileQuestions");
                });

            modelBuilder.Entity("DatingApp.API.Models.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswersId");

                    b.Property<string>("Question");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DatingApp.API.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BinaryMode");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DatingApp.API.Models.MultipleQuestions", b =>
                {
                    b.HasOne("DatingApp.API.Models.MultipleAnswers", "MultipleAnswers")
                        .WithMany()
                        .HasForeignKey("MultipleAnswersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

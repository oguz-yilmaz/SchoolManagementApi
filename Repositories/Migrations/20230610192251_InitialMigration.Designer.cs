﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(SchoolManagementDbContext))]
    [Migration("20230610192251_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3");

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentsStudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoursesCourseId", "StudentsStudentId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeachersTeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoursesCourseId", "TeachersTeacherId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("CourseTeacher");
                });

            modelBuilder.Entity("Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "Mathematics course",
                            Name = "Mathematics"
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "Physics course",
                            Name = "Physics"
                        },
                        new
                        {
                            CourseId = 3,
                            Description = "Chemistry course",
                            Name = "Chemistry"
                        });
                });

            modelBuilder.Entity("Entities.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ExamId");

                    b.HasIndex("CourseId");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            ExamId = 1,
                            CourseId = 1,
                            ExamDate = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mathematics Exam 1"
                        },
                        new
                        {
                            ExamId = 2,
                            CourseId = 1,
                            ExamDate = new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mathematics Exam 2"
                        },
                        new
                        {
                            ExamId = 3,
                            CourseId = 2,
                            ExamDate = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Physics Exam 1"
                        },
                        new
                        {
                            ExamId = 4,
                            CourseId = 2,
                            ExamDate = new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Physics Exam 2"
                        },
                        new
                        {
                            ExamId = 5,
                            CourseId = 3,
                            ExamDate = new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Chemistry Exam 1"
                        });
                });

            modelBuilder.Entity("Entities.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExamId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Score")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GradeId");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = 1,
                            ExamId = 1,
                            Score = 50m,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 2,
                            ExamId = 2,
                            Score = 45m,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 3,
                            ExamId = 3,
                            Score = 30m,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 4,
                            ExamId = 4,
                            Score = 80m,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 5,
                            ExamId = 5,
                            Score = 100m,
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 6,
                            ExamId = 1,
                            Score = 50m,
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 7,
                            ExamId = 2,
                            Score = 40m,
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 8,
                            ExamId = 3,
                            Score = 30m,
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 9,
                            ExamId = 4,
                            Score = 20m,
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 10,
                            ExamId = 5,
                            Score = 10m,
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId");

                    b.HasIndex("StudentNumber")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Email = "john@doe.com",
                            FirstName = "John",
                            LastName = "Doe",
                            StudentNumber = 123456
                        },
                        new
                        {
                            StudentId = 2,
                            Email = "jane@doe.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            StudentNumber = 123457
                        },
                        new
                        {
                            StudentId = 3,
                            Email = "jack@doe.com",
                            FirstName = "Jack",
                            LastName = "Doe",
                            StudentNumber = 123458
                        });
                });

            modelBuilder.Entity("Entities.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            Email = "smith@edu.com",
                            FirstName = "John",
                            LastName = "Smith"
                        },
                        new
                        {
                            TeacherId = 2,
                            Email = "smith@edu.com",
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            TeacherId = 3,
                            Email = "smith@edu.com",
                            FirstName = "Jack",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("Entities.TeacherCourse", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("TeacherCourse");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.HasOne("Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Exam", b =>
                {
                    b.HasOne("Entities.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Entities.Grade", b =>
                {
                    b.HasOne("Entities.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.TeacherCourse", b =>
                {
                    b.HasOne("Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Entities.Course", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}

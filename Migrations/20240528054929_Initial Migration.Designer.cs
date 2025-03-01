﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240528054929_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.AddQualification", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProgramID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramId"));

                    b.Property<string>("Division")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("FromDate")
                        .HasColumnType("date");

                    b.Property<string>("Institute")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Percentage")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Program")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("ToDate")
                        .HasColumnType("date");

                    b.HasKey("ProgramId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Add_Qualification", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AddressID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("AddressType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Address_Type");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HouseNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InstantMessagingId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Locality")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Period")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("PinCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AddressId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EducationId"));

                    b.Property<string>("BoardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CGPAPercentage")
                        .HasColumnType("int");

                    b.Property<int?>("CGPAScale")
                        .HasColumnType("int");

                    b.Property<int?>("CGPAValue")
                        .HasColumnType("int");

                    b.Property<string>("ClgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CourseDurationFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CourseDurationTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Elective")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituteType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarkPercentage")
                        .HasColumnType("int");

                    b.Property<int?>("MaxMarks")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScoreType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalMarks")
                        .HasColumnType("int");

                    b.Property<string>("YOP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("WebApplication1.Models.Family", b =>
                {
                    b.Property<int>("FamilyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FamilyId"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Relationship")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FamilyId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Family", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<string>("LanguageName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<bool?>("Read")
                        .HasColumnType("bit");

                    b.Property<bool?>("Speak")
                        .HasColumnType("bit");

                    b.Property<bool?>("Write")
                        .HasColumnType("bit");

                    b.HasKey("LanguageId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("WebApplication1.Models.Passport", b =>
                {
                    b.Property<int>("PassportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassportId"));

                    b.Property<string>("DateOfExpiry")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DateOfIssue")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("HasValidVisa")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsOpenToTravel")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PassportId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Passport", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.PersonalDetail", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalId"));

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FatherName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MartialStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PanCardNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaceOfBirth")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sex")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SocialSecurityNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonalId");

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("WebApplication1.Models.Seminar", b =>
                {
                    b.Property<int>("SeminarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeminarId"));

                    b.Property<string>("ConductedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DurationFrom")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DurationTo")
                        .HasColumnType("date");

                    b.Property<int?>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("SeminarName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeminarId");

                    b.HasIndex("PersonalId");

                    b.ToTable("Seminar");
                });

            modelBuilder.Entity("WebApplication1.Models.AddQualification", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany("AddQualifications")
                        .HasForeignKey("PersonalId")
                        .HasConstraintName("FK_Add_Qualification_PersonalDetails");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonalId")
                        .HasConstraintName("FK_Address_PersonalDetails");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.Education", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany("Qualifications")
                        .HasForeignKey("PersonalId");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.Family", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany("Families")
                        .HasForeignKey("PersonalId")
                        .HasConstraintName("FK_Family_PersonalDetails");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.Language", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany("Languages")
                        .HasForeignKey("PersonalId")
                        .HasConstraintName("FK_Languages_PersonalDetails");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.Passport", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany("Passports")
                        .HasForeignKey("PersonalId")
                        .HasConstraintName("FK_Passport_PersonalDetails");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.Seminar", b =>
                {
                    b.HasOne("WebApplication1.Models.PersonalDetail", "Personal")
                        .WithMany()
                        .HasForeignKey("PersonalId");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("WebApplication1.Models.PersonalDetail", b =>
                {
                    b.Navigation("AddQualifications");

                    b.Navigation("Addresses");

                    b.Navigation("Families");

                    b.Navigation("Languages");

                    b.Navigation("Passports");

                    b.Navigation("Qualifications");
                });
#pragma warning restore 612, 618
        }
    }
}

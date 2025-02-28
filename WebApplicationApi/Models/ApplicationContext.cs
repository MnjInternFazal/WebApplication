using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationApi.Models;

public partial class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddQualification> AddQualifications { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Passport> Passports { get; set; }

    public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }

    public virtual DbSet<Seminar> Seminars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddQualification>(entity =>
        {
            entity.HasKey(e => e.ProgramId);

            entity.ToTable("Add_Qualification");

            entity.HasIndex(e => e.PersonalId, "IX_Add_Qualification_PersonalId");

            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.Division).HasMaxLength(50);
            entity.Property(e => e.Institute).HasMaxLength(50);
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Program).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.AddQualifications)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Add_Qualification_PersonalDetails");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.HasIndex(e => e.PersonalId, "IX_Address_PersonalId");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.AddressType)
                .HasMaxLength(50)
                .HasColumnName("Address_Type");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HouseNo).HasMaxLength(50);
            entity.Property(e => e.InstantMessagingId).HasMaxLength(50);
            entity.Property(e => e.Locality).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.PinCode).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Address_PersonalDetails");
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.ToTable("Education");

            entity.HasIndex(e => e.PersonalId, "IX_Education_PersonalId");

            entity.Property(e => e.Cgpapercentage).HasColumnName("CGPAPercentage");
            entity.Property(e => e.Cgpascale).HasColumnName("CGPAScale");
            entity.Property(e => e.Cgpavalue).HasColumnName("CGPAValue");
            entity.Property(e => e.Yop).HasColumnName("YOP");

            entity.HasOne(d => d.Personal).WithMany(p => p.Educations).HasForeignKey(d => d.PersonalId);
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.ToTable("Family");

            entity.HasIndex(e => e.PersonalId, "IX_Family_PersonalId");

            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.Families)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Family_PersonalDetails");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasIndex(e => e.PersonalId, "IX_Languages_PersonalId");

            entity.Property(e => e.LanguageName).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.Languages)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Languages_PersonalDetails");
        });

        modelBuilder.Entity<Passport>(entity =>
        {
            entity.ToTable("Passport");

            entity.HasIndex(e => e.PersonalId, "IX_Passport_PersonalId");

            entity.Property(e => e.DateOfExpiry).HasMaxLength(50);
            entity.Property(e => e.DateOfIssue).HasMaxLength(50);
            entity.Property(e => e.Number).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.Passports)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Passport_PersonalDetails");
        });

        modelBuilder.Entity<PersonalDetail>(entity =>
        {
            entity.HasKey(e => e.PersonalId);

            entity.Property(e => e.FatherName).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PanCardNumber).HasMaxLength(50);
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.SocialSecurityNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Seminar>(entity =>
        {
            entity.ToTable("Seminar");

            entity.HasIndex(e => e.PersonalId, "IX_Seminar_PersonalId");

            entity.HasOne(d => d.Personal).WithMany(p => p.Seminars).HasForeignKey(d => d.PersonalId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

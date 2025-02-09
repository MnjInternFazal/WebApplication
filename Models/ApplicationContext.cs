using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models;

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

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Passport> Passports { get; set; }

    public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder != null)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            //       => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Application;Integrated Security=True;");

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddQualification>(entity =>
        {
            entity.HasKey(e => e.ProgramId);

            entity.ToTable("Add_Qualification");

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

        modelBuilder.Entity<Family>(entity =>
        {
            entity.ToTable("Family");

            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.Families)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Family_PersonalDetails");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.LanguageName).HasMaxLength(50);

            entity.HasOne(d => d.Personal).WithMany(p => p.Languages)
                .HasForeignKey(d => d.PersonalId)
                .HasConstraintName("FK_Languages_PersonalDetails");
        });

        modelBuilder.Entity<Passport>(entity =>
        {
            entity.ToTable("Passport");

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

      
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<WebApplication1.Models.Seminar> Seminar { get; set; } = default!;

public DbSet<WebApplication1.Models.Education> Education { get; set; } = default!;
}

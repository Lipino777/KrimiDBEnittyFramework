using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KrimiDBEnittyFramework;

public partial class KrimiDatabaseContext : DbContext
{
    public KrimiDatabaseContext()
    {
    }

    public KrimiDatabaseContext(DbContextOptions<KrimiDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KrimiCrime> KrimiCrimes { get; set; }

    public virtual DbSet<KrimiInvestigation> KrimiInvestigations { get; set; }

    public virtual DbSet<KrimiLead> KrimiLeads { get; set; }

    public virtual DbSet<KrimiPerson> KrimiPeople { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LIPINODADERG;Database=krimiDatabase;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KrimiCrime>(entity =>
        {
            entity.HasKey(e => e.CrimeId);

            entity.ToTable("krimiCrime");

            entity.Property(e => e.CrimeId).HasColumnName("crimeID");
            entity.Property(e => e.CrimeAlias)
                .HasMaxLength(50)
                .HasColumnName("crimeAlias");
            entity.Property(e => e.CrimeDescript).HasColumnName("crimeDescript");
            entity.Property(e => e.CrimeInvestigId).HasColumnName("crimeInvestigID");
            entity.Property(e => e.CrimeVictimId).HasColumnName("crimeVictimID");

            entity.HasOne(d => d.CrimeInvestig).WithMany(p => p.KrimiCrimes)
                .HasForeignKey(d => d.CrimeInvestigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_krimiCrime_krimiInvestigation");

            entity.HasOne(d => d.CrimeVictim).WithMany(p => p.KrimiCrimes)
                .HasForeignKey(d => d.CrimeVictimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_krimiCrime_krimiPerson");
        });

        modelBuilder.Entity<KrimiInvestigation>(entity =>
        {
            entity.HasKey(e => e.InvestigationId);

            entity.ToTable("krimiInvestigation");

            entity.Property(e => e.InvestigationId).HasColumnName("investigationID");
            entity.Property(e => e.InvestigationLeadId).HasColumnName("investigationLeadID");
            entity.Property(e => e.InvestigationSuspectId).HasColumnName("investigationSuspectID");

            entity.HasOne(d => d.InvestigationLead).WithMany(p => p.KrimiInvestigations)
                .HasForeignKey(d => d.InvestigationLeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_krimiInvestigation_krimiLead");

            entity.HasOne(d => d.InvestigationSuspect).WithMany(p => p.KrimiInvestigations)
                .HasForeignKey(d => d.InvestigationSuspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_krimiInvestigation_krimiPerson");
        });

        modelBuilder.Entity<KrimiLead>(entity =>
        {
            entity.HasKey(e => e.LeadId);

            entity.ToTable("krimiLead");

            entity.Property(e => e.LeadId).HasColumnName("leadID");
            entity.Property(e => e.LeadAddress)
                .HasMaxLength(50)
                .HasColumnName("leadAddress");
            entity.Property(e => e.LeadDescription)
                .HasColumnType("text")
                .HasColumnName("leadDescription");
        });

        modelBuilder.Entity<KrimiPerson>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.ToTable("krimiPerson");

            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.PersonCrimeCount).HasColumnName("personCrimeCount");
            entity.Property(e => e.PersonFingerprint)
                .HasColumnType("image")
                .HasColumnName("personFingerprint");
            entity.Property(e => e.PersonFirstName)
                .HasMaxLength(30)
                .HasColumnName("personFirstName");
            entity.Property(e => e.PersonLastName)
                .HasMaxLength(30)
                .HasColumnName("personLastName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

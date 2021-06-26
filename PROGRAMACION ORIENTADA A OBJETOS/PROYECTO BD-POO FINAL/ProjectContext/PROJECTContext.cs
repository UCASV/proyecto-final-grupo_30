﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class PROJECTContext : DbContext
    {
        public PROJECTContext()
        {
        }

        public PROJECTContext(DbContextOptions<PROJECTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Booth> Booths { get; set; }
        public virtual DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<CitizenxChronicDisease> CitizenxChronicDiseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Management> Managements { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<Vaccination> Vaccinations { get; set; }
        public virtual DbSet<VaccinationPlace> VaccinationPlaces { get; set; }
        public virtual DbSet<VaccinationxSideEffect> VaccinationxSideEffects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = localhost; Database = PROJECT; Trusted_Connection = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppointment)
                    .HasName("PK__APPOINTM__F9CC20B753720BDD");

                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.Property(e => e.DateTimeAppointment1)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_appointment_1");

                entity.Property(e => e.DateTimeAppointment2)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_appointment_2");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdVaccinationPlace).HasColumnName("id_vaccination_place");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ci__45F365D3");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_em__440B1D61");

                entity.HasOne(d => d.IdVaccinationPlaceNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdVaccinationPlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_va__44FF419A");
            });

            modelBuilder.Entity<Booth>(entity =>
            {
                entity.HasKey(e => e.IdBooth)
                    .HasName("PK__BOOTH__16D433C1E66E6F7D");

                entity.ToTable("BOOTH");

                entity.HasIndex(e => e.Telephone, "UQ__BOOTH__61AE339B8707F9B9")
                    .IsUnique();

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.BoothAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("booth_address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Telephone).HasColumnName("telephone");
            });

            modelBuilder.Entity<ChronicDisease>(entity =>
            {
                entity.HasKey(e => e.IdChronicDisease)
                    .HasName("PK__CHRONIC___6BD38E9733B49E02");

                entity.ToTable("CHRONIC_DISEASE");

                entity.Property(e => e.IdChronicDisease).HasColumnName("id_chronic_disease");

                entity.Property(e => e.ChronicDisease1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chronic_disease");

                entity.Property(e => e.ChronicDiseaseDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("chronic_disease_description");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.IdCitizen)
                    .HasName("PK__CITIZEN__44393B8660898FC1");

                entity.ToTable("CITIZEN");

                entity.HasIndex(e => e.Telephone, "UQ__CITIZEN__61AE339B879AC2F9")
                    .IsUnique();

                entity.HasIndex(e => e.Dui, "UQ__CITIZEN__D876F1BFDBA309A3")
                    .IsUnique();

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.Property(e => e.CitizenAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizen_address");

                entity.Property(e => e.CitizenName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizen_name");

                entity.Property(e => e.Disability)
                    .HasColumnName("disability")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dui)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdInstitution)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_inst__46E78A0C");
            });

            modelBuilder.Entity<CitizenxChronicDisease>(entity =>
            {
                entity.HasKey(e => new { e.IdChronicDisease, e.IdCitizen })
                    .HasName("PK__CITIZENx__1F901D2FCB2816CE");

                entity.ToTable("CITIZENxCHRONIC_DISEASE");

                entity.Property(e => e.IdChronicDisease).HasColumnName("id_chronic_disease");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.HasOne(d => d.IdChronicDiseaseNavigation)
                    .WithMany(p => p.CitizenxChronicDiseases)
                    .HasForeignKey(d => d.IdChronicDisease)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZENxC__id_ch__4AB81AF0");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.CitizenxChronicDiseases)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZENxC__id_ci__49C3F6B7");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__EMPLOYEE__F807679CDA4D226D");

                entity.ToTable("EMPLOYEE");

                entity.HasIndex(e => e.Email, "UQ__EMPLOYEE__AB6E61643B3CD28E")
                    .IsUnique();

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_address");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.EmployeePassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_password");

                entity.Property(e => e.EmployeeUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_username");

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.HasOne(d => d.IdBoothNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdBooth)
                    .HasConstraintName("FK__EMPLOYEE__id_boo__412EB0B6");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_typ__403A8C7D");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK__EMPLOYEE__C3F091E0738ED4A3");

                entity.ToTable("EMPLOYEE_TYPE");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typename");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.HasKey(e => e.IdInstitution)
                    .HasName("PK__INSTITUT__512A185C97148AC6");

                entity.ToTable("INSTITUTION");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.Institution1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institution");
            });

            modelBuilder.Entity<Management>(entity =>
            {
                entity.HasKey(e => e.IdManagement)
                    .HasName("PK__MANAGEME__33C4FBFCD7708510");

                entity.ToTable("MANAGEMENT");

                entity.Property(e => e.IdManagement).HasColumnName("id_management");

                entity.Property(e => e.DateTimeLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_login");

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.HasOne(d => d.IdBoothNavigation)
                    .WithMany(p => p.Managements)
                    .HasForeignKey(d => d.IdBooth)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGEMEN__id_bo__4222D4EF");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Managements)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGEMEN__id_em__4316F928");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.HasKey(e => e.IdSideEffect)
                    .HasName("PK__SIDE_EFF__1301EE9AD63AD170");

                entity.ToTable("SIDE_EFFECT");

                entity.Property(e => e.IdSideEffect).HasColumnName("id_side_effect");

                entity.Property(e => e.SideEffect1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("side_effect");

                entity.Property(e => e.SideEffectDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("side_effect_description");
            });

            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.HasKey(e => e.IdVaccination)
                    .HasName("PK__VACCINAT__6F9C338C69882D94");

                entity.ToTable("VACCINATION");

                entity.Property(e => e.IdVaccination).HasColumnName("id_vaccination");

                entity.Property(e => e.DateTimeVaccine1)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_vaccine_1");

                entity.Property(e => e.DateTimeVaccine2)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_vaccine_2");

                entity.Property(e => e.DateTimeWait1)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_wait_1");

                entity.Property(e => e.DateTimeWait2)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_wait_2");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.Property(e => e.IdVaccinationPlace).HasColumnName("id_vaccination_place");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Vaccinations)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__id_ci__47DBAE45");

                entity.HasOne(d => d.IdVaccinationPlaceNavigation)
                    .WithMany(p => p.Vaccinations)
                    .HasForeignKey(d => d.IdVaccinationPlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__id_va__48CFD27E");
            });

            modelBuilder.Entity<VaccinationPlace>(entity =>
            {
                entity.HasKey(e => e.IdVaccinationPlace)
                    .HasName("PK__VACCINAT__5C434F1ABEE9653A");

                entity.ToTable("VACCINATION_PLACE");

                entity.Property(e => e.IdVaccinationPlace).HasColumnName("id_vaccination_place");

                entity.Property(e => e.VaccinationPlace1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccination_place");

                entity.Property(e => e.VaccinationPlaceAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vaccination_place_address");
            });

            modelBuilder.Entity<VaccinationxSideEffect>(entity =>
            {
                entity.HasKey(e => new { e.IdSideEffect, e.IdVaccination })
                    .HasName("PK__VACCINAT__C5F82DA2F663B080");

                entity.ToTable("VACCINATIONxSIDE_EFFECT");

                entity.Property(e => e.IdSideEffect).HasColumnName("id_side_effect");

                entity.Property(e => e.IdVaccination).HasColumnName("id_vaccination");

                entity.Property(e => e.DateTimeShowup)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time_showup");

                entity.HasOne(d => d.IdSideEffectNavigation)
                    .WithMany(p => p.VaccinationxSideEffects)
                    .HasForeignKey(d => d.IdSideEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__id_si__4BAC3F29");

                entity.HasOne(d => d.IdVaccinationNavigation)
                    .WithMany(p => p.VaccinationxSideEffects)
                    .HasForeignKey(d => d.IdVaccination)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__id_va__4CA06362");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
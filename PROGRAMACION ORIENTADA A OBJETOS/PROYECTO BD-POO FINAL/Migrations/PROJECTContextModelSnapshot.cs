﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROYECTO_BD_POO_FINAL.ProjectContext;

namespace PROYECTO_BD_POO_FINAL.Migrations
{
    [DbContext(typeof(PROJECTContext))]
    partial class PROJECTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Appointment", b =>
                {
                    b.Property<int>("IdAppointment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_appointment")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeAppointment1")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_appointment_1");

                    b.Property<DateTime?>("DateTimeAppointment2")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_appointment_2");

                    b.Property<int>("IdCitizen")
                        .HasColumnType("int")
                        .HasColumnName("id_citizen");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int")
                        .HasColumnName("id_employee");

                    b.Property<int>("IdVaccinationPlace")
                        .HasColumnType("int")
                        .HasColumnName("id_vaccination_place");

                    b.HasKey("IdAppointment")
                        .HasName("PK__APPOINTM__F9CC20B71396F311");

                    b.HasIndex("IdCitizen");

                    b.HasIndex("IdEmployee");

                    b.HasIndex("IdVaccinationPlace");

                    b.ToTable("APPOINTMENT");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Booth", b =>
                {
                    b.Property<int>("IdBooth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_booth")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BoothAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("booth_address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<int>("Telephone")
                        .HasColumnType("int")
                        .HasColumnName("telephone");

                    b.HasKey("IdBooth")
                        .HasName("PK__BOOTH__16D433C13AAA55BA");

                    b.HasIndex(new[] { "Telephone" }, "UQ__BOOTH__61AE339BE2441342")
                        .IsUnique();

                    b.ToTable("BOOTH");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.ChronicDisease", b =>
                {
                    b.Property<int>("IdChronicDisease")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_chronic_disease")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChronicDisease1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("chronic_disease");

                    b.Property<string>("ChronicDiseaseDescription")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("chronic_disease_description");

                    b.HasKey("IdChronicDisease")
                        .HasName("PK__CHRONIC___6BD38E97AAB18AA8");

                    b.ToTable("CHRONIC_DISEASE");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Citizen", b =>
                {
                    b.Property<int>("IdCitizen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_citizen")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CitizenAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("citizen_address");

                    b.Property<string>("CitizenName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("citizen_name");

                    b.Property<bool?>("Disability")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("disability")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Dui")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("dui");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<int>("IdInstitution")
                        .HasColumnType("int")
                        .HasColumnName("id_institution");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telephone");

                    b.HasKey("IdCitizen")
                        .HasName("PK__CITIZEN__44393B86C995009C");

                    b.HasIndex("IdInstitution");

                    b.HasIndex(new[] { "Telephone" }, "UQ__CITIZEN__61AE339B179EBB30")
                        .IsUnique();

                    b.HasIndex(new[] { "Dui" }, "UQ__CITIZEN__D876F1BFBBBC09C6")
                        .IsUnique();

                    b.ToTable("CITIZEN");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.CitizenxChronicDisease", b =>
                {
                    b.Property<int>("IdChronicDisease")
                        .HasColumnType("int")
                        .HasColumnName("id_chronic_disease");

                    b.Property<int>("IdCitizen")
                        .HasColumnType("int")
                        .HasColumnName("id_citizen");

                    b.HasKey("IdChronicDisease", "IdCitizen")
                        .HasName("PK__CITIZENx__1F901D2FA802FF45");

                    b.HasIndex("IdCitizen");

                    b.ToTable("CITIZENxCHRONIC_DISEASE");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Employee", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_employee")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("employee_address");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("employee_name");

                    b.Property<string>("EmployeePassword")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("employee_password");

                    b.Property<string>("EmployeeUsername")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("employee_username");

                    b.Property<int?>("IdBooth")
                        .HasColumnType("int")
                        .HasColumnName("id_booth");

                    b.Property<int>("IdType")
                        .HasColumnType("int")
                        .HasColumnName("id_type");

                    b.HasKey("IdEmployee")
                        .HasName("PK__EMPLOYEE__F807679CE875A6AC");

                    b.HasIndex("IdBooth");

                    b.HasIndex("IdType");

                    b.HasIndex(new[] { "Email" }, "UQ__EMPLOYEE__AB6E6164A9B228ED")
                        .IsUnique();

                    b.ToTable("EMPLOYEE");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.EmployeeType", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_type")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Typename")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("typename");

                    b.HasKey("IdType")
                        .HasName("PK__EMPLOYEE__C3F091E0EA84F535");

                    b.ToTable("EMPLOYEE_TYPE");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Institution", b =>
                {
                    b.Property<int>("IdInstitution")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_institution")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Institution1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("institution");

                    b.HasKey("IdInstitution")
                        .HasName("PK__INSTITUT__512A185C72DC062A");

                    b.ToTable("INSTITUTION");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Management", b =>
                {
                    b.Property<int>("IdManagement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_management")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeLogin")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_login");

                    b.Property<int>("IdBooth")
                        .HasColumnType("int")
                        .HasColumnName("id_booth");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int")
                        .HasColumnName("id_employee");

                    b.HasKey("IdManagement")
                        .HasName("PK__MANAGEME__33C4FBFCEF24CB1C");

                    b.HasIndex("IdBooth");

                    b.HasIndex("IdEmployee");

                    b.ToTable("MANAGEMENT");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.SideEffect", b =>
                {
                    b.Property<int>("IdSideEffect")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_side_effect")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SideEffect1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("side_effect");

                    b.Property<string>("SideEffectDescription")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("side_effect_description");

                    b.HasKey("IdSideEffect")
                        .HasName("PK__SIDE_EFF__1301EE9A216973CA");

                    b.ToTable("SIDE_EFFECT");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Vaccination", b =>
                {
                    b.Property<int>("IdVaccination")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_vaccination")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeVaccine1")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_vaccine_1");

                    b.Property<DateTime?>("DateTimeVaccine2")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_vaccine_2");

                    b.Property<DateTime?>("DateTimeWait1")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_wait_1");

                    b.Property<DateTime?>("DateTimeWait2")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_wait_2");

                    b.Property<int>("IdCitizen")
                        .HasColumnType("int")
                        .HasColumnName("id_citizen");

                    b.Property<int>("IdVaccinationPlace")
                        .HasColumnType("int")
                        .HasColumnName("id_vaccination_place");

                    b.HasKey("IdVaccination")
                        .HasName("PK__VACCINAT__6F9C338CDB25CDB2");

                    b.HasIndex("IdCitizen");

                    b.HasIndex("IdVaccinationPlace");

                    b.ToTable("VACCINATION");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.VaccinationPlace", b =>
                {
                    b.Property<int>("IdVaccinationPlace")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_vaccination_place")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VaccinationPlace1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("vaccination_place");

                    b.Property<string>("VaccinationPlaceAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("vaccination_place_address");

                    b.HasKey("IdVaccinationPlace")
                        .HasName("PK__VACCINAT__5C434F1AF368A40F");

                    b.ToTable("VACCINATION_PLACE");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.VaccinationxSideEffect", b =>
                {
                    b.Property<int>("IdSideEffect")
                        .HasColumnType("int")
                        .HasColumnName("id_side_effect");

                    b.Property<int>("IdVaccination")
                        .HasColumnType("int")
                        .HasColumnName("id_vaccination");

                    b.Property<DateTime?>("DateTimeShowup")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time_showup");

                    b.HasKey("IdSideEffect", "IdVaccination")
                        .HasName("PK__VACCINAT__C5F82DA2135E4AAD");

                    b.HasIndex("IdVaccination");

                    b.ToTable("VACCINATIONxSIDE_EFFECT");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Appointment", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Citizen", "IdCitizenNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdCitizen")
                        .HasConstraintName("FK__APPOINTME__id_ci__45F365D3")
                        .IsRequired();

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Employee", "IdEmployeeNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("FK__APPOINTME__id_em__440B1D61")
                        .IsRequired();

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.VaccinationPlace", "IdVaccinationPlaceNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdVaccinationPlace")
                        .HasConstraintName("FK__APPOINTME__id_va__44FF419A")
                        .IsRequired();

                    b.Navigation("IdCitizenNavigation");

                    b.Navigation("IdEmployeeNavigation");

                    b.Navigation("IdVaccinationPlaceNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Citizen", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Institution", "IdInstitutionNavigation")
                        .WithMany("Citizens")
                        .HasForeignKey("IdInstitution")
                        .HasConstraintName("FK__CITIZEN__id_inst__46E78A0C")
                        .IsRequired();

                    b.Navigation("IdInstitutionNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.CitizenxChronicDisease", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.ChronicDisease", "IdChronicDiseaseNavigation")
                        .WithMany("CitizenxChronicDiseases")
                        .HasForeignKey("IdChronicDisease")
                        .HasConstraintName("FK__CITIZENxC__id_ch__4AB81AF0")
                        .IsRequired();

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Citizen", "IdCitizenNavigation")
                        .WithMany("CitizenxChronicDiseases")
                        .HasForeignKey("IdCitizen")
                        .HasConstraintName("FK__CITIZENxC__id_ci__49C3F6B7")
                        .IsRequired();

                    b.Navigation("IdChronicDiseaseNavigation");

                    b.Navigation("IdCitizenNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Employee", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Booth", "IdBoothNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("IdBooth")
                        .HasConstraintName("FK__EMPLOYEE__id_boo__412EB0B6");

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.EmployeeType", "IdTypeNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("IdType")
                        .HasConstraintName("FK__EMPLOYEE__id_typ__403A8C7D")
                        .IsRequired();

                    b.Navigation("IdBoothNavigation");

                    b.Navigation("IdTypeNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Management", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Booth", "IdBoothNavigation")
                        .WithMany("Managements")
                        .HasForeignKey("IdBooth")
                        .HasConstraintName("FK__MANAGEMEN__id_bo__4222D4EF")
                        .IsRequired();

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Employee", "IdEmployeeNavigation")
                        .WithMany("Managements")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("FK__MANAGEMEN__id_em__4316F928")
                        .IsRequired();

                    b.Navigation("IdBoothNavigation");

                    b.Navigation("IdEmployeeNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Vaccination", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Citizen", "IdCitizenNavigation")
                        .WithMany("Vaccinations")
                        .HasForeignKey("IdCitizen")
                        .HasConstraintName("FK__VACCINATI__id_ci__47DBAE45")
                        .IsRequired();

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.VaccinationPlace", "IdVaccinationPlaceNavigation")
                        .WithMany("Vaccinations")
                        .HasForeignKey("IdVaccinationPlace")
                        .HasConstraintName("FK__VACCINATI__id_va__48CFD27E")
                        .IsRequired();

                    b.Navigation("IdCitizenNavigation");

                    b.Navigation("IdVaccinationPlaceNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.VaccinationxSideEffect", b =>
                {
                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.SideEffect", "IdSideEffectNavigation")
                        .WithMany("VaccinationxSideEffects")
                        .HasForeignKey("IdSideEffect")
                        .HasConstraintName("FK__VACCINATI__id_si__4BAC3F29")
                        .IsRequired();

                    b.HasOne("PROYECTO_BD_POO_FINAL.ProjectContext.Vaccination", "IdVaccinationNavigation")
                        .WithMany("VaccinationxSideEffects")
                        .HasForeignKey("IdVaccination")
                        .HasConstraintName("FK__VACCINATI__id_va__4CA06362")
                        .IsRequired();

                    b.Navigation("IdSideEffectNavigation");

                    b.Navigation("IdVaccinationNavigation");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Booth", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Managements");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.ChronicDisease", b =>
                {
                    b.Navigation("CitizenxChronicDiseases");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Citizen", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("CitizenxChronicDiseases");

                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Employee", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Managements");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.EmployeeType", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Institution", b =>
                {
                    b.Navigation("Citizens");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.SideEffect", b =>
                {
                    b.Navigation("VaccinationxSideEffects");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.Vaccination", b =>
                {
                    b.Navigation("VaccinationxSideEffects");
                });

            modelBuilder.Entity("PROYECTO_BD_POO_FINAL.ProjectContext.VaccinationPlace", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Vaccinations");
                });
#pragma warning restore 612, 618
        }
    }
}

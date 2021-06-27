using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            CitizenxChronicDiseases = new HashSet<CitizenxChronicDisease>();
            Vaccinations = new HashSet<Vaccination>();
        }

        public int IdCitizen { get; set; }
        public string Dui { get; set; }
        public string CitizenName { get; set; }
        public string CitizenAddress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int IdInstitution { get; set; }
        public bool? Disability { get; set; }

        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<CitizenxChronicDisease> CitizenxChronicDiseases { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
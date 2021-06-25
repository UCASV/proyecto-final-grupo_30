using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Vaccination
    {
        public Vaccination()
        {
            VaccinationxSideEffects = new HashSet<VaccinationxSideEffect>();
        }

        public int IdVaccination { get; set; }
        public DateTime? DateTimeWait1 { get; set; }
        public DateTime? DateTimeVaccine1 { get; set; }
        public DateTime? DateTimeWait2 { get; set; }
        public DateTime? DateTimeVaccine2 { get; set; }
        public int IdCitizen { get; set; }
        public int IdVaccinationPlace { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual VaccinationPlace IdVaccinationPlaceNavigation { get; set; }
        public virtual ICollection<VaccinationxSideEffect> VaccinationxSideEffects { get; set; }
    }
}

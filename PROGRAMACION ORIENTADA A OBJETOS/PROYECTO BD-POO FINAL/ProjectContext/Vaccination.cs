using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Vaccination
    {
        public Vaccination()
        {
            Reactions = new HashSet<Reaction>();
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
        public virtual ICollection<Reaction> Reactions { get; set; }

        public Vaccination(DateTime? dateTimeWait1, int idCitizen, int idVaccinationPlace)
        {
            DateTimeWait1 = dateTimeWait1;
            IdCitizen = idCitizen;
            IdVaccinationPlace = idVaccinationPlace;
        }

        public Vaccination(DateTime? dateTimeWait1, int idCitizen, int idVaccinationPlace, DateTime? dateTimeVaccine1)
        {
            DateTimeWait1 = dateTimeWait1;
            IdCitizen = idCitizen;
            IdVaccinationPlace = idVaccinationPlace;
            DateTimeVaccine1 = dateTimeVaccine1;
        }
    }
}

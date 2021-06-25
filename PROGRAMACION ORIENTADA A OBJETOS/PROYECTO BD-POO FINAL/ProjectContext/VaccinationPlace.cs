using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class VaccinationPlace
    {
        public VaccinationPlace()
        {
            Appointments = new HashSet<Appointment>();
            Vaccinations = new HashSet<Vaccination>();
        }

        public int IdVaccinationPlace { get; set; }
        public string VaccinationPlace1 { get; set; }
        public string VaccinationPlaceAddress { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}

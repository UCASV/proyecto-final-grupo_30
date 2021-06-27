using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Appointment
    {
        public int IdAppointment { get; set; }
        public DateTime? DateTimeAppointment1 { get; set; }
        public DateTime? DateTimeAppointment2 { get; set; }
        public int IdEmployee { get; set; }
        public int IdVaccinationPlace { get; set; }
        public int IdCitizen { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual VaccinationPlace IdVaccinationPlaceNavigation { get; set; }

        public Appointment()
        {
            
        }

        public Appointment(DateTime? dateTimeAppointment1, int idEmployee, int idVaccinationPlace, int idCitizen)
        {
            DateTimeAppointment1 = dateTimeAppointment1;
            IdEmployee = idEmployee;
            IdVaccinationPlace = idVaccinationPlace;
            IdCitizen = idCitizen;
        }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class VaccinationxSideEffect
    {
        public int IdSideEffect { get; set; }
        public int IdVaccination { get; set; }
        public DateTime? DateTimeShowup { get; set; }

        public virtual SideEffect IdSideEffectNavigation { get; set; }
        public virtual Vaccination IdVaccinationNavigation { get; set; }
    }
}

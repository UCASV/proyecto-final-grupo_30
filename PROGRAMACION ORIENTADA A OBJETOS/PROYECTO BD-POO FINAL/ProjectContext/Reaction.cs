using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Reaction
    {
        public Reaction(int idSideEffect, int idVaccination, int? minutesShowup)
        {
            IdSideEffect = idSideEffect;
            IdVaccination = idVaccination;
            MinutesShowup = minutesShowup;
        }

        public int IdReaction { get; set; }
        public int IdSideEffect { get; set; }
        public int IdVaccination { get; set; }
        public int? MinutesShowup { get; set; }

        public virtual SideEffect IdSideEffectNavigation { get; set; }
        public virtual Vaccination IdVaccinationNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class CitizenxChronicDisease
    {
        public CitizenxChronicDisease(int idChronicDisease, int idCitizen)
        {
            IdChronicDisease = idChronicDisease;
            IdCitizen = idCitizen;
        }

        public int IdChronicDisease { get; set; }
        public int IdCitizen { get; set; }

        public virtual ChronicDisease IdChronicDiseaseNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
    }
}

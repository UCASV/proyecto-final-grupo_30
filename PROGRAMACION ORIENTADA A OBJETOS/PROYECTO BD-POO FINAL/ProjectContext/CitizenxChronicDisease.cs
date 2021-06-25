using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class CitizenxChronicDisease
    {
        public int IdChronicDisease { get; set; }
        public int IdCitizen { get; set; }

        public virtual ChronicDisease IdChronicDiseaseNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
    }
}

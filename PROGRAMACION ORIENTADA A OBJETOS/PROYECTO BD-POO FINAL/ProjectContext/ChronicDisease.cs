using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class ChronicDisease
    {
        public ChronicDisease()
        {
            CitizenxChronicDiseases = new HashSet<CitizenxChronicDisease>();
        }

        public int IdChronicDisease { get; set; }
        public string ChronicDisease1 { get; set; }
        public string ChronicDiseaseDescription { get; set; }

        public virtual ICollection<CitizenxChronicDisease> CitizenxChronicDiseases { get; set; }
    }
}

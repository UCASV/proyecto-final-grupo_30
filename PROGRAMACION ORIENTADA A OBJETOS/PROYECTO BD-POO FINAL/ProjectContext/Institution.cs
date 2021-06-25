using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Institution
    {
        public Institution()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int IdInstitution { get; set; }
        public string Institution1 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}

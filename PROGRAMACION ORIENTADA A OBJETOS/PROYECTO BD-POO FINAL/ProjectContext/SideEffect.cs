using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Reactions = new HashSet<Reaction>();
        }

        public int IdSideEffect { get; set; }
        public string SideEffect1 { get; set; }
        public string SideEffectDescription { get; set; }

        public virtual ICollection<Reaction> Reactions { get; set; }
    }
}

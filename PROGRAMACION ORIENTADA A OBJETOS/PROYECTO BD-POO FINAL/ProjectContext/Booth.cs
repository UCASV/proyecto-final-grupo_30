using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Booth
    {
        public Booth()
        {
            Employees = new HashSet<Employee>();
            Managements = new HashSet<Management>();
        }

        public int IdBooth { get; set; }
        public string BoothAddress { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Management> Managements { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdType { get; set; }
        public string Typename { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

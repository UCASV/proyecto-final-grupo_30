using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Employee
    {
        public Employee()
        {
            Appointments = new HashSet<Appointment>();
            Managements = new HashSet<Management>();
        }

        public int IdEmployee { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }
        public int IdType { get; set; }
        public int? IdBooth { get; set; }

        public virtual Booth IdBoothNavigation { get; set; }
        public virtual EmployeeType IdTypeNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Management> Managements { get; set; }
    }
}

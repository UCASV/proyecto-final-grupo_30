using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_BD_POO_FINAL.ProjectContext
{
    public partial class Management
    {
        public Management(int idEmployee, int idBooth, DateTime? dateTimeLogin)
        {
            IdEmployee = idEmployee;
            IdBooth = idBooth;
            DateTimeLogin = dateTimeLogin;
        }

        public int IdManagement { get; set; }
        public int IdEmployee { get; set; }
        public int IdBooth { get; set; }
        public DateTime? DateTimeLogin { get; set; }

        public virtual Booth IdBoothNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}

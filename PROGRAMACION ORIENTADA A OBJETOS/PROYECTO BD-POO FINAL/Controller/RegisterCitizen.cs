using PROYECTO_BD_POO_FINAL.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BD_POO_FINAL.Controller
{
    public static class RegisterCitizen
    {
        //Registering Citizen
        public static void Save(string dui, string name, string address, string phoneNumber,  string email, Institution institution, bool disability)
        {
            //Creating New Citizen
            var db = new ProjectContext.PROJECTContext();
            var newCitizen = new Citizen();
            newCitizen.Dui = dui;
            newCitizen.CitizenName = name;
            newCitizen.Telephone = phoneNumber;
            newCitizen.CitizenAddress = address;
            newCitizen.Email = email;
            newCitizen.IdInstitution = institution.IdInstitution;
            newCitizen.Disability = disability;
            db.Add(newCitizen);
            db.SaveChanges();
        }
    }
}

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
        public static void Save(string name, string dui, string phoneNumber, string address, string email)
        {
            //Creating New Citizen
            var db = new PROJECTContext();
            var newCitizen = new Citizen();
            newCitizen.CitizenName = name;
            newCitizen.CitizenAddress = address;
            newCitizen.Email = email;
            db.Add(newCitizen);
            db.SaveChanges();

        }
    }
}

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
        public static bool Save(string dui, string name, string address, string phoneNumber,  string email, Institution institution, bool disability)
        {
            //Checking if user exists in database
            var userRef = new Citizen();
            userRef.Dui = dui;
            userRef.Telephone = phoneNumber;

            var db = new ProjectContext.PROJECTContext();

            var DBCitizenDUI = db.Set<Citizen>()
                .SingleOrDefault(c => c.IdCitizen == userRef.IdCitizen);
            var DBCitizenPhoneNUmber = db.Set<Citizen>()
                .SingleOrDefault(c => c.Telephone == userRef.Telephone);

            var citizenExists = (DBCitizenDUI is not null) || (DBCitizenPhoneNUmber is not null);

            try
            {
                //Creating New Citizen
                var newCitizen = new Citizen();
                newCitizen.Dui = dui;
                newCitizen.CitizenName = name;
                newCitizen.Telephone = phoneNumber;
                newCitizen.CitizenAddress = address;
                newCitizen.Email = email;
                newCitizen.IdInstitution = institution.IdInstitution;
                newCitizen.Disability = disability;
                newCitizen.Waiting = false;
                db.Add(newCitizen);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}

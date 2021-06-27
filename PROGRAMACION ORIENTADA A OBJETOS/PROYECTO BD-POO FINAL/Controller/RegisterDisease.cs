using PROYECTO_BD_POO_FINAL.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BD_POO_FINAL.Controller
{
    class RegisterDisease
    {
        public static void Add(int idCitizen, int idDisease)
        {
            var db = new ProjectContext.PROJECTContext();

            ChronicDisease cdDB = db.Set<ChronicDisease>()
            .SingleOrDefault(c => c.IdChronicDisease == idDisease);

            Citizen dbCitizen = db.Set<Citizen>()
                .SingleOrDefault(c => c.IdCitizen == idCitizen);

            CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

            db.Add(acCitizenxChronicDisease);
            db.SaveChanges();
        }
    }
}

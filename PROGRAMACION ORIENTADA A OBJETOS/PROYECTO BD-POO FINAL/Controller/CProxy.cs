using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_BD_POO_FINAL.ProjectContext;
using PROYECTO_BD_POO_FINAL.View;

namespace PROYECTO_BD_POO_FINAL.Controller
{
    public class CProxy
    {
        public interface ISubject
        {
            void Request(string user, string password);
        }

        public class RealSubject : ISubject
        {
            public void Request(string user, string password)
            {
                
            }
        }

        public class Proxy : ISubject
        {
            private RealSubject _realSubject;

            public Proxy(RealSubject realSubject)
            {
                this._realSubject = realSubject;
            }

            public void Request(string user, string password)
            {
                if (this.CheckAccess(user, password))
                {
                    this._realSubject.Request(user, password);
                }
            }

            public bool CheckAccess(string user, string password)
            {
                MessageBox.Show("Verificando datos ingresado por favor espere", "Vacunacion Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var db = new ProjectContext.PROJECTContext();
                var managerList = db.Employees
                    .Where(m => m.IdType == 1)
                    .ToList();

                var result = managerList.Where(
                    u => u.EmployeeUsername.Equals(user) &&
                         u.EmployeePassword.Equals(password) &&
                         u.IdType.Equals(1)
                ).ToList();

                if (result.Count == 0)
                {
                    MessageBox.Show("El gestor no existe o la contraseña y el usuario no coinciden", "Vacunación Covid",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
                else
                {
                    MessageBox.Show("Bienvenido", "Vacunación Covid",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
        }
    }
}

using APPPOOF.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class IEmploye: IUserType
    {
        public void UserType()
        {
            WindowEmploye ventana = new WindowEmploye();
            ventana.Show();
            

        }

        
    }
}

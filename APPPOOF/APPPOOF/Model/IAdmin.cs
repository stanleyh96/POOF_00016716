using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class IAdmin: IUserType
    {
        public void UserType()
        {
            WindowAdmin ventana = new WindowAdmin();
            ventana.Show();
        }
    }
}

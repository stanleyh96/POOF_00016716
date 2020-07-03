using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class IVigilant: IUserType
    {
        public void UserType()
        {
            WindowVigilant ventana = new WindowVigilant();
            ventana.Show();
        }
    }
}

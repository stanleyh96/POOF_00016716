using APPPOOF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APPPOOF.Controller;

namespace APPPOOF
{
    public partial class WindowEmploye : Form
    {
        
        public WindowEmploye( )
        {
            InitializeComponent();
            
        }

        private void buttonhistorial_Click(object sender, EventArgs e)
        {
            if (textBoxuser.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar datos vacios");
            }else
            {
                try
                {
                    int ID = Convert.ToInt32(textBoxuser.Text);
                    var dt =
                        ConnectionDB.query("select *  from registro r  "+
                                                  $"\n where r.idusuario= {ID} "); 
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Datos obtenidos exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema");
                }
            }
        }
    }
}

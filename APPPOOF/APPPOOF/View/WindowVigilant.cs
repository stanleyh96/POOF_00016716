using APPPOOF.Controller;
using APPPOOF.Model;
using System;

using System.Windows.Forms;

namespace APPPOOF
{
    public partial class WindowVigilant : Form
    {
        public WindowVigilant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                RegisterDAO.addRegister(DateTime.Now,Convert.ToInt32(textBoxcarnet.Text) , 
                    Convert.ToBoolean(comboBoxentrada.Text),Convert.ToInt32(textBoxtemperatura.Text));

                MessageBox.Show(" agregado exitosamente", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el data grid view (la tabla)
                //actualizarControlesUsuario();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

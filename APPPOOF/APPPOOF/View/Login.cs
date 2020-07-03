using APPPOOF.Model;
using System;
using System.Windows.Forms;

namespace APPPOOF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (comboBoxuser.SelectedValue.Equals(textBoxpassword.Text))
            {
                User u = (User) comboBoxuser.SelectedItem;
                Departament d = new Departament() ;
                IUserType tipo = new IEmploye();

                
                if ( u.idDepartamento==2) 
                {
                    tipo = new IAdmin();
                    //this.Hide();
                }
                else if ( u.idDepartamento == 3)
                {
                    tipo = new IVigilant();
                }
                else tipo = new IEmploye();

                tipo.UserType();

            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "CellphoneStore",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
        }

        private void poblarControles()
        {
            // Actualizar ComboBox
            comboBoxuser.DataSource = null;
            comboBoxuser.ValueMember = "contraseña";
            comboBoxuser.DisplayMember = "idUsuario";
            comboBoxuser.DataSource = UserDao.getLista();

           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

       
    }
}
